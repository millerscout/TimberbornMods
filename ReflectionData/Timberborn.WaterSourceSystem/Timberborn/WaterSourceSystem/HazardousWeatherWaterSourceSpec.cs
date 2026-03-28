using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterSourceSystem
{
	public record HazardousWeatherWaterSourceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(HazardousWeatherWaterSourceSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> ActiveInHazardousWeather { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("HazardousWeatherWaterSourceSpec");
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
			builder.Append("ActiveInHazardousWeather = ");
			builder.Append(ActiveInHazardousWeather.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(ActiveInHazardousWeather);
		}

		[CompilerGenerated]
		public virtual bool Equals(HazardousWeatherWaterSourceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(ActiveInHazardousWeather, other!.ActiveInHazardousWeather);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected HazardousWeatherWaterSourceSpec(HazardousWeatherWaterSourceSpec original)
			: base(original)
		{
			ActiveInHazardousWeather = original.ActiveInHazardousWeather;
		}

		public HazardousWeatherWaterSourceSpec()
		{
		}
	}
}
