using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.SkySystem
{
	internal record DayStageColorsSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DayStageColorsSpec);
			}
		}

		[Serialize]
		public Color SunColor { get; init; }

		[Serialize]
		public float SunIntensity { get; init; }

		[Serialize]
		public float SunXAngle { get; init; }

		[Serialize]
		public float ShadowStrength { get; init; }

		[Serialize]
		public Color AmbientSkyColor { get; init; }

		[Serialize]
		public Color AmbientEquatorColor { get; init; }

		[Serialize]
		public Color AmbientGroundColor { get; init; }

		[Serialize]
		public float ReflectionsIntensity { get; init; }

		[Serialize]
		public FogSettingsSpec TemperateWeatherFog { get; init; }

		[Serialize]
		public ImmutableArray<HazardousWeatherFogSettingsSpec> HazardousWeatherFogs { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DayStageColorsSpec");
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
			builder.Append("SunColor = ");
			builder.Append(SunColor.ToString());
			builder.Append(", SunIntensity = ");
			builder.Append(SunIntensity.ToString());
			builder.Append(", SunXAngle = ");
			builder.Append(SunXAngle.ToString());
			builder.Append(", ShadowStrength = ");
			builder.Append(ShadowStrength.ToString());
			builder.Append(", AmbientSkyColor = ");
			builder.Append(AmbientSkyColor.ToString());
			builder.Append(", AmbientEquatorColor = ");
			builder.Append(AmbientEquatorColor.ToString());
			builder.Append(", AmbientGroundColor = ");
			builder.Append(AmbientGroundColor.ToString());
			builder.Append(", ReflectionsIntensity = ");
			builder.Append(ReflectionsIntensity.ToString());
			builder.Append(", TemperateWeatherFog = ");
			builder.Append(TemperateWeatherFog);
			builder.Append(", HazardousWeatherFogs = ");
			builder.Append(HazardousWeatherFogs.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(SunColor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(SunIntensity)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(SunXAngle)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ShadowStrength)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(AmbientSkyColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(AmbientEquatorColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(AmbientGroundColor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ReflectionsIntensity)) * -1521134295 + EqualityComparer<FogSettingsSpec>.Default.GetHashCode(TemperateWeatherFog)) * -1521134295 + EqualityComparer<ImmutableArray<HazardousWeatherFogSettingsSpec>>.Default.GetHashCode(HazardousWeatherFogs);
		}

		[CompilerGenerated]
		public virtual bool Equals(DayStageColorsSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Color>.Default.Equals(SunColor, other!.SunColor) && EqualityComparer<float>.Default.Equals(SunIntensity, other!.SunIntensity) && EqualityComparer<float>.Default.Equals(SunXAngle, other!.SunXAngle) && EqualityComparer<float>.Default.Equals(ShadowStrength, other!.ShadowStrength) && EqualityComparer<Color>.Default.Equals(AmbientSkyColor, other!.AmbientSkyColor) && EqualityComparer<Color>.Default.Equals(AmbientEquatorColor, other!.AmbientEquatorColor) && EqualityComparer<Color>.Default.Equals(AmbientGroundColor, other!.AmbientGroundColor) && EqualityComparer<float>.Default.Equals(ReflectionsIntensity, other!.ReflectionsIntensity) && EqualityComparer<FogSettingsSpec>.Default.Equals(TemperateWeatherFog, other!.TemperateWeatherFog))
				{
					return EqualityComparer<ImmutableArray<HazardousWeatherFogSettingsSpec>>.Default.Equals(HazardousWeatherFogs, other!.HazardousWeatherFogs);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DayStageColorsSpec(DayStageColorsSpec original)
		{
			SunColor = original.SunColor;
			SunIntensity = original.SunIntensity;
			SunXAngle = original.SunXAngle;
			ShadowStrength = original.ShadowStrength;
			AmbientSkyColor = original.AmbientSkyColor;
			AmbientEquatorColor = original.AmbientEquatorColor;
			AmbientGroundColor = original.AmbientGroundColor;
			ReflectionsIntensity = original.ReflectionsIntensity;
			TemperateWeatherFog = original.TemperateWeatherFog;
			HazardousWeatherFogs = original.HazardousWeatherFogs;
		}

		public DayStageColorsSpec()
		{
		}
	}
}
