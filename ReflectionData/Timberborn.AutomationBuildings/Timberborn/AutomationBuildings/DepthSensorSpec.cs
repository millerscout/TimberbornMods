using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.AutomationBuildings
{
	internal record DepthSensorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DepthSensorSpec);
			}
		}

		[Serialize]
		public Vector3Int SensorCoordinates { get; init; }

		[Serialize]
		public float SensorHeightOffset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DepthSensorSpec");
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
			builder.Append("SensorCoordinates = ");
			builder.Append(SensorCoordinates.ToString());
			builder.Append(", SensorHeightOffset = ");
			builder.Append(SensorHeightOffset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(SensorCoordinates)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(SensorHeightOffset);
		}

		[CompilerGenerated]
		public virtual bool Equals(DepthSensorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3Int>.Default.Equals(SensorCoordinates, other!.SensorCoordinates))
				{
					return EqualityComparer<float>.Default.Equals(SensorHeightOffset, other!.SensorHeightOffset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DepthSensorSpec(DepthSensorSpec original)
			: base(original)
		{
			SensorCoordinates = original.SensorCoordinates;
			SensorHeightOffset = original.SensorHeightOffset;
		}

		public DepthSensorSpec()
		{
		}
	}
}
