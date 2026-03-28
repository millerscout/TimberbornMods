using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record SetWorkingHoursStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SetWorkingHoursStepSpec);
			}
		}

		[Serialize]
		public int TargetWorkingHours { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SetWorkingHoursStepSpec");
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
			builder.Append("TargetWorkingHours = ");
			builder.Append(TargetWorkingHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(TargetWorkingHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(SetWorkingHoursStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(TargetWorkingHours, other!.TargetWorkingHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SetWorkingHoursStepSpec(SetWorkingHoursStepSpec original)
			: base(original)
		{
			TargetWorkingHours = original.TargetWorkingHours;
		}

		public SetWorkingHoursStepSpec()
		{
		}
	}
}
