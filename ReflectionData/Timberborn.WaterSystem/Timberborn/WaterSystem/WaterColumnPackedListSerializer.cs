using System.Globalization;
using System.Text;
using Timberborn.Common;
using Timberborn.MapIndexSystem;
using Timberborn.Persistence;

namespace Timberborn.WaterSystem
{
	internal class WaterColumnPackedListSerializer : PackedListSerializer<WaterColumn>
	{
		private static readonly char Separator = ':';

		private static readonly string EmptyColumnValue = "0";

		protected override void Serialize(WaterColumn value, StringBuilder stringBuilder)
		{
			byte floor = value.Floor;
			float waterDepth = value.WaterDepth;
			float contamination = value.Contamination;
			float overflow = value.Overflow;
			if (waterDepth == 0f && contamination == 0f && overflow == 0f)
			{
				stringBuilder.Append(EmptyColumnValue);
				return;
			}
			stringBuilder.Append(waterDepth.ToString(CultureInfo.InvariantCulture));
			stringBuilder.Append(Separator);
			stringBuilder.Append(CommonNumberSerializer.SerializeFloat(contamination));
			stringBuilder.Append(Separator);
			stringBuilder.Append(CommonNumberSerializer.SerializeFloat(overflow));
			stringBuilder.Append(Separator);
			stringBuilder.Append(CommonNumberSerializer.SerializeInt(floor));
		}

		[BackwardCompatible(2024, 1, 3, Compatibility.Map)]
		protected override WaterColumn Deserialize(string value)
		{
			WaterColumn result;
			if (value == EmptyColumnValue)
			{
				result = default(WaterColumn);
				return result;
			}
			string[] array = value.Split(Separator);
			result = default(WaterColumn);
			result.WaterDepth = float.Parse(array[0]);
			result.Contamination = float.Parse(array[1]);
			result.Overflow = float.Parse(array[2]);
			result.Floor = (byte)((array.Length == 4) ? byte.Parse(array[3]) : 0);
			return result;
		}
	}
}
