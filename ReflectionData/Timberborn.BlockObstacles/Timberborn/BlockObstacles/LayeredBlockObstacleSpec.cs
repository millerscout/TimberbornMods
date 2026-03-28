using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockObstacles
{
	internal record LayeredBlockObstacleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(LayeredBlockObstacleSpec);
			}
		}

		[Serialize]
		public Vector2Int LayerSize { get; init; }

		[Serialize]
		public Vector3 AnchorPosition { get; init; }

		[Serialize]
		public int BlockCreationOffset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LayeredBlockObstacleSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder)
		{
			if (base.PrintMembers(builder))
			{
				builder.Append(", ");
			}
			builder.Append("LayerSize = ");
			builder.Append(LayerSize.ToString());
			builder.Append(", AnchorPosition = ");
			builder.Append(AnchorPosition.ToString());
			builder.Append(", BlockCreationOffset = ");
			builder.Append(BlockCreationOffset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Vector2Int>.Default.GetHashCode(LayerSize)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(AnchorPosition)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BlockCreationOffset);
		}

		[CompilerGenerated]
		public virtual bool Equals(LayeredBlockObstacleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector2Int>.Default.Equals(LayerSize, other!.LayerSize) && EqualityComparer<Vector3>.Default.Equals(AnchorPosition, other!.AnchorPosition))
				{
					return EqualityComparer<int>.Default.Equals(BlockCreationOffset, other!.BlockCreationOffset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected LayeredBlockObstacleSpec(LayeredBlockObstacleSpec original)
			: base(original)
		{
			LayerSize = original.LayerSize;
			AnchorPosition = original.AnchorPosition;
			BlockCreationOffset = original.BlockCreationOffset;
		}

		public LayeredBlockObstacleSpec()
		{
		}
	}
}
