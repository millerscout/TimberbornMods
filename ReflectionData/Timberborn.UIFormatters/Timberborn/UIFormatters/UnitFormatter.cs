using Timberborn.Localization;

namespace Timberborn.UIFormatters
{
	public static class UnitFormatter
	{
		private static readonly string TickUnitLocKey = "Unit.Tick.NumberAndUnit";

		private static readonly string HourUnitLocKey = "Unit.Hour.NumberAndUnit";

		private static readonly string DayUnitLocKey = "Unit.Day.NumberAndUnit";

		private static readonly string FlowUnitLocKey = "Unit.CubicMeterPerSecond.NumberAndUnit";

		private static readonly string DistanceUnitLocKey = "Unit.Meter.NumberAndUnit";

		private static readonly string AngleUnitLocKey = "Unit.Degree.NumberAndUnit";

		private static readonly string PowerUnitLocKey = "Unit.HorsePower.NumberAndUnit";

		private static readonly string PowerCapacityUnitLocKey = "Unit.HorsePowerHour.NumberAndUnit";

		private static readonly string PowerCapacityPerMeterUnitLocKey = "Unit.HorsePowerHourPerMeter.NumberAndUnit";

		public static string FormatTicks(int value, ILoc loc)
		{
			return loc.T(TickUnitLocKey, value);
		}

		public static string FormatHours(int value, ILoc loc)
		{
			return loc.T(HourUnitLocKey, $"{value}");
		}

		public static string FormatHours(string value, ILoc loc)
		{
			return loc.T(HourUnitLocKey, value);
		}

		public static string FormatDays(float value, ILoc loc)
		{
			return loc.T(DayUnitLocKey, $"{value:F1}");
		}

		public static string FormatDays(string value, ILoc loc)
		{
			return loc.T(DayUnitLocKey, value);
		}

		public static string FormatFlow(float value, ILoc loc)
		{
			return loc.T(FlowUnitLocKey, $"{value:F2}");
		}

		public static string FormatDistance(float value, ILoc loc)
		{
			return loc.T(DistanceUnitLocKey, $"{value:F2}");
		}

		public static string FormatDistance(int value, ILoc loc)
		{
			return loc.T(DistanceUnitLocKey, $"{value}");
		}

		public static string FormatAngle(int value, ILoc loc)
		{
			return loc.T(AngleUnitLocKey, value);
		}

		public static string FormatPower(int value, ILoc loc)
		{
			return loc.T(PowerUnitLocKey, value);
		}

		public static string FormatPowerCapacity(int value, ILoc loc)
		{
			return loc.T(PowerCapacityUnitLocKey, value);
		}

		public static string FormatPowerCapacityPerMeter(int value, ILoc loc)
		{
			return loc.T(PowerCapacityPerMeterUnitLocKey, value);
		}
	}
}
