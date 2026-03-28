using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Common;
using Timberborn.FeatureToggleSystem;

namespace Timberborn.TemplateSystem
{
	public record TemplateSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TemplateSpec);
			}
		}

		[Serialize]
		public string TemplateName { get; init; }

		[Serialize]
		public ImmutableArray<string> BackwardCompatibleTemplateNames { get; init; }

		[Serialize]
		public string RequiredFeatureToggle { get; init; }

		[Serialize]
		public string DisablingFeatureToggle { get; init; }

		public bool UsableWithCurrentFeatureToggles
		{
			get
			{
				if (FeatureToggleService.IsToggleOn(RequiredFeatureToggle))
				{
					if (!string.IsNullOrEmpty(DisablingFeatureToggle))
					{
						return !FeatureToggleService.IsToggleOn(DisablingFeatureToggle);
					}
					return true;
				}
				return false;
			}
		}

		public bool IsNamed(string templateName)
		{
			if (!IsNamedExactly(templateName))
			{
				return BackwardCompatibleTemplateNames.FastContains(templateName);
			}
			return true;
		}

		public bool IsNamedExactly(string templateName)
		{
			return TemplateName == templateName;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TemplateSpec");
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
			builder.Append(", BackwardCompatibleTemplateNames = ");
			builder.Append(BackwardCompatibleTemplateNames.ToString());
			builder.Append(", RequiredFeatureToggle = ");
			builder.Append((object)RequiredFeatureToggle);
			builder.Append(", DisablingFeatureToggle = ");
			builder.Append((object)DisablingFeatureToggle);
			builder.Append(", UsableWithCurrentFeatureToggles = ");
			builder.Append(UsableWithCurrentFeatureToggles.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TemplateName)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(BackwardCompatibleTemplateNames)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RequiredFeatureToggle)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisablingFeatureToggle);
		}

		[CompilerGenerated]
		public virtual bool Equals(TemplateSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(TemplateName, other!.TemplateName) && EqualityComparer<ImmutableArray<string>>.Default.Equals(BackwardCompatibleTemplateNames, other!.BackwardCompatibleTemplateNames) && EqualityComparer<string>.Default.Equals(RequiredFeatureToggle, other!.RequiredFeatureToggle))
				{
					return EqualityComparer<string>.Default.Equals(DisablingFeatureToggle, other!.DisablingFeatureToggle);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TemplateSpec(TemplateSpec original)
			: base(original)
		{
			TemplateName = original.TemplateName;
			BackwardCompatibleTemplateNames = original.BackwardCompatibleTemplateNames;
			RequiredFeatureToggle = original.RequiredFeatureToggle;
			DisablingFeatureToggle = original.DisablingFeatureToggle;
		}

		public TemplateSpec()
		{
		}
	}
}
