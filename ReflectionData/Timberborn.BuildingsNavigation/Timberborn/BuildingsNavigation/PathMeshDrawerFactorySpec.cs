using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BuildingsNavigation
{
	internal record PathMeshDrawerFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PathMeshDrawerFactorySpec);
			}
		}

		[Serialize]
		public ImmutableArray<AssetRef<Mesh>> RegularModelVariants { get; init; }

		[Serialize]
		public ImmutableArray<AssetRef<Mesh>> StairsModelVariants { get; init; }

		[Serialize]
		public AssetRef<Material> Material { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PathMeshDrawerFactorySpec");
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
			builder.Append("RegularModelVariants = ");
			builder.Append(RegularModelVariants.ToString());
			builder.Append(", StairsModelVariants = ");
			builder.Append(StairsModelVariants.ToString());
			builder.Append(", Material = ");
			builder.Append(Material);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<Mesh>>>.Default.GetHashCode(RegularModelVariants)) * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<Mesh>>>.Default.GetHashCode(StairsModelVariants)) * -1521134295 + EqualityComparer<AssetRef<UnityEngine.Material>>.Default.GetHashCode(Material);
		}

		[CompilerGenerated]
		public virtual bool Equals(PathMeshDrawerFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<AssetRef<Mesh>>>.Default.Equals(RegularModelVariants, other!.RegularModelVariants) && EqualityComparer<ImmutableArray<AssetRef<Mesh>>>.Default.Equals(StairsModelVariants, other!.StairsModelVariants))
				{
					return EqualityComparer<AssetRef<UnityEngine.Material>>.Default.Equals(Material, other!.Material);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PathMeshDrawerFactorySpec(PathMeshDrawerFactorySpec original)
			: base(original)
		{
			RegularModelVariants = original.RegularModelVariants;
			StairsModelVariants = original.StairsModelVariants;
			Material = original.Material;
		}

		public PathMeshDrawerFactorySpec()
		{
		}
	}
}
