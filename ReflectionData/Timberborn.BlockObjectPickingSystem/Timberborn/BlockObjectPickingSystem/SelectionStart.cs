using UnityEngine;

namespace Timberborn.BlockObjectPickingSystem
{
	public readonly struct SelectionStart
	{
		private readonly BlockObjectHit? _originalBlockObjectHit;

		public Vector3Int Coordinates { get; }

		public int ReferenceTerrainLevel { get; }

		public int VerticalOffset { get; }

		private SelectionStart(Vector3Int coordinates, BlockObjectHit? originalBlockObjectHit, int verticalOffset)
		{
			Coordinates = coordinates;
			_originalBlockObjectHit = originalBlockObjectHit;
			ReferenceTerrainLevel = coordinates.z;
			VerticalOffset = verticalOffset;
		}

		public SelectionStart(Vector3Int coordinates)
			: this(coordinates, null, 0)
		{
		}

		public SelectionStart(BlockObjectHit blockObjectHit)
			: this(blockObjectHit.HitProjectedOnGround, blockObjectHit, 0)
		{
			if (blockObjectHit.BlockObject.PositionedBlocks.GetBlock(Coordinates).Underground)
			{
				ReferenceTerrainLevel = Coordinates.z + 1;
				VerticalOffset = -1;
			}
		}

		public BlockObjectHit? GetBlockObjectHit()
		{
			if (_originalBlockObjectHit.HasValue && (bool)_originalBlockObjectHit.Value.BlockObject && _originalBlockObjectHit.Value.BlockObject.PositionedBlocks.HasBlockAt(Coordinates))
			{
				return _originalBlockObjectHit;
			}
			return null;
		}
	}
}
