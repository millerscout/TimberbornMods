using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.AreaSelectionSystem
{
	internal record RectangleBoundsDrawerFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RectangleBoundsDrawerFactorySpec);
			}
		}

		[Serialize]
		public AssetRef<Mesh> BlockSideMesh0010 { get; init; }

		[Serialize]
		public AssetRef<Mesh> BlockSideMesh0011 { get; init; }

		[Serialize]
		public AssetRef<Mesh> BlockSideMesh0111 { get; init; }

		[Serialize]
		public AssetRef<Mesh> BlockSideMesh1010 { get; init; }

		[Serialize]
		public AssetRef<Mesh> BlockSideMesh1111 { get; init; }

		[Serialize]
		public AssetRef<Material> BlockSideMaterial { get; init; }

		[Serialize]
		public AssetRef<Mesh> BlockBottomMesh { get; init; }

		[Serialize]
		public AssetRef<Material> BlockBottomMaterial { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RectangleBoundsDrawerFactorySpec");
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
			builder.Append("BlockSideMesh0010 = ");
			builder.Append(BlockSideMesh0010);
			builder.Append(", BlockSideMesh0011 = ");
			builder.Append(BlockSideMesh0011);
			builder.Append(", BlockSideMesh0111 = ");
			builder.Append(BlockSideMesh0111);
			builder.Append(", BlockSideMesh1010 = ");
			builder.Append(BlockSideMesh1010);
			builder.Append(", BlockSideMesh1111 = ");
			builder.Append(BlockSideMesh1111);
			builder.Append(", BlockSideMaterial = ");
			builder.Append(BlockSideMaterial);
			builder.Append(", BlockBottomMesh = ");
			builder.Append(BlockBottomMesh);
			builder.Append(", BlockBottomMaterial = ");
			builder.Append(BlockBottomMaterial);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(BlockSideMesh0010)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(BlockSideMesh0011)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(BlockSideMesh0111)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(BlockSideMesh1010)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(BlockSideMesh1111)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(BlockSideMaterial)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(BlockBottomMesh)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(BlockBottomMaterial);
		}

		[CompilerGenerated]
		public virtual bool Equals(RectangleBoundsDrawerFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(BlockSideMesh0010, other!.BlockSideMesh0010) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(BlockSideMesh0011, other!.BlockSideMesh0011) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(BlockSideMesh0111, other!.BlockSideMesh0111) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(BlockSideMesh1010, other!.BlockSideMesh1010) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(BlockSideMesh1111, other!.BlockSideMesh1111) && EqualityComparer<AssetRef<Material>>.Default.Equals(BlockSideMaterial, other!.BlockSideMaterial) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(BlockBottomMesh, other!.BlockBottomMesh))
				{
					return EqualityComparer<AssetRef<Material>>.Default.Equals(BlockBottomMaterial, other!.BlockBottomMaterial);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RectangleBoundsDrawerFactorySpec(RectangleBoundsDrawerFactorySpec original)
			: base(original)
		{
			BlockSideMesh0010 = original.BlockSideMesh0010;
			BlockSideMesh0011 = original.BlockSideMesh0011;
			BlockSideMesh0111 = original.BlockSideMesh0111;
			BlockSideMesh1010 = original.BlockSideMesh1010;
			BlockSideMesh1111 = original.BlockSideMesh1111;
			BlockSideMaterial = original.BlockSideMaterial;
			BlockBottomMesh = original.BlockBottomMesh;
			BlockBottomMaterial = original.BlockBottomMaterial;
		}

		public RectangleBoundsDrawerFactorySpec()
		{
		}
	}
}
