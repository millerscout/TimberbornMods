using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.AutomationBuildings
{
	internal record WeatherStationSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WeatherStationSpec);
			}
		}

		[Serialize]
		public int MaxEarlyActivationHours { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WeatherStationSpec");
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
			builder.Append("MaxEarlyActivationHours = ");
			builder.Append(MaxEarlyActivationHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxEarlyActivationHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(WeatherStationSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(MaxEarlyActivationHours, other!.MaxEarlyActivationHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WeatherStationSpec(WeatherStationSpec original)
			: base(original)
		{
			MaxEarlyActivationHours = original.MaxEarlyActivationHours;
		}

		public WeatherStationSpec()
		{
		}
	}
}
