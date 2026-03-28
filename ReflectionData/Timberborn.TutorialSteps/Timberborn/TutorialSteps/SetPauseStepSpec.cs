using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record SetPauseStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SetPauseStepSpec);
			}
		}

		[Serialize]
		public bool Pause { get; init; }

		[Serialize]
		public bool OnlyOnce { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SetPauseStepSpec");
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
			builder.Append("Pause = ");
			builder.Append(Pause.ToString());
			builder.Append(", OnlyOnce = ");
			builder.Append(OnlyOnce.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Pause)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(OnlyOnce);
		}

		[CompilerGenerated]
		public virtual bool Equals(SetPauseStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(Pause, other!.Pause))
				{
					return EqualityComparer<bool>.Default.Equals(OnlyOnce, other!.OnlyOnce);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SetPauseStepSpec(SetPauseStepSpec original)
			: base(original)
		{
			Pause = original.Pause;
			OnlyOnce = original.OnlyOnce;
		}

		public SetPauseStepSpec()
		{
		}
	}
}
