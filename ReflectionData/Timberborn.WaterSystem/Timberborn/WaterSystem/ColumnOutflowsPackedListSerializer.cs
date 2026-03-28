using System.Collections.Generic;
using System.Text;
using Timberborn.MapIndexSystem;
using Timberborn.Persistence;

namespace Timberborn.WaterSystem
{
	internal class ColumnOutflowsPackedListSerializer : PackedListSerializer<ColumnOutflows>
	{
		private static readonly char Separator = ':';

		private static readonly char TargetedFlowSeparator = '|';

		private static readonly string EmptyOutFlowsValue = "0";

		protected override void Serialize(ColumnOutflows value, StringBuilder stringBuilder)
		{
			if (value.BottomFlow.Index3D == -1 && value.LeftFlow.Index3D == -1 && value.TopFlow.Index3D == -1 && value.RightFlow.Index3D == -1)
			{
				stringBuilder.Append(EmptyOutFlowsValue);
				return;
			}
			SerializeTargetedFlow(value.BottomFlow, stringBuilder);
			stringBuilder.Append(Separator);
			SerializeTargetedFlow(value.LeftFlow, stringBuilder);
			stringBuilder.Append(Separator);
			SerializeTargetedFlow(value.TopFlow, stringBuilder);
			stringBuilder.Append(Separator);
			SerializeTargetedFlow(value.RightFlow, stringBuilder);
			if (value.Outflows == null)
			{
				return;
			}
			foreach (TargetedFlow outflow in value.Outflows)
			{
				stringBuilder.Append(Separator);
				SerializeTargetedFlow(outflow, stringBuilder);
			}
		}

		protected override ColumnOutflows Deserialize(string value)
		{
			ColumnOutflows result;
			if (value == EmptyOutFlowsValue)
			{
				result = default(ColumnOutflows);
				TargetedFlow targetedFlow = new TargetedFlow
				{
					Index3D = -1
				};
				result.BottomFlow = targetedFlow;
				targetedFlow = new TargetedFlow
				{
					Index3D = -1
				};
				result.LeftFlow = targetedFlow;
				targetedFlow = new TargetedFlow
				{
					Index3D = -1
				};
				result.TopFlow = targetedFlow;
				targetedFlow = new TargetedFlow
				{
					Index3D = -1
				};
				result.RightFlow = targetedFlow;
				return result;
			}
			string[] array = value.Split(Separator);
			result = default(ColumnOutflows);
			result.BottomFlow = DeserializeTargetedFlow(array[0]);
			result.LeftFlow = DeserializeTargetedFlow(array[1]);
			result.TopFlow = DeserializeTargetedFlow(array[2]);
			result.RightFlow = DeserializeTargetedFlow(array[3]);
			result.Outflows = DeserializeOutflows(array);
			return result;
		}

		private static void SerializeTargetedFlow(TargetedFlow value, StringBuilder stringBuilder)
		{
			int index3D = value.Index3D;
			if (index3D == -1)
			{
				stringBuilder.Append(EmptyOutFlowsValue);
				return;
			}
			stringBuilder.Append(index3D.ToString());
			stringBuilder.Append(TargetedFlowSeparator);
			stringBuilder.Append(CommonNumberSerializer.SerializeFloat(value.Flow));
		}

		private static List<TargetedFlow> DeserializeOutflows(IReadOnlyList<string> values)
		{
			if (values.Count > 4)
			{
				List<TargetedFlow> list = new List<TargetedFlow>();
				for (int i = 4; i < values.Count; i++)
				{
					list.Add(DeserializeTargetedFlow(values[i]));
				}
				return list;
			}
			return null;
		}

		private static TargetedFlow DeserializeTargetedFlow(string value)
		{
			TargetedFlow result;
			if (value == EmptyOutFlowsValue)
			{
				result = default(TargetedFlow);
				result.Index3D = -1;
				return result;
			}
			string[] array = value.Split(TargetedFlowSeparator);
			result = default(TargetedFlow);
			result.Index3D = int.Parse(array[0]);
			result.Flow = float.Parse(array[1]);
			return result;
		}
	}
}
