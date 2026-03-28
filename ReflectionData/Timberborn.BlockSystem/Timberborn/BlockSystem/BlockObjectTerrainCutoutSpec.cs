using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockSystem
{
	internal record BlockObjectTerrainCutoutSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectTerrainCutoutSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector3Int> CutoutTiles { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectTerrainCutoutSpec");
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
			builder.Append("CutoutTiles = ");
			builder.Append(CutoutTiles.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<Vector3Int>>.Default.GetHashCode(CutoutTiles);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectTerrainCutoutSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<Vector3Int>>.Default.Equals(CutoutTiles, other!.CutoutTiles);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectTerrainCutoutSpec(BlockObjectTerrainCutoutSpec original)
			: base(original)
		{
			CutoutTiles = original.CutoutTiles;
		}

		public BlockObjectTerrainCutoutSpec()
		{
		}
	}
}
