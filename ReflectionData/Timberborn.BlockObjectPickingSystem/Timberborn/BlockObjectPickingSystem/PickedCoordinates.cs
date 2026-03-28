using UnityEngine;

namespace Timberborn.BlockObjectPickingSystem
{
	public readonly struct PickedCoordinates
	{
		public Vector3Int Coordinates { get; }

		public int ReferenceTerrainLevel { get; }

		public int VerticalOffset { get; }

		public bool FilterOverhangingCoordinates { get; }

		public PickedCoordinates(Vector3Int coordinates, int referenceTerrainLevel, int verticalOffset, bool filterOverhangingCoordinates)
		{
			Coordinates = coordinates;
			ReferenceTerrainLevel = referenceTerrainLevel;
			VerticalOffset = verticalOffset;
			FilterOverhangingCoordinates = filterOverhangingCoordinates;
		}
	}
}
