using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record PowerBuildingsTutorialStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PowerBuildingsTutorialStepSpec);
			}
		}

		[Serialize]
		public string TemplateName { get; init; }

		[Serialize]
		public int RequiredAmount { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PowerBuildingsTutorialStepSpec");
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
			builder.Append("TemplateName = ");
			builder.Append((object)TemplateName);
			builder.Append(", RequiredAmount = ");
			builder.Append(RequiredAmount.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TemplateName)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RequiredAmount);
		}

		[CompilerGenerated]
		public virtual bool Equals(PowerBuildingsTutorialStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(TemplateName, other!.TemplateName))
				{
					return EqualityComparer<int>.Default.Equals(RequiredAmount, other!.RequiredAmount);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PowerBuildingsTutorialStepSpec(PowerBuildingsTutorialStepSpec original)
			: base(original)
		{
			TemplateName = original.TemplateName;
			RequiredAmount = original.RequiredAmount;
		}

		public PowerBuildingsTutorialStepSpec()
		{
		}
	}
}
