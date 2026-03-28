using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.SkySystem
{
	internal record SunSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SunSpec);
			}
		}

		[Serialize]
		public AssetRef<Light> SunPrefab { get; init; }

		[Serialize]
		public DayStageColorsSpec SunriseColors { get; init; }

		[Serialize]
		public DayStageColorsSpec DayColors { get; init; }

		[Serialize]
		public DayStageColorsSpec SunsetColors { get; init; }

		[Serialize]
		public DayStageColorsSpec NightColors { get; init; }

		[Serialize]
		public float RotateWithCameraOffset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SunSpec");
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
			builder.Append("SunPrefab = ");
			builder.Append(SunPrefab);
			builder.Append(", SunriseColors = ");
			builder.Append(SunriseColors);
			builder.Append(", DayColors = ");
			builder.Append(DayColors);
			builder.Append(", SunsetColors = ");
			builder.Append(SunsetColors);
			builder.Append(", NightColors = ");
			builder.Append(NightColors);
			builder.Append(", RotateWithCameraOffset = ");
			builder.Append(RotateWithCameraOffset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<Light>>.Default.GetHashCode(SunPrefab)) * -1521134295 + EqualityComparer<DayStageColorsSpec>.Default.GetHashCode(SunriseColors)) * -1521134295 + EqualityComparer<DayStageColorsSpec>.Default.GetHashCode(DayColors)) * -1521134295 + EqualityComparer<DayStageColorsSpec>.Default.GetHashCode(SunsetColors)) * -1521134295 + EqualityComparer<DayStageColorsSpec>.Default.GetHashCode(NightColors)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RotateWithCameraOffset);
		}

		[CompilerGenerated]
		public virtual bool Equals(SunSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<Light>>.Default.Equals(SunPrefab, other!.SunPrefab) && EqualityComparer<DayStageColorsSpec>.Default.Equals(SunriseColors, other!.SunriseColors) && EqualityComparer<DayStageColorsSpec>.Default.Equals(DayColors, other!.DayColors) && EqualityComparer<DayStageColorsSpec>.Default.Equals(SunsetColors, other!.SunsetColors) && EqualityComparer<DayStageColorsSpec>.Default.Equals(NightColors, other!.NightColors))
				{
					return EqualityComparer<float>.Default.Equals(RotateWithCameraOffset, other!.RotateWithCameraOffset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SunSpec(SunSpec original)
			: base(original)
		{
			SunPrefab = original.SunPrefab;
			SunriseColors = original.SunriseColors;
			DayColors = original.DayColors;
			SunsetColors = original.SunsetColors;
			NightColors = original.NightColors;
			RotateWithCameraOffset = original.RotateWithCameraOffset;
		}

		public SunSpec()
		{
		}
	}
}
