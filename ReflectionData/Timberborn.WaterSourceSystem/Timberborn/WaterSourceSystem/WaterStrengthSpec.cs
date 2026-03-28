using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterSourceSystem
{
	internal record WaterStrengthSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterStrengthSpec);
			}
		}

		[Serialize]
		public float MaxWaterSourceStrength { get; init; }

		[Serialize]
		public float MaxWaterSourceChangePerSecond { get; init; }

		[Serialize]
		public float MinWaterSourceChangeScaler { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterStrengthSpec");
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
			builder.Append("MaxWaterSourceStrength = ");
			builder.Append(MaxWaterSourceStrength.ToString());
			builder.Append(", MaxWaterSourceChangePerSecond = ");
			builder.Append(MaxWaterSourceChangePerSecond.ToString());
			builder.Append(", MinWaterSourceChangeScaler = ");
			builder.Append(MinWaterSourceChangeScaler.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWaterSourceStrength)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWaterSourceChangePerSecond)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinWaterSourceChangeScaler);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterStrengthSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MaxWaterSourceStrength, other!.MaxWaterSourceStrength) && EqualityComparer<float>.Default.Equals(MaxWaterSourceChangePerSecond, other!.MaxWaterSourceChangePerSecond))
				{
					return EqualityComparer<float>.Default.Equals(MinWaterSourceChangeScaler, other!.MinWaterSourceChangeScaler);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterStrengthSpec(WaterStrengthSpec original)
			: base(original)
		{
			MaxWaterSourceStrength = original.MaxWaterSourceStrength;
			MaxWaterSourceChangePerSecond = original.MaxWaterSourceChangePerSecond;
			MinWaterSourceChangeScaler = original.MinWaterSourceChangeScaler;
		}

		public WaterStrengthSpec()
		{
		}
	}
}
