using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TimeSystem
{
	internal record DayNightCycleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DayNightCycleSpec);
			}
		}

		[Serialize]
		public int HoursPassedOnNewGame { get; init; }

		[Serialize]
		public int ConfiguredDayLengthInTicks { get; init; }

		[Serialize]
		public int ConfiguredDaytimeLengthInHours { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DayNightCycleSpec");
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
			builder.Append("HoursPassedOnNewGame = ");
			builder.Append(HoursPassedOnNewGame.ToString());
			builder.Append(", ConfiguredDayLengthInTicks = ");
			builder.Append(ConfiguredDayLengthInTicks.ToString());
			builder.Append(", ConfiguredDaytimeLengthInHours = ");
			builder.Append(ConfiguredDaytimeLengthInHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(HoursPassedOnNewGame)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ConfiguredDayLengthInTicks)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ConfiguredDaytimeLengthInHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(DayNightCycleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(HoursPassedOnNewGame, other!.HoursPassedOnNewGame) && EqualityComparer<int>.Default.Equals(ConfiguredDayLengthInTicks, other!.ConfiguredDayLengthInTicks))
				{
					return EqualityComparer<int>.Default.Equals(ConfiguredDaytimeLengthInHours, other!.ConfiguredDaytimeLengthInHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DayNightCycleSpec(DayNightCycleSpec original)
			: base(original)
		{
			HoursPassedOnNewGame = original.HoursPassedOnNewGame;
			ConfiguredDayLengthInTicks = original.ConfiguredDayLengthInTicks;
			ConfiguredDaytimeLengthInHours = original.ConfiguredDaytimeLengthInHours;
		}

		public DayNightCycleSpec()
		{
		}
	}
}
