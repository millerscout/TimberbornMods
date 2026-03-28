using Timberborn.BlockSystem;
using Timberborn.MapIndexSystem;
using Timberborn.SingletonSystem;
using Timberborn.TickSystem;
using Timberborn.WaterObjects;
using Timberborn.WaterSystem;
using UnityEngine;

namespace Mods.ReEvaporation.Scripts
{
    public class EvaporationManager : ITickableSingleton, ILoadableSingleton
    {
        private readonly IBlockService _blockService;
        private readonly MapIndexService _mapIndexService;
        private readonly IThreadSafeWaterMap _threadSafeWaterMap;

        private bool[] _coverageCache = System.Array.Empty<bool>();
        private int _verticalStride;
        private int _tickCounter;

        // Cached settings — refreshed once per scan, read on every water sim step
        private bool _modEnabled = true;
        private float _coveredRate = 0.05f;
        private float _uncoveredRate = 1f;
        private int _maxSearchHeight = 15;
        private int _updateInterval = 111;

        public static EvaporationManager? Instance { get; private set; }

        public EvaporationManager(
            IBlockService blockService,
            MapIndexService mapIndexService,
            IThreadSafeWaterMap threadSafeWaterMap)
        {
            _blockService = blockService;
            _mapIndexService = mapIndexService;
            _threadSafeWaterMap = threadSafeWaterMap;
        }

        public void Load()
        {
            Instance = this;
            _verticalStride = _mapIndexService.VerticalStride;
            _coverageCache = new bool[_verticalStride * _mapIndexService.TotalSize.z];
            RefreshCachedSettings();
            Debug.Log("[Re-Evaporation] EvaporationManager successfully chilled.");
        }

        public void Tick()
        {
            _tickCounter++;
            if (_tickCounter >= _updateInterval)
            {
                UpdateAllWaterEvaporation();
                _tickCounter = 0;
            }
        }

        // Called from the transpiler patch on every wet cell per water sim sub-step.
        public float GetEvaporationMultiplier(int index3D)
        {
            if (!_modEnabled) return 1f;
            if ((uint)index3D >= (uint)_coverageCache.Length) return 1f;
            return _coverageCache[index3D] ? _coveredRate : _uncoveredRate;
        }

        private void UpdateAllWaterEvaporation()
        {
            RefreshCachedSettings();
            System.Array.Clear(_coverageCache, 0, _coverageCache.Length);
            Vector3Int totalSize = _mapIndexService.TotalSize;

            for (int y = 0; y < totalSize.y; y++)
            {
                for (int x = 0; x < totalSize.x; x++)
                {
                    int columnIndex = _mapIndexService.CellToIndex(new Vector2Int(x, y));
                    byte columnCount = _threadSafeWaterMap.ColumnCounts[columnIndex];

                    if (columnCount == 0) continue;

                    bool covered = IsWaterCovered(x, y);

                    for (int k = 0; k < columnCount; k++)
                    {
                        _coverageCache[columnIndex + k * _verticalStride] = covered;
                    }
                }
            }
        }

        internal void RefreshCachedSettings()
        {
            EvaporationSettings? s = ModInfo.SettingsOwner;
            if (s == null) return;
            _modEnabled = s.EnableMod;
            _coveredRate = s.GetValidatedEvaporationRate();
            _uncoveredRate = s.GetValidatedUncoveredEvaporationRate();
            _maxSearchHeight = s.GetValidatedMaxHeight();
            _updateInterval = s.GetValidatedUpdateInterval();
        }

        private bool IsWaterCovered(int x, int y)
        {
            int maxZ = 1 + _maxSearchHeight;
            for (int z = 1; z < maxZ; z++)
            {
                var pos = new Vector3Int(x, y, z);
                if (!_blockService.AnyObjectAt(pos)) continue;

                foreach (BlockObject obj in _blockService.GetObjectsAt(pos))
                {
                    if (obj.GetComponent<WaterObstacle>() != null)
                        return true;
                }
            }
            return false;
        }
    }
}
