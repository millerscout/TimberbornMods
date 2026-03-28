using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Rendering
{
	internal record MarkerDrawerFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MarkerDrawerFactorySpec);
			}
		}

		[Serialize]
		public AssetRef<Mesh> TileMesh { get; init; }

		[Serialize]
		public AssetRef<Mesh> SmallBlockMesh { get; init; }

		[Serialize]
		public AssetRef<Mesh> LargeBlockMesh { get; init; }

		[Serialize]
		public AssetRef<Mesh> TerrainBlockMesh { get; init; }

		[Serialize]
		public AssetRef<Mesh> TopTerrainTileMesh { get; set; }

		[Serialize]
		public AssetRef<Material> TileMaterial { get; init; }

		[Serialize]
		public AssetRef<Material> TerrainTileMaterial { get; init; }

		[Serialize]
		public AssetRef<Material> TopTerrainTileMaterial { get; init; }

		[Serialize]
		public AssetRef<Material> PrioritizedTileMaterial { get; init; }

		[Serialize]
		public AssetRef<Mesh> EntranceMesh { get; init; }

		[Serialize]
		public AssetRef<Material> EntranceMarkerMaterial { get; init; }

		[Serialize]
		public AssetRef<Mesh> MechanicalInputMesh { get; init; }

		[Serialize]
		public AssetRef<Mesh> MechanicalOutputMesh { get; init; }

		[Serialize]
		public AssetRef<Material> MechanicalMarkerMaterial { get; init; }

		[Serialize]
		public AssetRef<Mesh> ArrowMesh { get; init; }

		[Serialize]
		public AssetRef<Material> ArrowMaterial { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MarkerDrawerFactorySpec");
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
			builder.Append(", SmallBlockMesh = ");
			builder.Append(SmallBlockMesh);
			builder.Append(", LargeBlockMesh = ");
			builder.Append(LargeBlockMesh);
			builder.Append(", TerrainBlockMesh = ");
			builder.Append(TerrainBlockMesh);
			builder.Append(", TopTerrainTileMesh = ");
			builder.Append(TopTerrainTileMesh);
			builder.Append(", TileMaterial = ");
			builder.Append(TileMaterial);
			builder.Append(", TerrainTileMaterial = ");
			builder.Append(TerrainTileMaterial);
			builder.Append(", TopTerrainTileMaterial = ");
			builder.Append(TopTerrainTileMaterial);
			builder.Append(", PrioritizedTileMaterial = ");
			builder.Append(PrioritizedTileMaterial);
			builder.Append(", EntranceMesh = ");
			builder.Append(EntranceMesh);
			builder.Append(", EntranceMarkerMaterial = ");
			builder.Append(EntranceMarkerMaterial);
			builder.Append(", MechanicalInputMesh = ");
			builder.Append(MechanicalInputMesh);
			builder.Append(", MechanicalOutputMesh = ");
			builder.Append(MechanicalOutputMesh);
			builder.Append(", MechanicalMarkerMaterial = ");
			builder.Append(MechanicalMarkerMaterial);
			builder.Append(", ArrowMesh = ");
			builder.Append(ArrowMesh);
			builder.Append(", ArrowMaterial = ");
			builder.Append(ArrowMaterial);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(TileMesh)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(SmallBlockMesh)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(LargeBlockMesh)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(TerrainBlockMesh)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(TopTerrainTileMesh)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(TileMaterial)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(TerrainTileMaterial)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(TopTerrainTileMaterial)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(PrioritizedTileMaterial)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(EntranceMesh)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(EntranceMarkerMaterial)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(MechanicalInputMesh)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(MechanicalOutputMesh)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(MechanicalMarkerMaterial)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(ArrowMesh)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(ArrowMaterial);
		}

		[CompilerGenerated]
		public virtual bool Equals(MarkerDrawerFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(TileMesh, other!.TileMesh) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(SmallBlockMesh, other!.SmallBlockMesh) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(LargeBlockMesh, other!.LargeBlockMesh) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(TerrainBlockMesh, other!.TerrainBlockMesh) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(TopTerrainTileMesh, other!.TopTerrainTileMesh) && EqualityComparer<AssetRef<Material>>.Default.Equals(TileMaterial, other!.TileMaterial) && EqualityComparer<AssetRef<Material>>.Default.Equals(TerrainTileMaterial, other!.TerrainTileMaterial) && EqualityComparer<AssetRef<Material>>.Default.Equals(TopTerrainTileMaterial, other!.TopTerrainTileMaterial) && EqualityComparer<AssetRef<Material>>.Default.Equals(PrioritizedTileMaterial, other!.PrioritizedTileMaterial) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(EntranceMesh, other!.EntranceMesh) && EqualityComparer<AssetRef<Material>>.Default.Equals(EntranceMarkerMaterial, other!.EntranceMarkerMaterial) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(MechanicalInputMesh, other!.MechanicalInputMesh) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(MechanicalOutputMesh, other!.MechanicalOutputMesh) && EqualityComparer<AssetRef<Material>>.Default.Equals(MechanicalMarkerMaterial, other!.MechanicalMarkerMaterial) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(ArrowMesh, other!.ArrowMesh))
				{
					return EqualityComparer<AssetRef<Material>>.Default.Equals(ArrowMaterial, other!.ArrowMaterial);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MarkerDrawerFactorySpec(MarkerDrawerFactorySpec original)
			: base(original)
		{
			TileMesh = original.TileMesh;
			SmallBlockMesh = original.SmallBlockMesh;
			LargeBlockMesh = original.LargeBlockMesh;
			TerrainBlockMesh = original.TerrainBlockMesh;
			TopTerrainTileMesh = original.TopTerrainTileMesh;
			TileMaterial = original.TileMaterial;
			TerrainTileMaterial = original.TerrainTileMaterial;
			TopTerrainTileMaterial = original.TopTerrainTileMaterial;
			PrioritizedTileMaterial = original.PrioritizedTileMaterial;
			EntranceMesh = original.EntranceMesh;
			EntranceMarkerMaterial = original.EntranceMarkerMaterial;
			MechanicalInputMesh = original.MechanicalInputMesh;
			MechanicalOutputMesh = original.MechanicalOutputMesh;
			MechanicalMarkerMaterial = original.MechanicalMarkerMaterial;
			ArrowMesh = original.ArrowMesh;
			ArrowMaterial = original.ArrowMaterial;
		}

		public MarkerDrawerFactorySpec()
		{
		}
	}
}
