using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record ConnectBuildingsTutorialStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ConnectBuildingsTutorialStepSpec);
			}
		}

		[Serialize]
		public string TemplateName { get; init; }

		[Serialize]
		public int RequiredAmount { get; init; }

		[Serialize]
		public bool CountUnfinishedBuildings { get; init; }

		[Serialize]
		public ImmutableArray<string> HighlightableBuildingIds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ConnectBuildingsTutorialStepSpec");
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
			builder.Append(", CountUnfinishedBuildings = ");
			builder.Append(CountUnfinishedBuildings.ToString());
			builder.Append(", HighlightableBuildingIds = ");
			builder.Append(HighlightableBuildingIds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TemplateName)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RequiredAmount)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(CountUnfinishedBuildings)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(HighlightableBuildingIds);
		}

		[CompilerGenerated]
		public virtual bool Equals(ConnectBuildingsTutorialStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(TemplateName, other!.TemplateName) && EqualityComparer<int>.Default.Equals(RequiredAmount, other!.RequiredAmount) && EqualityComparer<bool>.Default.Equals(CountUnfinishedBuildings, other!.CountUnfinishedBuildings))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(HighlightableBuildingIds, other!.HighlightableBuildingIds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ConnectBuildingsTutorialStepSpec(ConnectBuildingsTutorialStepSpec original)
			: base(original)
		{
			TemplateName = original.TemplateName;
			RequiredAmount = original.RequiredAmount;
			CountUnfinishedBuildings = original.CountUnfinishedBuildings;
			HighlightableBuildingIds = original.HighlightableBuildingIds;
		}

		public ConnectBuildingsTutorialStepSpec()
		{
		}
	}
}
