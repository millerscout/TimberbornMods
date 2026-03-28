using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record VisibleLevelChangeStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(VisibleLevelChangeStepSpec);
			}
		}

		[Serialize]
		public VisibleLevelChangeType VisibleLevelChangeType { get; init; }

		[Serialize]
		public bool ShowKeybindings { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("VisibleLevelChangeStepSpec");
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
			builder.Append("VisibleLevelChangeType = ");
			builder.Append(VisibleLevelChangeType.ToString());
			builder.Append(", ShowKeybindings = ");
			builder.Append(ShowKeybindings.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<VisibleLevelChangeType>.Default.GetHashCode(VisibleLevelChangeType)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ShowKeybindings);
		}

		[CompilerGenerated]
		public virtual bool Equals(VisibleLevelChangeStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<VisibleLevelChangeType>.Default.Equals(VisibleLevelChangeType, other!.VisibleLevelChangeType))
				{
					return EqualityComparer<bool>.Default.Equals(ShowKeybindings, other!.ShowKeybindings);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected VisibleLevelChangeStepSpec(VisibleLevelChangeStepSpec original)
			: base(original)
		{
			VisibleLevelChangeType = original.VisibleLevelChangeType;
			ShowKeybindings = original.ShowKeybindings;
		}

		public VisibleLevelChangeStepSpec()
		{
		}
	}
}
