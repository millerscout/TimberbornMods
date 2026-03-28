using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace Timberborn.PrefabOptimization
{
	internal record EnvironmentMaterialProperties : IMaterialProperties
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EnvironmentMaterialProperties);
			}
		}

		public Color32 Color { get; private init; }

		public Texture2D MainTex { get; init; }

		public Texture2D BumpMap { get; init; }

		public Texture2D ColorMask { get; init; }

		public Texture2D AmbientOcclusion { get; init; }

		public Texture2D MetallicGlossMap { get; init; }

		public Texture2D LightingMap { get; init; }

		private bool CutoutWithAlpha { get; init; }

		private float Cutoff { get; init; }

		private Texture2D CutoutTex { get; init; }

		private Texture2D DetailAlbedoMap { get; init; }

		private Texture2D DetailAlbedoMap2 { get; init; }

		private Texture2D DetailAlbedoMap3 { get; init; }

		private Color32 DetailAlbedoColor2 { get; init; }

		private float DetailAlbedoGradient3 { get; init; }

		private Color32 EmissionColor { get; init; }

		private bool MainUVFromCoordinates { get; init; }

		private float MainUVFromCoordinatesScale { get; init; }

		private bool EnableInstancing { get; init; }

		private static readonly int ColorProperty = Shader.PropertyToID("_Color");

		private static readonly int MainTexProperty = Shader.PropertyToID("_MainTex");

		private static readonly int ColorMaskProperty = Shader.PropertyToID("_ColorMask");

		private static readonly int AmbientOcclusionProperty = Shader.PropertyToID("_AmbientOcclusion");

		private static readonly int MetallicGlossMapProperty = Shader.PropertyToID("_MetallicGlossMap");

		private static readonly int LightingMapProperty = Shader.PropertyToID("_LightingMap");

		private static readonly int CutoutWithAlphaProperty = Shader.PropertyToID("_CutoutWithAlpha");

		private static readonly int CutoutTexProperty = Shader.PropertyToID("_CutoutTex");

		private static readonly int CutoffProperty = Shader.PropertyToID("_Cutoff");

		private static readonly int BumpMapProperty = Shader.PropertyToID("_BumpMap");

		private static readonly int DetailAlbedoMapProperty = Shader.PropertyToID("_DetailAlbedoMap");

		private static readonly int DetailAlbedoMap2Property = Shader.PropertyToID("_DetailAlbedoMap2");

		private static readonly int DetailAlbedoMap3Property = Shader.PropertyToID("_DetailAlbedoMap3");

		private static readonly int DetailAlbedoColor2Property = Shader.PropertyToID("_DetailAlbedoUV2Color");

		private static readonly int DetailAlbedoGradient3Property = Shader.PropertyToID("_DetailAlbedoUV3Gradient");

		private static readonly int EmissionColorProperty = Shader.PropertyToID("_EmissionColor");

		private static readonly int MainUVFromCoordinatesProperty = Shader.PropertyToID("_MainUVFromCoordinates");

		private static readonly int MainUVFromCoordinatesScaleProperty = Shader.PropertyToID("_MainUVFromCoordinatesScale");

		public static EnvironmentMaterialProperties FromMaterial(Material material)
		{
			return new EnvironmentMaterialProperties
			{
				Color = material.GetColor(ColorProperty),
				MainTex = (Texture2D)material.GetTexture(MainTexProperty),
				ColorMask = (Texture2D)material.GetTexture(ColorMaskProperty),
				AmbientOcclusion = (Texture2D)material.GetTexture(AmbientOcclusionProperty),
				MetallicGlossMap = (Texture2D)material.GetTexture(MetallicGlossMapProperty),
				LightingMap = (Texture2D)material.GetTexture(LightingMapProperty),
				CutoutWithAlpha = (material.GetFloat(CutoutWithAlphaProperty) > 0.5f),
				CutoutTex = (Texture2D)material.GetTexture(CutoutTexProperty),
				Cutoff = material.GetFloat(CutoffProperty),
				BumpMap = (Texture2D)material.GetTexture(BumpMapProperty),
				DetailAlbedoMap = (Texture2D)material.GetTexture(DetailAlbedoMapProperty),
				DetailAlbedoMap2 = (Texture2D)material.GetTexture(DetailAlbedoMap2Property),
				DetailAlbedoMap3 = (Texture2D)material.GetTexture(DetailAlbedoMap3Property),
				DetailAlbedoColor2 = material.GetColor(DetailAlbedoColor2Property),
				DetailAlbedoGradient3 = material.GetFloat(DetailAlbedoGradient3Property),
				EmissionColor = material.GetColor(EmissionColorProperty),
				MainUVFromCoordinates = (material.GetFloat(MainUVFromCoordinatesProperty) > 0.5f),
				MainUVFromCoordinatesScale = material.GetFloat(MainUVFromCoordinatesScaleProperty),
				EnableInstancing = material.enableInstancing
			};
		}

		public void ApplyToMaterial(Material material)
		{
			material.SetColor(ColorProperty, Color);
			material.SetTexture(MainTexProperty, MainTex);
			material.SetTexture(BumpMapProperty, BumpMap);
			material.SetTexture(ColorMaskProperty, ColorMask);
			material.SetTexture(AmbientOcclusionProperty, AmbientOcclusion);
			material.SetTexture(MetallicGlossMapProperty, MetallicGlossMap);
			material.SetTexture(LightingMapProperty, LightingMap);
			material.SetFloat(CutoutWithAlphaProperty, CutoutWithAlpha ? 1 : 0);
			material.SetTexture(CutoutTexProperty, CutoutTex);
			material.SetFloat(CutoffProperty, Cutoff);
			material.SetTexture(DetailAlbedoMapProperty, DetailAlbedoMap);
			material.SetTexture(DetailAlbedoMap2Property, DetailAlbedoMap2);
			material.SetTexture(DetailAlbedoMap3Property, DetailAlbedoMap3);
			material.SetColor(DetailAlbedoColor2Property, DetailAlbedoColor2);
			material.SetFloat(DetailAlbedoGradient3Property, DetailAlbedoGradient3);
			material.SetColor(EmissionColorProperty, EmissionColor);
			material.SetFloat(MainUVFromCoordinatesProperty, MainUVFromCoordinates ? 1 : 0);
			material.SetFloat(MainUVFromCoordinatesScaleProperty, MainUVFromCoordinatesScale);
			material.enableInstancing = EnableInstancing;
		}

		public IMaterialProperties GetWithoutColor()
		{
			return this with
			{
				Color = UnityEngine.Color.white
			};
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EnvironmentMaterialProperties");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Color = ");
			builder.Append(Color.ToString());
			builder.Append(", MainTex = ");
			builder.Append((object)MainTex);
			builder.Append(", BumpMap = ");
			builder.Append((object)BumpMap);
			builder.Append(", ColorMask = ");
			builder.Append((object)ColorMask);
			builder.Append(", AmbientOcclusion = ");
			builder.Append((object)AmbientOcclusion);
			builder.Append(", MetallicGlossMap = ");
			builder.Append((object)MetallicGlossMap);
			builder.Append(", LightingMap = ");
			builder.Append((object)LightingMap);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((((((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Color32>.Default.GetHashCode(Color)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(MainTex)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(BumpMap)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(ColorMask)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(AmbientOcclusion)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(MetallicGlossMap)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(LightingMap)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(CutoutWithAlpha)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Cutoff)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(CutoutTex)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(DetailAlbedoMap)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(DetailAlbedoMap2)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(DetailAlbedoMap3)) * -1521134295 + EqualityComparer<Color32>.Default.GetHashCode(DetailAlbedoColor2)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DetailAlbedoGradient3)) * -1521134295 + EqualityComparer<Color32>.Default.GetHashCode(EmissionColor)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(MainUVFromCoordinates)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MainUVFromCoordinatesScale)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(EnableInstancing);
		}

		[CompilerGenerated]
		public virtual bool Equals(EnvironmentMaterialProperties? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Color32>.Default.Equals(Color, other!.Color) && EqualityComparer<Texture2D>.Default.Equals(MainTex, other!.MainTex) && EqualityComparer<Texture2D>.Default.Equals(BumpMap, other!.BumpMap) && EqualityComparer<Texture2D>.Default.Equals(ColorMask, other!.ColorMask) && EqualityComparer<Texture2D>.Default.Equals(AmbientOcclusion, other!.AmbientOcclusion) && EqualityComparer<Texture2D>.Default.Equals(MetallicGlossMap, other!.MetallicGlossMap) && EqualityComparer<Texture2D>.Default.Equals(LightingMap, other!.LightingMap) && EqualityComparer<bool>.Default.Equals(CutoutWithAlpha, other!.CutoutWithAlpha) && EqualityComparer<float>.Default.Equals(Cutoff, other!.Cutoff) && EqualityComparer<Texture2D>.Default.Equals(CutoutTex, other!.CutoutTex) && EqualityComparer<Texture2D>.Default.Equals(DetailAlbedoMap, other!.DetailAlbedoMap) && EqualityComparer<Texture2D>.Default.Equals(DetailAlbedoMap2, other!.DetailAlbedoMap2) && EqualityComparer<Texture2D>.Default.Equals(DetailAlbedoMap3, other!.DetailAlbedoMap3) && EqualityComparer<Color32>.Default.Equals(DetailAlbedoColor2, other!.DetailAlbedoColor2) && EqualityComparer<float>.Default.Equals(DetailAlbedoGradient3, other!.DetailAlbedoGradient3) && EqualityComparer<Color32>.Default.Equals(EmissionColor, other!.EmissionColor) && EqualityComparer<bool>.Default.Equals(MainUVFromCoordinates, other!.MainUVFromCoordinates) && EqualityComparer<float>.Default.Equals(MainUVFromCoordinatesScale, other!.MainUVFromCoordinatesScale))
				{
					return EqualityComparer<bool>.Default.Equals(EnableInstancing, other!.EnableInstancing);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected EnvironmentMaterialProperties(EnvironmentMaterialProperties original)
		{
			Color = original.Color;
			MainTex = original.MainTex;
			BumpMap = original.BumpMap;
			ColorMask = original.ColorMask;
			AmbientOcclusion = original.AmbientOcclusion;
			MetallicGlossMap = original.MetallicGlossMap;
			LightingMap = original.LightingMap;
			CutoutWithAlpha = original.CutoutWithAlpha;
			Cutoff = original.Cutoff;
			CutoutTex = original.CutoutTex;
			DetailAlbedoMap = original.DetailAlbedoMap;
			DetailAlbedoMap2 = original.DetailAlbedoMap2;
			DetailAlbedoMap3 = original.DetailAlbedoMap3;
			DetailAlbedoColor2 = original.DetailAlbedoColor2;
			DetailAlbedoGradient3 = original.DetailAlbedoGradient3;
			EmissionColor = original.EmissionColor;
			MainUVFromCoordinates = original.MainUVFromCoordinates;
			MainUVFromCoordinatesScale = original.MainUVFromCoordinatesScale;
			EnableInstancing = original.EnableInstancing;
		}

		public EnvironmentMaterialProperties()
		{
		}
	}
}
