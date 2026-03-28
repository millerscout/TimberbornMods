using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.AutomationBuildings
{
	internal record ContaminationSensorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ContaminationSensorSpec);
			}
		}

		[Serialize]
		public Vector3Int SensorCoordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ContaminationSensorSpec");
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
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(SensorCoordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(ContaminationSensorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(SensorCoordinates, other!.SensorCoordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ContaminationSensorSpec(ContaminationSensorSpec original)
			: base(original)
		{
			SensorCoordinates = original.SensorCoordinates;
		}

		public ContaminationSensorSpec()
		{
		}
	}
}
