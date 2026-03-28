using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterSystemRendering
{
	internal record WaterMeshSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterMeshSpec);
			}
		}

		[Serialize]
		public AssetRef<GameObject> WaterTile { get; init; }

		[Serialize]
		public AssetRef<Material> OpaqueMaterial { get; init; }

		[Serialize]
		public AssetRef<Material> TransparentMaterial { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterMeshSpec");
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
			builder.Append("WaterTile = ");
			builder.Append(WaterTile);
			builder.Append(", OpaqueMaterial = ");
			builder.Append(OpaqueMaterial);
			builder.Append(", TransparentMaterial = ");
			builder.Append(TransparentMaterial);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(WaterTile)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(OpaqueMaterial)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(TransparentMaterial);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterMeshSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(WaterTile, other!.WaterTile) && EqualityComparer<AssetRef<Material>>.Default.Equals(OpaqueMaterial, other!.OpaqueMaterial))
				{
					return EqualityComparer<AssetRef<Material>>.Default.Equals(TransparentMaterial, other!.TransparentMaterial);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterMeshSpec(WaterMeshSpec original)
			: base(original)
		{
			WaterTile = original.WaterTile;
			OpaqueMaterial = original.OpaqueMaterial;
			TransparentMaterial = original.TransparentMaterial;
		}

		public WaterMeshSpec()
		{
		}
	}
}
