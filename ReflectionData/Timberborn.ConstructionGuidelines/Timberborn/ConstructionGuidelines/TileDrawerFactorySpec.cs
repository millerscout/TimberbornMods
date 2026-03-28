using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ConstructionGuidelines
{
	internal record TileDrawerFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TileDrawerFactorySpec);
			}
		}

		[Serialize]
		public string MeshResourcePath { get; init; }

		[Serialize]
		public string TilesOnSameLevelMaterialResourcePath { get; init; }

		[Serialize]
		public string TilesBelowMaterialResourcePath { get; init; }

		[Serialize]
		public string TilesAboveMaterialResourcePath { get; init; }

		[Serialize]
		public string FootprintTilesMaterialResourcePath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TileDrawerFactorySpec");
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
			builder.Append("MeshResourcePath = ");
			builder.Append((object)MeshResourcePath);
			builder.Append(", TilesOnSameLevelMaterialResourcePath = ");
			builder.Append((object)TilesOnSameLevelMaterialResourcePath);
			builder.Append(", TilesBelowMaterialResourcePath = ");
			builder.Append((object)TilesBelowMaterialResourcePath);
			builder.Append(", TilesAboveMaterialResourcePath = ");
			builder.Append((object)TilesAboveMaterialResourcePath);
			builder.Append(", FootprintTilesMaterialResourcePath = ");
			builder.Append((object)FootprintTilesMaterialResourcePath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MeshResourcePath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TilesOnSameLevelMaterialResourcePath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TilesBelowMaterialResourcePath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TilesAboveMaterialResourcePath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FootprintTilesMaterialResourcePath);
		}

		[CompilerGenerated]
		public virtual bool Equals(TileDrawerFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(MeshResourcePath, other!.MeshResourcePath) && EqualityComparer<string>.Default.Equals(TilesOnSameLevelMaterialResourcePath, other!.TilesOnSameLevelMaterialResourcePath) && EqualityComparer<string>.Default.Equals(TilesBelowMaterialResourcePath, other!.TilesBelowMaterialResourcePath) && EqualityComparer<string>.Default.Equals(TilesAboveMaterialResourcePath, other!.TilesAboveMaterialResourcePath))
				{
					return EqualityComparer<string>.Default.Equals(FootprintTilesMaterialResourcePath, other!.FootprintTilesMaterialResourcePath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TileDrawerFactorySpec(TileDrawerFactorySpec original)
			: base(original)
		{
			MeshResourcePath = original.MeshResourcePath;
			TilesOnSameLevelMaterialResourcePath = original.TilesOnSameLevelMaterialResourcePath;
			TilesBelowMaterialResourcePath = original.TilesBelowMaterialResourcePath;
			TilesAboveMaterialResourcePath = original.TilesAboveMaterialResourcePath;
			FootprintTilesMaterialResourcePath = original.FootprintTilesMaterialResourcePath;
		}

		public TileDrawerFactorySpec()
		{
		}
	}
}
