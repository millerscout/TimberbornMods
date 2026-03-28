using Timberborn.BlockSystem;
using UnityEngine;

namespace Timberborn.BlockObjectPickingSystem
{
	public readonly struct BlockObjectHit
	{
		public BlockObject BlockObject { get; }

		public Block HitBlock { get; }

		public Vector3Int HitProjectedOnGround { get; }

		public BlockObjectHit(BlockObject blockObject, Block hitBlock, Vector3Int hitProjectedOnGround)
		{
			BlockObject = blockObject;
			HitBlock = hitBlock;
			HitProjectedOnGround = hitProjectedOnGround;
		}
	}
}
