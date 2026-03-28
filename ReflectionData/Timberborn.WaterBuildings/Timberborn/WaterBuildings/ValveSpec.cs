using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterBuildings
{
	internal record ValveSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ValveSpec);
			}
		}

		[Serialize]
		public float MaxOutflowLimit { get; init; }

		[Serialize]
		public float OutflowLimitStep { get; init; }

		[Serialize]
		public bool DefaultOutflowLimitEnabled { get; init; }

		[Serialize]
		public float DefaultOutflowLimit { get; init; }

		[Serialize]
		public bool DefaultAutomationOutflowLimitEnabled { get; init; }

		[Serialize]
		public float DefaultAutomationOutflowLimit { get; init; }

		[Serialize]
		public float RateOfChangeHighPrimary { get; init; }

		[Serialize]
		public float RateOfChangeHighSecondary { get; init; }

		[Serialize]
		public float RateOfChangeLowPrimary { get; init; }

		[Serialize]
		public float RateOfChangeLowSecondary { get; init; }

		[Serialize]
		public int RateOfChangePrimaryTicks { get; init; }

		[Serialize]
		public int RateOfChangePrimaryToSecondaryTicks { get; init; }

		[Serialize]
		public float ReactionSpeedExponent { get; init; }

		[Serialize]
		public float ReactionSpeedStep { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ValveSpec");
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
			builder.Append("MaxOutflowLimit = ");
			builder.Append(MaxOutflowLimit.ToString());
			builder.Append(", OutflowLimitStep = ");
			builder.Append(OutflowLimitStep.ToString());
			builder.Append(", DefaultOutflowLimitEnabled = ");
			builder.Append(DefaultOutflowLimitEnabled.ToString());
			builder.Append(", DefaultOutflowLimit = ");
			builder.Append(DefaultOutflowLimit.ToString());
			builder.Append(", DefaultAutomationOutflowLimitEnabled = ");
			builder.Append(DefaultAutomationOutflowLimitEnabled.ToString());
			builder.Append(", DefaultAutomationOutflowLimit = ");
			builder.Append(DefaultAutomationOutflowLimit.ToString());
			builder.Append(", RateOfChangeHighPrimary = ");
			builder.Append(RateOfChangeHighPrimary.ToString());
			builder.Append(", RateOfChangeHighSecondary = ");
			builder.Append(RateOfChangeHighSecondary.ToString());
			builder.Append(", RateOfChangeLowPrimary = ");
			builder.Append(RateOfChangeLowPrimary.ToString());
			builder.Append(", RateOfChangeLowSecondary = ");
			builder.Append(RateOfChangeLowSecondary.ToString());
			builder.Append(", RateOfChangePrimaryTicks = ");
			builder.Append(RateOfChangePrimaryTicks.ToString());
			builder.Append(", RateOfChangePrimaryToSecondaryTicks = ");
			builder.Append(RateOfChangePrimaryToSecondaryTicks.ToString());
			builder.Append(", ReactionSpeedExponent = ");
			builder.Append(ReactionSpeedExponent.ToString());
			builder.Append(", ReactionSpeedStep = ");
			builder.Append(ReactionSpeedStep.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxOutflowLimit)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(OutflowLimitStep)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DefaultOutflowLimitEnabled)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DefaultOutflowLimit)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DefaultAutomationOutflowLimitEnabled)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DefaultAutomationOutflowLimit)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RateOfChangeHighPrimary)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RateOfChangeHighSecondary)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RateOfChangeLowPrimary)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RateOfChangeLowSecondary)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RateOfChangePrimaryTicks)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RateOfChangePrimaryToSecondaryTicks)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ReactionSpeedExponent)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ReactionSpeedStep);
		}

		[CompilerGenerated]
		public virtual bool Equals(ValveSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MaxOutflowLimit, other!.MaxOutflowLimit) && EqualityComparer<float>.Default.Equals(OutflowLimitStep, other!.OutflowLimitStep) && EqualityComparer<bool>.Default.Equals(DefaultOutflowLimitEnabled, other!.DefaultOutflowLimitEnabled) && EqualityComparer<float>.Default.Equals(DefaultOutflowLimit, other!.DefaultOutflowLimit) && EqualityComparer<bool>.Default.Equals(DefaultAutomationOutflowLimitEnabled, other!.DefaultAutomationOutflowLimitEnabled) && EqualityComparer<float>.Default.Equals(DefaultAutomationOutflowLimit, other!.DefaultAutomationOutflowLimit) && EqualityComparer<float>.Default.Equals(RateOfChangeHighPrimary, other!.RateOfChangeHighPrimary) && EqualityComparer<float>.Default.Equals(RateOfChangeHighSecondary, other!.RateOfChangeHighSecondary) && EqualityComparer<float>.Default.Equals(RateOfChangeLowPrimary, other!.RateOfChangeLowPrimary) && EqualityComparer<float>.Default.Equals(RateOfChangeLowSecondary, other!.RateOfChangeLowSecondary) && EqualityComparer<int>.Default.Equals(RateOfChangePrimaryTicks, other!.RateOfChangePrimaryTicks) && EqualityComparer<int>.Default.Equals(RateOfChangePrimaryToSecondaryTicks, other!.RateOfChangePrimaryToSecondaryTicks) && EqualityComparer<float>.Default.Equals(ReactionSpeedExponent, other!.ReactionSpeedExponent))
				{
					return EqualityComparer<float>.Default.Equals(ReactionSpeedStep, other!.ReactionSpeedStep);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ValveSpec(ValveSpec original)
			: base(original)
		{
			MaxOutflowLimit = original.MaxOutflowLimit;
			OutflowLimitStep = original.OutflowLimitStep;
			DefaultOutflowLimitEnabled = original.DefaultOutflowLimitEnabled;
			DefaultOutflowLimit = original.DefaultOutflowLimit;
			DefaultAutomationOutflowLimitEnabled = original.DefaultAutomationOutflowLimitEnabled;
			DefaultAutomationOutflowLimit = original.DefaultAutomationOutflowLimit;
			RateOfChangeHighPrimary = original.RateOfChangeHighPrimary;
			RateOfChangeHighSecondary = original.RateOfChangeHighSecondary;
			RateOfChangeLowPrimary = original.RateOfChangeLowPrimary;
			RateOfChangeLowSecondary = original.RateOfChangeLowSecondary;
			RateOfChangePrimaryTicks = original.RateOfChangePrimaryTicks;
			RateOfChangePrimaryToSecondaryTicks = original.RateOfChangePrimaryToSecondaryTicks;
			ReactionSpeedExponent = original.ReactionSpeedExponent;
			ReactionSpeedStep = original.ReactionSpeedStep;
		}

		public ValveSpec()
		{
		}
	}
}
