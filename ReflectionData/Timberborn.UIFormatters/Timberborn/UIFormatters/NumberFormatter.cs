using System;
using System.Globalization;

namespace Timberborn.UIFormatters
{
	public static class NumberFormatter
	{
		private static readonly string Thousand = "k";

		private static readonly string Million = "M";

		private static readonly NumberFormatInfo NumberFormatInfo = new NumberFormatInfo
		{
			NumberGroupSeparator = " "
		};

		public static string Format(int number)
		{
			if (number < 1000000)
			{
				if (number >= 1000)
				{
					if (number < 10000)
					{
						return ToString(Math.Floor((float)number / 100f) / 10.0, Thousand, 1);
					}
					return ToString(Math.Floor((float)number / 1000f), Thousand, 0);
				}
				return $"{number:F0}";
			}
			if (number < 10000000)
			{
				return ToString(Math.Floor((float)number / 100000f) / 10.0, Million, 1);
			}
			return ToString(Math.Floor((float)number / 1000000f), Million, 0);
		}

		public static string FormatFullNumber(int number)
		{
			return number.ToString("N0", NumberFormatInfo);
		}

		public static string CeilToTenthsPlace(double value)
		{
			double num = Math.Ceiling(10.0 * value) / 10.0;
			return $"{num:0.0}";
		}

		public static string FormatAsPercentCeiled(double value)
		{
			return FormatAsPercentInternal(Math.Ceiling(value * 100.0));
		}

		public static string FormatAsPercentFloored(double value)
		{
			return FormatAsPercentInternal(Math.Floor(value * 100.0));
		}

		public static string FormatAsPercentRounded(double value)
		{
			return FormatAsPercentInternal(Math.Round(value * 100.0));
		}

		private static string FormatAsPercentInternal(double percentValue)
		{
			return $"{percentValue:F0}%";
		}

		private static string ToString(double number, string appendix, int decimalPlaces)
		{
			return number.ToString($"F{decimalPlaces}", CultureInfo.InvariantCulture) + appendix;
		}
	}
}
