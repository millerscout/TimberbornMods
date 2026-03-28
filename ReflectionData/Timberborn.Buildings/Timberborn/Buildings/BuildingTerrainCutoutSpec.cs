using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Buildings
{
	internal record BuildingTerrainCutoutSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildingTerrainCutoutSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector3Int> CutoutTiles { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildingTerrainCutoutSpec");
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
		public virtual bool Equals(BuildingTerrainCutoutSpec? other)
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
		protected BuildingTerrainCutoutSpec(BuildingTerrainCutoutSpec original)
			: base(original)
		{
			CutoutTiles = original.CutoutTiles;
		}

		public BuildingTerrainCutoutSpec()
		{
		}
	}
}
