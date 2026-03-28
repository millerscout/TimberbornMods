using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record ChangePausedStateStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ChangePausedStateStepSpec);
			}
		}

		[Serialize]
		public bool ShouldBePaused { get; init; }

		[Serialize]
		public string TemplateName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ChangePausedStateStepSpec");
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
			builder.Append("ShouldBePaused = ");
			builder.Append(ShouldBePaused.ToString());
			builder.Append(", TemplateName = ");
			builder.Append((object)TemplateName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ShouldBePaused)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TemplateName);
		}

		[CompilerGenerated]
		public virtual bool Equals(ChangePausedStateStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(ShouldBePaused, other!.ShouldBePaused))
				{
					return EqualityComparer<string>.Default.Equals(TemplateName, other!.TemplateName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ChangePausedStateStepSpec(ChangePausedStateStepSpec original)
			: base(original)
		{
			ShouldBePaused = original.ShouldBePaused;
			TemplateName = original.TemplateName;
		}

		public ChangePausedStateStepSpec()
		{
		}
	}
}
