using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BuildingsNavigation
{
	internal record BoundsNavRangeDrawerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BoundsNavRangeDrawerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<AssetRef<Mesh>> TileMeshes { get; init; }

		[Serialize]
		public AssetRef<Material> Material { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BoundsNavRangeDrawerSpec");
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
			builder.Append("TileMeshes = ");
			builder.Append(TileMeshes.ToString());
			builder.Append(", Material = ");
			builder.Append(Material);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<Mesh>>>.Default.GetHashCode(TileMeshes)) * -1521134295 + EqualityComparer<AssetRef<UnityEngine.Material>>.Default.GetHashCode(Material);
		}

		[CompilerGenerated]
		public virtual bool Equals(BoundsNavRangeDrawerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<AssetRef<Mesh>>>.Default.Equals(TileMeshes, other!.TileMeshes))
				{
					return EqualityComparer<AssetRef<UnityEngine.Material>>.Default.Equals(Material, other!.Material);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BoundsNavRangeDrawerSpec(BoundsNavRangeDrawerSpec original)
			: base(original)
		{
			TileMeshes = original.TileMeshes;
			Material = original.Material;
		}

		public BoundsNavRangeDrawerSpec()
		{
		}
	}
}
