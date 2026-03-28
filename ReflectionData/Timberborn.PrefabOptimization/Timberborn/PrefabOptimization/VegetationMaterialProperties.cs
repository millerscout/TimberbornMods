using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering;

namespace Timberborn.PrefabOptimization
{
	internal record VegetationMaterialProperties : IMaterialProperties
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(VegetationMaterialProperties);
			}
		}

		public Color32 Color { get; private init; }

		private static readonly string UseEmissionKeyword = "_USE_EMISSION";

		private static readonly int ColorId = Shader.PropertyToID("_Color");

		private static readonly int MainTexId = Shader.PropertyToID("_MainTex");

		private static readonly int MetallicGlossMapId = Shader.PropertyToID("_MetallicGlossMap");

		private static readonly int BumpMapId = Shader.PropertyToID("_BumpMap");

		private static readonly int DetailMapId = Shader.PropertyToID("_DetailMap");

		private static readonly int EmissionColorId = Shader.PropertyToID("_EmissionColor");

		private static readonly int WindModifierId = Shader.PropertyToID("_WindModifier");

		private static readonly int SwayStrengthId = Shader.PropertyToID("_SwayStrength");

		private static readonly int SwaySpeedId = Shader.PropertyToID("_SwaySpeed");

		private static readonly int SwayExponentId = Shader.PropertyToID("_SwayExponent");

		private static readonly int FlutterStrengthId = Shader.PropertyToID("_FlutterStrength");

		private static readonly int FlutterSpeedId = Shader.PropertyToID("_FlutterSpeed");

		private static readonly int FlutterExponentId = Shader.PropertyToID("_FlutterExponent");

		private static readonly int FlutterThresholdId = Shader.PropertyToID("_FlutterThreshold");

		private static readonly int DetailUseColorId = Shader.PropertyToID("_DetailUseColor");

		private static readonly int DetailColorBoostId = Shader.PropertyToID("_DetailColorBoost");

		private static readonly int EnableDetailId = Shader.PropertyToID("_EnableDetail");

		private Texture2D _mainTex;

		private Texture2D _bumpMap;

		private Texture2D _metallicGlossMap;

		private Texture2D _detailMap;

		private Color32 _emissionColor;

		private bool _useEmission;

		private float _windModifier;

		private float _swayStrength;

		private float _swaySpeed;

		private float _swayExponent;

		private float _flutterStrength;

		private float _flutterSpeed;

		private float _flutterExponent;

		private float _flutterThreshold;

		private float _detailUseColor;

		private float _detailColorBoost;

		private float _enableDetail;

		private bool _enableInstancing;

		public static VegetationMaterialProperties FromMaterial(Material material)
		{
			return new VegetationMaterialProperties
			{
				Color = material.GetColor(ColorId),
				_mainTex = (Texture2D)material.GetTexture(MainTexId),
				_metallicGlossMap = (Texture2D)material.GetTexture(MetallicGlossMapId),
				_bumpMap = (Texture2D)material.GetTexture(BumpMapId),
				_detailMap = (Texture2D)material.GetTexture(DetailMapId),
				_emissionColor = material.GetColor(EmissionColorId),
				_useEmission = material.IsKeywordEnabled(UseEmissionKeyword),
				_windModifier = material.GetFloat(WindModifierId),
				_swayStrength = material.GetFloat(SwayStrengthId),
				_swaySpeed = material.GetFloat(SwaySpeedId),
				_swayExponent = material.GetFloat(SwayExponentId),
				_flutterStrength = material.GetFloat(FlutterStrengthId),
				_flutterSpeed = material.GetFloat(FlutterSpeedId),
				_flutterExponent = material.GetFloat(FlutterExponentId),
				_flutterThreshold = material.GetFloat(FlutterThresholdId),
				_detailUseColor = material.GetFloat(DetailUseColorId),
				_detailColorBoost = material.GetFloat(DetailColorBoostId),
				_enableDetail = material.GetFloat(EnableDetailId),
				_enableInstancing = material.enableInstancing
			};
		}

		public void ApplyToMaterial(Material material)
		{
			material.SetColor(ColorId, Color);
			material.SetTexture(MainTexId, _mainTex);
			material.SetTexture(BumpMapId, _bumpMap);
			material.SetTexture(MetallicGlossMapId, _metallicGlossMap);
			material.SetTexture(DetailMapId, _detailMap);
			material.SetColor(EmissionColorId, _emissionColor);
			LocalKeyword keyword = new LocalKeyword(material.shader, UseEmissionKeyword);
			material.SetKeyword(in keyword, _useEmission);
			material.SetFloat(WindModifierId, _windModifier);
			material.SetFloat(SwayStrengthId, _swayStrength);
			material.SetFloat(SwaySpeedId, _swaySpeed);
			material.SetFloat(SwayExponentId, _swayExponent);
			material.SetFloat(FlutterStrengthId, _flutterStrength);
			material.SetFloat(FlutterSpeedId, _flutterSpeed);
			material.SetFloat(FlutterExponentId, _flutterExponent);
			material.SetFloat(FlutterThresholdId, _flutterThreshold);
			material.SetFloat(DetailUseColorId, _detailUseColor);
			material.SetFloat(DetailColorBoostId, _detailColorBoost);
			material.SetFloat(EnableDetailId, _enableDetail);
			material.enableInstancing = _enableInstancing;
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
			stringBuilder.Append("VegetationMaterialProperties");
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
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((((((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Color32>.Default.GetHashCode(Color)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(_mainTex)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(_bumpMap)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(_metallicGlossMap)) * -1521134295 + EqualityComparer<Texture2D>.Default.GetHashCode(_detailMap)) * -1521134295 + EqualityComparer<Color32>.Default.GetHashCode(_emissionColor)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_useEmission)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_windModifier)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_swayStrength)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_swaySpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_swayExponent)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_flutterStrength)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_flutterSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_flutterExponent)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_flutterThreshold)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_detailUseColor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_detailColorBoost)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(_enableDetail)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_enableInstancing);
		}

		[CompilerGenerated]
		public virtual bool Equals(VegetationMaterialProperties? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Color32>.Default.Equals(Color, other!.Color) && EqualityComparer<Texture2D>.Default.Equals(_mainTex, other!._mainTex) && EqualityComparer<Texture2D>.Default.Equals(_bumpMap, other!._bumpMap) && EqualityComparer<Texture2D>.Default.Equals(_metallicGlossMap, other!._metallicGlossMap) && EqualityComparer<Texture2D>.Default.Equals(_detailMap, other!._detailMap) && EqualityComparer<Color32>.Default.Equals(_emissionColor, other!._emissionColor) && EqualityComparer<bool>.Default.Equals(_useEmission, other!._useEmission) && EqualityComparer<float>.Default.Equals(_windModifier, other!._windModifier) && EqualityComparer<float>.Default.Equals(_swayStrength, other!._swayStrength) && EqualityComparer<float>.Default.Equals(_swaySpeed, other!._swaySpeed) && EqualityComparer<float>.Default.Equals(_swayExponent, other!._swayExponent) && EqualityComparer<float>.Default.Equals(_flutterStrength, other!._flutterStrength) && EqualityComparer<float>.Default.Equals(_flutterSpeed, other!._flutterSpeed) && EqualityComparer<float>.Default.Equals(_flutterExponent, other!._flutterExponent) && EqualityComparer<float>.Default.Equals(_flutterThreshold, other!._flutterThreshold) && EqualityComparer<float>.Default.Equals(_detailUseColor, other!._detailUseColor) && EqualityComparer<float>.Default.Equals(_detailColorBoost, other!._detailColorBoost) && EqualityComparer<float>.Default.Equals(_enableDetail, other!._enableDetail))
				{
					return EqualityComparer<bool>.Default.Equals(_enableInstancing, other!._enableInstancing);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected VegetationMaterialProperties(VegetationMaterialProperties original)
		{
			Color = original.Color;
			_mainTex = original._mainTex;
			_bumpMap = original._bumpMap;
			_metallicGlossMap = original._metallicGlossMap;
			_detailMap = original._detailMap;
			_emissionColor = original._emissionColor;
			_useEmission = original._useEmission;
			_windModifier = original._windModifier;
			_swayStrength = original._swayStrength;
			_swaySpeed = original._swaySpeed;
			_swayExponent = original._swayExponent;
			_flutterStrength = original._flutterStrength;
			_flutterSpeed = original._flutterSpeed;
			_flutterExponent = original._flutterExponent;
			_flutterThreshold = original._flutterThreshold;
			_detailUseColor = original._detailUseColor;
			_detailColorBoost = original._detailColorBoost;
			_enableDetail = original._enableDetail;
			_enableInstancing = original._enableInstancing;
		}

		public VegetationMaterialProperties()
		{
		}
	}
}
