using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SoilMoistureSystem
{
	internal record SoilMoistureSimulatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SoilMoistureSimulatorSpec);
			}
		}

		[Serialize]
		public float MinimumWaterContamination { get; init; }

		[Serialize]
		public float MaximumWaterContamination { get; init; }

		[Serialize]
		public float MoistureDecayRate { get; init; }

		[Serialize]
		public float MoistureSpreadingRate { get; init; }

		[Serialize]
		public int VerticalSpreadCostMultiplier { get; init; }

		[Serialize]
		public int MaxClusterSaturation { get; init; }

		[Serialize]
		public float QuadraticEvaporationCoefficient { get; init; }

		[Serialize]
		public float LinearQuadraticCoefficient { get; init; }

		[Serialize]
		public float ConstantQuadraticCoefficient { get; init; }

		[Serialize]
		public int MaxEvaporationSaturation { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SoilMoistureSimulatorSpec");
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
			builder.Append("MinimumWaterContamination = ");
			builder.Append(MinimumWaterContamination.ToString());
			builder.Append(", MaximumWaterContamination = ");
			builder.Append(MaximumWaterContamination.ToString());
			builder.Append(", MoistureDecayRate = ");
			builder.Append(MoistureDecayRate.ToString());
			builder.Append(", MoistureSpreadingRate = ");
			builder.Append(MoistureSpreadingRate.ToString());
			builder.Append(", VerticalSpreadCostMultiplier = ");
			builder.Append(VerticalSpreadCostMultiplier.ToString());
			builder.Append(", MaxClusterSaturation = ");
			builder.Append(MaxClusterSaturation.ToString());
			builder.Append(", QuadraticEvaporationCoefficient = ");
			builder.Append(QuadraticEvaporationCoefficient.ToString());
			builder.Append(", LinearQuadraticCoefficient = ");
			builder.Append(LinearQuadraticCoefficient.ToString());
			builder.Append(", ConstantQuadraticCoefficient = ");
			builder.Append(ConstantQuadraticCoefficient.ToString());
			builder.Append(", MaxEvaporationSaturation = ");
			builder.Append(MaxEvaporationSaturation.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinimumWaterContamination)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaximumWaterContamination)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MoistureDecayRate)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MoistureSpreadingRate)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(VerticalSpreadCostMultiplier)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxClusterSaturation)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(QuadraticEvaporationCoefficient)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(LinearQuadraticCoefficient)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ConstantQuadraticCoefficient)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxEvaporationSaturation);
		}

		[CompilerGenerated]
		public virtual bool Equals(SoilMoistureSimulatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MinimumWaterContamination, other!.MinimumWaterContamination) && EqualityComparer<float>.Default.Equals(MaximumWaterContamination, other!.MaximumWaterContamination) && EqualityComparer<float>.Default.Equals(MoistureDecayRate, other!.MoistureDecayRate) && EqualityComparer<float>.Default.Equals(MoistureSpreadingRate, other!.MoistureSpreadingRate) && EqualityComparer<int>.Default.Equals(VerticalSpreadCostMultiplier, other!.VerticalSpreadCostMultiplier) && EqualityComparer<int>.Default.Equals(MaxClusterSaturation, other!.MaxClusterSaturation) && EqualityComparer<float>.Default.Equals(QuadraticEvaporationCoefficient, other!.QuadraticEvaporationCoefficient) && EqualityComparer<float>.Default.Equals(LinearQuadraticCoefficient, other!.LinearQuadraticCoefficient) && EqualityComparer<float>.Default.Equals(ConstantQuadraticCoefficient, other!.ConstantQuadraticCoefficient))
				{
					return EqualityComparer<int>.Default.Equals(MaxEvaporationSaturation, other!.MaxEvaporationSaturation);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SoilMoistureSimulatorSpec(SoilMoistureSimulatorSpec original)
			: base(original)
		{
			MinimumWaterContamination = original.MinimumWaterContamination;
			MaximumWaterContamination = original.MaximumWaterContamination;
			MoistureDecayRate = original.MoistureDecayRate;
			MoistureSpreadingRate = original.MoistureSpreadingRate;
			VerticalSpreadCostMultiplier = original.VerticalSpreadCostMultiplier;
			MaxClusterSaturation = original.MaxClusterSaturation;
			QuadraticEvaporationCoefficient = original.QuadraticEvaporationCoefficient;
			LinearQuadraticCoefficient = original.LinearQuadraticCoefficient;
			ConstantQuadraticCoefficient = original.ConstantQuadraticCoefficient;
			MaxEvaporationSaturation = original.MaxEvaporationSaturation;
		}

		public SoilMoistureSimulatorSpec()
		{
		}
	}
}
