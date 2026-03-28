using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record IncreaseDesiredWorkersStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(IncreaseDesiredWorkersStepSpec);
			}
		}

		[Serialize]
		public string TemplateName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("IncreaseDesiredWorkersStepSpec");
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
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TemplateName);
		}

		[CompilerGenerated]
		public virtual bool Equals(IncreaseDesiredWorkersStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(TemplateName, other!.TemplateName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected IncreaseDesiredWorkersStepSpec(IncreaseDesiredWorkersStepSpec original)
			: base(original)
		{
			TemplateName = original.TemplateName;
		}

		public IncreaseDesiredWorkersStepSpec()
		{
		}
	}
}
