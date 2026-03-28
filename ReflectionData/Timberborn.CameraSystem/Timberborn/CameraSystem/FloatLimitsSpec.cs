using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CameraSystem
{
	public record FloatLimitsSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FloatLimitsSpec);
			}
		}

		[Serialize]
		public float Min { get; init; }

		[Serialize]
		public float Max { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FloatLimitsSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Min = ");
			builder.Append(Min.ToString());
			builder.Append(", Max = ");
			builder.Append(Max.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Min)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Max);
		}

		[CompilerGenerated]
		public virtual bool Equals(FloatLimitsSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<float>.Default.Equals(Min, other!.Min))
				{
					return EqualityComparer<float>.Default.Equals(Max, other!.Max);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FloatLimitsSpec(FloatLimitsSpec original)
		{
			Min = original.Min;
			Max = original.Max;
		}

		public FloatLimitsSpec()
		{
		}
	}
}
