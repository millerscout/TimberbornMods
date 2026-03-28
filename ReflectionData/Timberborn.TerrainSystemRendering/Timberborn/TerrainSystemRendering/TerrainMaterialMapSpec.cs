using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.TerrainSystemRendering
{
	internal record TerrainMaterialMapSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TerrainMaterialMapSpec);
			}
		}

		[Serialize]
		public AssetRef<Texture2D> DesertTexture { get; init; }

		[Serialize]
		public AssetRef<Texture2D> DryFieldTexture { get; init; }

		[Serialize]
		public AssetRef<Texture2D> WetFieldTexture { get; init; }

		[Serialize]
		public AssetRef<Texture2D> BlendingNoise { get; init; }

		[Serialize]
		public float BlendingNoiseScale { get; init; }

		[Serialize]
		public float BlendingNoiseMultiplier { get; init; }

		[Serialize]
		public float BlendingSoftness { get; init; }

		[Serialize]
		public float BlendingMargin { get; init; }

		[Serialize]
		public float AltitudeCeiling { get; init; }

		[Serialize]
		public AssetRef<Texture> AltitudeMultiplier { get; init; }

		[Serialize]
		public AssetRef<Texture> DesertAltitudeMultiplier { get; init; }

		[Serialize]
		public float CutoutMargin { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TerrainMaterialMapSpec");
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
			builder.Append("DesertTexture = ");
			builder.Append(DesertTexture);
			builder.Append(", DryFieldTexture = ");
			builder.Append(DryFieldTexture);
			builder.Append(", WetFieldTexture = ");
			builder.Append(WetFieldTexture);
			builder.Append(", BlendingNoise = ");
			builder.Append(BlendingNoise);
			builder.Append(", BlendingNoiseScale = ");
			builder.Append(BlendingNoiseScale.ToString());
			builder.Append(", BlendingNoiseMultiplier = ");
			builder.Append(BlendingNoiseMultiplier.ToString());
			builder.Append(", BlendingSoftness = ");
			builder.Append(BlendingSoftness.ToString());
			builder.Append(", BlendingMargin = ");
			builder.Append(BlendingMargin.ToString());
			builder.Append(", AltitudeCeiling = ");
			builder.Append(AltitudeCeiling.ToString());
			builder.Append(", AltitudeMultiplier = ");
			builder.Append(AltitudeMultiplier);
			builder.Append(", DesertAltitudeMultiplier = ");
			builder.Append(DesertAltitudeMultiplier);
			builder.Append(", CutoutMargin = ");
			builder.Append(CutoutMargin.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(DesertTexture)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(DryFieldTexture)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(WetFieldTexture)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(BlendingNoise)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BlendingNoiseScale)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BlendingNoiseMultiplier)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BlendingSoftness)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BlendingMargin)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(AltitudeCeiling)) * -1521134295 + EqualityComparer<AssetRef<Texture>>.Default.GetHashCode(AltitudeMultiplier)) * -1521134295 + EqualityComparer<AssetRef<Texture>>.Default.GetHashCode(DesertAltitudeMultiplier)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(CutoutMargin);
		}

		[CompilerGenerated]
		public virtual bool Equals(TerrainMaterialMapSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(DesertTexture, other!.DesertTexture) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(DryFieldTexture, other!.DryFieldTexture) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(WetFieldTexture, other!.WetFieldTexture) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(BlendingNoise, other!.BlendingNoise) && EqualityComparer<float>.Default.Equals(BlendingNoiseScale, other!.BlendingNoiseScale) && EqualityComparer<float>.Default.Equals(BlendingNoiseMultiplier, other!.BlendingNoiseMultiplier) && EqualityComparer<float>.Default.Equals(BlendingSoftness, other!.BlendingSoftness) && EqualityComparer<float>.Default.Equals(BlendingMargin, other!.BlendingMargin) && EqualityComparer<float>.Default.Equals(AltitudeCeiling, other!.AltitudeCeiling) && EqualityComparer<AssetRef<Texture>>.Default.Equals(AltitudeMultiplier, other!.AltitudeMultiplier) && EqualityComparer<AssetRef<Texture>>.Default.Equals(DesertAltitudeMultiplier, other!.DesertAltitudeMultiplier))
				{
					return EqualityComparer<float>.Default.Equals(CutoutMargin, other!.CutoutMargin);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TerrainMaterialMapSpec(TerrainMaterialMapSpec original)
			: base(original)
		{
			DesertTexture = original.DesertTexture;
			DryFieldTexture = original.DryFieldTexture;
			WetFieldTexture = original.WetFieldTexture;
			BlendingNoise = original.BlendingNoise;
			BlendingNoiseScale = original.BlendingNoiseScale;
			BlendingNoiseMultiplier = original.BlendingNoiseMultiplier;
			BlendingSoftness = original.BlendingSoftness;
			BlendingMargin = original.BlendingMargin;
			AltitudeCeiling = original.AltitudeCeiling;
			AltitudeMultiplier = original.AltitudeMultiplier;
			DesertAltitudeMultiplier = original.DesertAltitudeMultiplier;
			CutoutMargin = original.CutoutMargin;
		}

		public TerrainMaterialMapSpec()
		{
		}
	}
}
