using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record BuildingTutorialStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildingTutorialStepSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> TemplateNames { get; init; }

		[Serialize]
		public bool OnlyFinishedBuildings { get; init; }

		[Serialize]
		public int RequiredAmount { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildingTutorialStepSpec");
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
			builder.Append("TemplateNames = ");
			builder.Append(TemplateNames.ToString());
			builder.Append(", OnlyFinishedBuildings = ");
			builder.Append(OnlyFinishedBuildings.ToString());
			builder.Append(", RequiredAmount = ");
			builder.Append(RequiredAmount.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(TemplateNames)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(OnlyFinishedBuildings)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RequiredAmount);
		}

		[CompilerGenerated]
		public virtual bool Equals(BuildingTutorialStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<string>>.Default.Equals(TemplateNames, other!.TemplateNames) && EqualityComparer<bool>.Default.Equals(OnlyFinishedBuildings, other!.OnlyFinishedBuildings))
				{
					return EqualityComparer<int>.Default.Equals(RequiredAmount, other!.RequiredAmount);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BuildingTutorialStepSpec(BuildingTutorialStepSpec original)
			: base(original)
		{
			TemplateNames = original.TemplateNames;
			OnlyFinishedBuildings = original.OnlyFinishedBuildings;
			RequiredAmount = original.RequiredAmount;
		}

		public BuildingTutorialStepSpec()
		{
		}
	}
}
