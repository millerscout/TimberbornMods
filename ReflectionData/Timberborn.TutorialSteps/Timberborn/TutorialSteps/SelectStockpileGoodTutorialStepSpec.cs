using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record SelectStockpileGoodTutorialStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SelectStockpileGoodTutorialStepSpec);
			}
		}

		[Serialize]
		public string TemplateName { get; init; }

		[Serialize]
		public int RequiredAmount { get; init; }

		[Serialize]
		public string GoodId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SelectStockpileGoodTutorialStepSpec");
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
			builder.Append(", GoodId = ");
			builder.Append((object)GoodId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TemplateName)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RequiredAmount)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodId);
		}

		[CompilerGenerated]
		public virtual bool Equals(SelectStockpileGoodTutorialStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(TemplateName, other!.TemplateName) && EqualityComparer<int>.Default.Equals(RequiredAmount, other!.RequiredAmount))
				{
					return EqualityComparer<string>.Default.Equals(GoodId, other!.GoodId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SelectStockpileGoodTutorialStepSpec(SelectStockpileGoodTutorialStepSpec original)
			: base(original)
		{
			TemplateName = original.TemplateName;
			RequiredAmount = original.RequiredAmount;
			GoodId = original.GoodId;
		}

		public SelectStockpileGoodTutorialStepSpec()
		{
		}
	}
}
