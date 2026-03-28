using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Rendering
{
	internal record AreaTileDrawerFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AreaTileDrawerFactorySpec);
			}
		}

		[Serialize]
		public AssetRef<Mesh> TileMesh { get; init; }

		[Serialize]
		public AssetRef<Material> TileMaterial { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AreaTileDrawerFactorySpec");
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
			builder.Append("TileMesh = ");
			builder.Append(TileMesh);
			builder.Append(", TileMaterial = ");
			builder.Append(TileMaterial);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(TileMesh)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(TileMaterial);
		}

		[CompilerGenerated]
		public virtual bool Equals(AreaTileDrawerFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(TileMesh, other!.TileMesh))
				{
					return EqualityComparer<AssetRef<Material>>.Default.Equals(TileMaterial, other!.TileMaterial);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AreaTileDrawerFactorySpec(AreaTileDrawerFactorySpec original)
			: base(original)
		{
			TileMesh = original.TileMesh;
			TileMaterial = original.TileMaterial;
		}

		public AreaTileDrawerFactorySpec()
		{
		}
	}
}
