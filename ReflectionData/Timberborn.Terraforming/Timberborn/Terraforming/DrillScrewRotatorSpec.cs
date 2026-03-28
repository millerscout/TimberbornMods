using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Terraforming
{
	public record DrillScrewRotatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DrillScrewRotatorSpec);
			}
		}

		[Serialize]
		public float MinimumRotationSpeed { get; init; }

		[Serialize]
		public float RotationSpeedPerWorker { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DrillScrewRotatorSpec");
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
			builder.Append("MinimumRotationSpeed = ");
			builder.Append(MinimumRotationSpeed.ToString());
			builder.Append(", RotationSpeedPerWorker = ");
			builder.Append(RotationSpeedPerWorker.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinimumRotationSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RotationSpeedPerWorker);
		}

		[CompilerGenerated]
		public virtual bool Equals(DrillScrewRotatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MinimumRotationSpeed, other!.MinimumRotationSpeed))
				{
					return EqualityComparer<float>.Default.Equals(RotationSpeedPerWorker, other!.RotationSpeedPerWorker);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DrillScrewRotatorSpec(DrillScrewRotatorSpec original)
			: base(original)
		{
			MinimumRotationSpeed = original.MinimumRotationSpeed;
			RotationSpeedPerWorker = original.RotationSpeedPerWorker;
		}

		public DrillScrewRotatorSpec()
		{
		}
	}
}
