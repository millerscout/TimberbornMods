using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.TutorialSteps
{
	internal record SelectEntityStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SelectEntityStepSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> TemplateNames { get; init; }

		[Serialize("DescriptionLocKey")]
		public LocalizedText Description { get; init; }

		[Serialize]
		private string DescriptionLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SelectEntityStepSpec");
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
			builder.Append(", Description = ");
			builder.Append(Description);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(TemplateNames)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(Description)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DescriptionLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(SelectEntityStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<string>>.Default.Equals(TemplateNames, other!.TemplateNames) && EqualityComparer<LocalizedText>.Default.Equals(Description, other!.Description))
				{
					return EqualityComparer<string>.Default.Equals(DescriptionLocKey, other!.DescriptionLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SelectEntityStepSpec(SelectEntityStepSpec original)
			: base(original)
		{
			TemplateNames = original.TemplateNames;
			Description = original.Description;
			DescriptionLocKey = original.DescriptionLocKey;
		}

		public SelectEntityStepSpec()
		{
		}
	}
}
