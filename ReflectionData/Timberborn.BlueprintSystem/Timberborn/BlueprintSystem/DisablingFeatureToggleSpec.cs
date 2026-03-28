using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.FeatureToggleSystem;

namespace Timberborn.BlueprintSystem
{
	internal record DisablingFeatureToggleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DisablingFeatureToggleSpec);
			}
		}

		[Serialize]
		public string Toggle { get; init; }

		public bool Disabled => FeatureToggleService.IsToggleOn(Toggle);

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DisablingFeatureToggleSpec");
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
			builder.Append("Toggle = ");
			builder.Append((object)Toggle);
			builder.Append(", Disabled = ");
			builder.Append(Disabled.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Toggle);
		}

		[CompilerGenerated]
		public virtual bool Equals(DisablingFeatureToggleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(Toggle, other!.Toggle);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DisablingFeatureToggleSpec(DisablingFeatureToggleSpec original)
			: base(original)
		{
			Toggle = original.Toggle;
		}

		public DisablingFeatureToggleSpec()
		{
		}
	}
}
