using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SoilContaminationSystem
{
	internal record SoilContaminationSimulatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SoilContaminationSimulatorSpec);
			}
		}

		[Serialize]
		public int MaxRangeFromSource { get; init; }

		[Serialize]
		public float VerticalSpreadCostMultiplier { get; init; }

		[Serialize]
		public float ContaminationSpreadingRate { get; init; }

		[Serialize]
		public float ContaminationDecayRate { get; init; }

		[Serialize]
		public float ContaminationPositiveEqualizationRate { get; init; }

		[Serialize]
		public float ContaminationNegativeEqualizationRate { get; init; }

		[Serialize]
		public float MinimumWaterContamination { get; init; }

		[Serialize]
		public float ContaminationThreshold { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SoilContaminationSimulatorSpec");
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
			builder.Append("MaxRangeFromSource = ");
			builder.Append(MaxRangeFromSource.ToString());
			builder.Append(", VerticalSpreadCostMultiplier = ");
			builder.Append(VerticalSpreadCostMultiplier.ToString());
			builder.Append(", ContaminationSpreadingRate = ");
			builder.Append(ContaminationSpreadingRate.ToString());
			builder.Append(", ContaminationDecayRate = ");
			builder.Append(ContaminationDecayRate.ToString());
			builder.Append(", ContaminationPositiveEqualizationRate = ");
			builder.Append(ContaminationPositiveEqualizationRate.ToString());
			builder.Append(", ContaminationNegativeEqualizationRate = ");
			builder.Append(ContaminationNegativeEqualizationRate.ToString());
			builder.Append(", MinimumWaterContamination = ");
			builder.Append(MinimumWaterContamination.ToString());
			builder.Append(", ContaminationThreshold = ");
			builder.Append(ContaminationThreshold.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxRangeFromSource)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(VerticalSpreadCostMultiplier)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ContaminationSpreadingRate)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ContaminationDecayRate)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ContaminationPositiveEqualizationRate)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ContaminationNegativeEqualizationRate)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinimumWaterContamination)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ContaminationThreshold);
		}

		[CompilerGenerated]
		public virtual bool Equals(SoilContaminationSimulatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MaxRangeFromSource, other!.MaxRangeFromSource) && EqualityComparer<float>.Default.Equals(VerticalSpreadCostMultiplier, other!.VerticalSpreadCostMultiplier) && EqualityComparer<float>.Default.Equals(ContaminationSpreadingRate, other!.ContaminationSpreadingRate) && EqualityComparer<float>.Default.Equals(ContaminationDecayRate, other!.ContaminationDecayRate) && EqualityComparer<float>.Default.Equals(ContaminationPositiveEqualizationRate, other!.ContaminationPositiveEqualizationRate) && EqualityComparer<float>.Default.Equals(ContaminationNegativeEqualizationRate, other!.ContaminationNegativeEqualizationRate) && EqualityComparer<float>.Default.Equals(MinimumWaterContamination, other!.MinimumWaterContamination))
				{
					return EqualityComparer<float>.Default.Equals(ContaminationThreshold, other!.ContaminationThreshold);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SoilContaminationSimulatorSpec(SoilContaminationSimulatorSpec original)
			: base(original)
		{
			MaxRangeFromSource = original.MaxRangeFromSource;
			VerticalSpreadCostMultiplier = original.VerticalSpreadCostMultiplier;
			ContaminationSpreadingRate = original.ContaminationSpreadingRate;
			ContaminationDecayRate = original.ContaminationDecayRate;
			ContaminationPositiveEqualizationRate = original.ContaminationPositiveEqualizationRate;
			ContaminationNegativeEqualizationRate = original.ContaminationNegativeEqualizationRate;
			MinimumWaterContamination = original.MinimumWaterContamination;
			ContaminationThreshold = original.ContaminationThreshold;
		}

		public SoilContaminationSimulatorSpec()
		{
		}
	}
}
