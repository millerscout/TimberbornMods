using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Wonders
{
	internal record WonderDeactivationTimerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WonderDeactivationTimerSpec);
			}
		}

		[Serialize]
		public float TimerDelayInHours { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WonderDeactivationTimerSpec");
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
			builder.Append("TimerDelayInHours = ");
			builder.Append(TimerDelayInHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(TimerDelayInHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(WonderDeactivationTimerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(TimerDelayInHours, other!.TimerDelayInHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WonderDeactivationTimerSpec(WonderDeactivationTimerSpec original)
			: base(original)
		{
			TimerDelayInHours = original.TimerDelayInHours;
		}

		public WonderDeactivationTimerSpec()
		{
		}
	}
}
