using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterBuildings
{
	internal record FillValveSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FillValveSpec);
			}
		}

		[Serialize]
		public bool DefaultTargetHeightEnabled { get; init; }

		[Serialize]
		public float DefaultTargetHeightOffset { get; init; }

		[Serialize]
		public bool DefaultAutomationTargetHeightEnabled { get; init; }

		[Serialize]
		public float DefaultAutomationTargetHeightOffset { get; init; }

		[Serialize]
		public float OverflowLimit { get; init; }

		[Serialize]
		public Vector3Int OutputCoordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FillValveSpec");
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
			builder.Append("DefaultTargetHeightEnabled = ");
			builder.Append(DefaultTargetHeightEnabled.ToString());
			builder.Append(", DefaultTargetHeightOffset = ");
			builder.Append(DefaultTargetHeightOffset.ToString());
			builder.Append(", DefaultAutomationTargetHeightEnabled = ");
			builder.Append(DefaultAutomationTargetHeightEnabled.ToString());
			builder.Append(", DefaultAutomationTargetHeightOffset = ");
			builder.Append(DefaultAutomationTargetHeightOffset.ToString());
			builder.Append(", OverflowLimit = ");
			builder.Append(OverflowLimit.ToString());
			builder.Append(", OutputCoordinates = ");
			builder.Append(OutputCoordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DefaultTargetHeightEnabled)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DefaultTargetHeightOffset)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DefaultAutomationTargetHeightEnabled)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DefaultAutomationTargetHeightOffset)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(OverflowLimit)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(OutputCoordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(FillValveSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(DefaultTargetHeightEnabled, other!.DefaultTargetHeightEnabled) && EqualityComparer<float>.Default.Equals(DefaultTargetHeightOffset, other!.DefaultTargetHeightOffset) && EqualityComparer<bool>.Default.Equals(DefaultAutomationTargetHeightEnabled, other!.DefaultAutomationTargetHeightEnabled) && EqualityComparer<float>.Default.Equals(DefaultAutomationTargetHeightOffset, other!.DefaultAutomationTargetHeightOffset) && EqualityComparer<float>.Default.Equals(OverflowLimit, other!.OverflowLimit))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(OutputCoordinates, other!.OutputCoordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FillValveSpec(FillValveSpec original)
			: base(original)
		{
			DefaultTargetHeightEnabled = original.DefaultTargetHeightEnabled;
			DefaultTargetHeightOffset = original.DefaultTargetHeightOffset;
			DefaultAutomationTargetHeightEnabled = original.DefaultAutomationTargetHeightEnabled;
			DefaultAutomationTargetHeightOffset = original.DefaultAutomationTargetHeightOffset;
			OverflowLimit = original.OverflowLimit;
			OutputCoordinates = original.OutputCoordinates;
		}

		public FillValveSpec()
		{
		}
	}
}
