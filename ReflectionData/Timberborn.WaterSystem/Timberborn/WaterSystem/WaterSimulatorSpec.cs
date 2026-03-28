using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterSystem
{
	internal record WaterSimulatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterSimulatorSpec);
			}
		}

		[Serialize]
		public float WaterFlowFactor { get; init; }

		[Serialize]
		public float WaterSpillThreshold { get; init; }

		[Serialize]
		public float NormalEvaporationSpeed { get; init; }

		[Serialize]
		public float FastEvaporationDepthThreshold { get; init; }

		[Serialize]
		public float FastEvaporationSpeed { get; init; }

		[Serialize]
		public float OutflowBalancingScaler { get; init; }

		[Serialize]
		public float SoftDamOffset { get; init; }

		[Serialize]
		public float HardDamOffset { get; init; }

		[Serialize]
		public float MaxHardDamDecrease { get; init; }

		[Serialize]
		public float FlowChangeLimit { get; init; }

		[Serialize]
		public float OverflowPressureFactor { get; init; }

		[Serialize]
		public float DiffusionOutflowLimit { get; init; }

		[Serialize]
		public float DiffusionDepthLimit { get; init; }

		[Serialize]
		public float DiffusionRate { get; init; }

		[Serialize]
		public float MaxWaterContamination { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterSimulatorSpec");
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
			builder.Append("WaterFlowFactor = ");
			builder.Append(WaterFlowFactor.ToString());
			builder.Append(", WaterSpillThreshold = ");
			builder.Append(WaterSpillThreshold.ToString());
			builder.Append(", NormalEvaporationSpeed = ");
			builder.Append(NormalEvaporationSpeed.ToString());
			builder.Append(", FastEvaporationDepthThreshold = ");
			builder.Append(FastEvaporationDepthThreshold.ToString());
			builder.Append(", FastEvaporationSpeed = ");
			builder.Append(FastEvaporationSpeed.ToString());
			builder.Append(", OutflowBalancingScaler = ");
			builder.Append(OutflowBalancingScaler.ToString());
			builder.Append(", SoftDamOffset = ");
			builder.Append(SoftDamOffset.ToString());
			builder.Append(", HardDamOffset = ");
			builder.Append(HardDamOffset.ToString());
			builder.Append(", MaxHardDamDecrease = ");
			builder.Append(MaxHardDamDecrease.ToString());
			builder.Append(", FlowChangeLimit = ");
			builder.Append(FlowChangeLimit.ToString());
			builder.Append(", OverflowPressureFactor = ");
			builder.Append(OverflowPressureFactor.ToString());
			builder.Append(", DiffusionOutflowLimit = ");
			builder.Append(DiffusionOutflowLimit.ToString());
			builder.Append(", DiffusionDepthLimit = ");
			builder.Append(DiffusionDepthLimit.ToString());
			builder.Append(", DiffusionRate = ");
			builder.Append(DiffusionRate.ToString());
			builder.Append(", MaxWaterContamination = ");
			builder.Append(MaxWaterContamination.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(WaterFlowFactor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(WaterSpillThreshold)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(NormalEvaporationSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FastEvaporationDepthThreshold)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FastEvaporationSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(OutflowBalancingScaler)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(SoftDamOffset)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(HardDamOffset)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxHardDamDecrease)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FlowChangeLimit)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(OverflowPressureFactor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DiffusionOutflowLimit)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DiffusionDepthLimit)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DiffusionRate)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWaterContamination);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterSimulatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(WaterFlowFactor, other!.WaterFlowFactor) && EqualityComparer<float>.Default.Equals(WaterSpillThreshold, other!.WaterSpillThreshold) && EqualityComparer<float>.Default.Equals(NormalEvaporationSpeed, other!.NormalEvaporationSpeed) && EqualityComparer<float>.Default.Equals(FastEvaporationDepthThreshold, other!.FastEvaporationDepthThreshold) && EqualityComparer<float>.Default.Equals(FastEvaporationSpeed, other!.FastEvaporationSpeed) && EqualityComparer<float>.Default.Equals(OutflowBalancingScaler, other!.OutflowBalancingScaler) && EqualityComparer<float>.Default.Equals(SoftDamOffset, other!.SoftDamOffset) && EqualityComparer<float>.Default.Equals(HardDamOffset, other!.HardDamOffset) && EqualityComparer<float>.Default.Equals(MaxHardDamDecrease, other!.MaxHardDamDecrease) && EqualityComparer<float>.Default.Equals(FlowChangeLimit, other!.FlowChangeLimit) && EqualityComparer<float>.Default.Equals(OverflowPressureFactor, other!.OverflowPressureFactor) && EqualityComparer<float>.Default.Equals(DiffusionOutflowLimit, other!.DiffusionOutflowLimit) && EqualityComparer<float>.Default.Equals(DiffusionDepthLimit, other!.DiffusionDepthLimit) && EqualityComparer<float>.Default.Equals(DiffusionRate, other!.DiffusionRate))
				{
					return EqualityComparer<float>.Default.Equals(MaxWaterContamination, other!.MaxWaterContamination);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterSimulatorSpec(WaterSimulatorSpec original)
			: base(original)
		{
			WaterFlowFactor = original.WaterFlowFactor;
			WaterSpillThreshold = original.WaterSpillThreshold;
			NormalEvaporationSpeed = original.NormalEvaporationSpeed;
			FastEvaporationDepthThreshold = original.FastEvaporationDepthThreshold;
			FastEvaporationSpeed = original.FastEvaporationSpeed;
			OutflowBalancingScaler = original.OutflowBalancingScaler;
			SoftDamOffset = original.SoftDamOffset;
			HardDamOffset = original.HardDamOffset;
			MaxHardDamDecrease = original.MaxHardDamDecrease;
			FlowChangeLimit = original.FlowChangeLimit;
			OverflowPressureFactor = original.OverflowPressureFactor;
			DiffusionOutflowLimit = original.DiffusionOutflowLimit;
			DiffusionDepthLimit = original.DiffusionDepthLimit;
			DiffusionRate = original.DiffusionRate;
			MaxWaterContamination = original.MaxWaterContamination;
		}

		public WaterSimulatorSpec()
		{
		}
	}
}
