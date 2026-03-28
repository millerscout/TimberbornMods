using Timberborn.Common;
using Timberborn.MapIndexSystem;
using Timberborn.Multithreading;
using UnityEngine;

namespace Timberborn.WaterSystem
{
	internal readonly struct UpdateWaterChangesTask : IParallelizerSingleTask
	{
		private readonly MapIndexService _mapIndexService;

		private readonly MutableWaterColumnRetriever _mutableWaterColumnRetriever;

		private readonly WaterColumn[] _waterColumns;

		private readonly ReadOnlyArray<byte> _waterColumnCounts;

		private readonly ReadOnlyList<WaterChange> _waterChanges;

		private readonly int _verticalStride;

		private readonly float _overflowPressureFactor;

		private readonly float _maxWaterContamination;

		public UpdateWaterChangesTask(MapIndexService mapIndexService, MutableWaterColumnRetriever mutableWaterColumnRetriever, WaterColumn[] waterColumns, ReadOnlyArray<byte> waterColumnCounts, ReadOnlyList<WaterChange> waterChanges, int verticalStride, float overflowPressureFactor, float maxWaterContamination)
		{
			_mapIndexService = mapIndexService;
			_mutableWaterColumnRetriever = mutableWaterColumnRetriever;
			_waterColumns = waterColumns;
			_waterColumnCounts = waterColumnCounts;
			_waterChanges = waterChanges;
			_verticalStride = verticalStride;
			_overflowPressureFactor = overflowPressureFactor;
			_maxWaterContamination = maxWaterContamination;
		}

		public void Run()
		{
			for (int i = 0; i < _waterChanges.Count; i++)
			{
				WaterChange waterChange = _waterChanges[i];
				Vector3Int coordinates = waterChange.Coordinates;
				int index = _mapIndexService.CellToIndex(coordinates.XY());
				ref WaterColumn column = ref _mutableWaterColumnRetriever.GetColumn(_waterColumnCounts.AsSpan, _waterColumns, _verticalStride, index, coordinates.z);
				float waterDepth = column.WaterDepth;
				float num = waterDepth + waterChange.DepthChange;
				if (waterChange.DepthChange > 0f)
				{
					int num2 = column.Ceiling - column.Floor;
					column.WaterDepth = ((num > (float)num2) ? ((float)num2) : num);
				}
				else
				{
					column.WaterDepth = ((num < 0f) ? 0f : num);
				}
				UpdateContaminationFromWaterChange(ref column, waterDepth, waterChange.ContaminationChange);
			}
		}

		private void UpdateContaminationFromWaterChange(ref WaterColumn waterColumn, float initialWaterDepth, float contaminationChange)
		{
			float num = waterColumn.WaterDepth + waterColumn.Overflow * _overflowPressureFactor;
			if (num != 0f)
			{
				float num2 = contaminationChange * (num - initialWaterDepth);
				float num3 = (waterColumn.Contamination * initialWaterDepth + num2) / num;
				if (num3 < 0f)
				{
					waterColumn.Contamination = 0f;
				}
				else
				{
					waterColumn.Contamination = ((num3 > _maxWaterContamination) ? _maxWaterContamination : num3);
				}
			}
			else
			{
				waterColumn.Contamination = 0f;
			}
		}
	}
}
