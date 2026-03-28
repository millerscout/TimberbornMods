using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SkySystem
{
	internal record DayStageCycleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DayStageCycleSpec);
			}
		}

		[Serialize]
		public float SunriseSunsetLengthInHours { get; init; }

		[Serialize]
		public float TransitionLengthInHours { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DayStageCycleSpec");
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
			builder.Append("SunriseSunsetLengthInHours = ");
			builder.Append(SunriseSunsetLengthInHours.ToString());
			builder.Append(", TransitionLengthInHours = ");
			builder.Append(TransitionLengthInHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(SunriseSunsetLengthInHours)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(TransitionLengthInHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(DayStageCycleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(SunriseSunsetLengthInHours, other!.SunriseSunsetLengthInHours))
				{
					return EqualityComparer<float>.Default.Equals(TransitionLengthInHours, other!.TransitionLengthInHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DayStageCycleSpec(DayStageCycleSpec original)
			: base(original)
		{
			SunriseSunsetLengthInHours = original.SunriseSunsetLengthInHours;
			TransitionLengthInHours = original.TransitionLengthInHours;
		}

		public DayStageCycleSpec()
		{
		}
	}
}
