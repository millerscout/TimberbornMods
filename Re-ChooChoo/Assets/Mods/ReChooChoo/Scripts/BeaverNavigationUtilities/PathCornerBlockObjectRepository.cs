using System.Collections.Generic;
using ReChooChoo.Extensions;
using Timberborn.BlockSystem;
using Timberborn.Common;
using Timberborn.Navigation;
using UnityEngine;

namespace ReChooChoo.BeaverNavigationUtilities
{
    public class PathCornerBlockObjectRepository : INavMeshListener
    {
        private readonly BlockService _blockService;

        private readonly Dictionary<Vector3, BlockObject> _blockObjects = new();

        private PathCornerBlockObjectRepository(BlockService blockService)
        {
            _blockService = blockService;
        }

        public BlockObject Get(Vector3 coordinates)
        {
            return _blockObjects.GetOrAdd(coordinates, () => _blockService.GetBottomObjectAt(coordinates.ToBlockServicePosition()));
        }

        public void OnNavMeshUpdated(NavMeshUpdate navMeshUpdate)
        {
            _blockObjects.Clear();
        }
    }
}
