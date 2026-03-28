using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.TerrainSystemRendering
{
	internal record TerrainMeshManagerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TerrainMeshManagerSpec);
			}
		}

		[Serialize]
		public AssetRef<GameObject> TerrainTilePrefab { get; init; }

		[Serialize]
		public AssetRef<GameObject> LayerToolTopMeshPrefab { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TerrainMeshManagerSpec");
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
			builder.Append("TerrainTilePrefab = ");
			builder.Append(TerrainTilePrefab);
			builder.Append(", LayerToolTopMeshPrefab = ");
			builder.Append(LayerToolTopMeshPrefab);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(TerrainTilePrefab)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(LayerToolTopMeshPrefab);
		}

		[CompilerGenerated]
		public virtual bool Equals(TerrainMeshManagerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(TerrainTilePrefab, other!.TerrainTilePrefab))
				{
					return EqualityComparer<AssetRef<GameObject>>.Default.Equals(LayerToolTopMeshPrefab, other!.LayerToolTopMeshPrefab);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TerrainMeshManagerSpec(TerrainMeshManagerSpec original)
			: base(original)
		{
			TerrainTilePrefab = original.TerrainTilePrefab;
			LayerToolTopMeshPrefab = original.LayerToolTopMeshPrefab;
		}

		public TerrainMeshManagerSpec()
		{
		}
	}
}
