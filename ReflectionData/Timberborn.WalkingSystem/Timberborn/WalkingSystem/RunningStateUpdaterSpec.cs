using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WalkingSystem
{
	internal record RunningStateUpdaterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RunningStateUpdaterSpec);
			}
		}

		[Serialize]
		public float ShortWalkingDistanceThreshold { get; init; }

		[Serialize]
		public float WalkingSpeedThreshold { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RunningStateUpdaterSpec");
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
			builder.Append("ShortWalkingDistanceThreshold = ");
			builder.Append(ShortWalkingDistanceThreshold.ToString());
			builder.Append(", WalkingSpeedThreshold = ");
			builder.Append(WalkingSpeedThreshold.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ShortWalkingDistanceThreshold)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(WalkingSpeedThreshold);
		}

		[CompilerGenerated]
		public virtual bool Equals(RunningStateUpdaterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(ShortWalkingDistanceThreshold, other!.ShortWalkingDistanceThreshold))
				{
					return EqualityComparer<float>.Default.Equals(WalkingSpeedThreshold, other!.WalkingSpeedThreshold);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RunningStateUpdaterSpec(RunningStateUpdaterSpec original)
			: base(original)
		{
			ShortWalkingDistanceThreshold = original.ShortWalkingDistanceThreshold;
			WalkingSpeedThreshold = original.WalkingSpeedThreshold;
		}

		public RunningStateUpdaterSpec()
		{
		}
	}
}
