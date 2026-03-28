using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedSpecs
{
	public record ContinuousEffectSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ContinuousEffectSpec);
			}
		}

		[Serialize]
		public string NeedId { get; init; }

		[Serialize]
		public float PointsPerHour { get; init; }

		[Serialize]
		public bool SatisfyToMaxValue { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ContinuousEffectSpec");
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
			builder.Append("NeedId = ");
			builder.Append((object)NeedId);
			builder.Append(", PointsPerHour = ");
			builder.Append(PointsPerHour.ToString());
			builder.Append(", SatisfyToMaxValue = ");
			builder.Append(SatisfyToMaxValue.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NeedId)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(PointsPerHour)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(SatisfyToMaxValue);
		}

		[CompilerGenerated]
		public virtual bool Equals(ContinuousEffectSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(NeedId, other!.NeedId) && EqualityComparer<float>.Default.Equals(PointsPerHour, other!.PointsPerHour))
				{
					return EqualityComparer<bool>.Default.Equals(SatisfyToMaxValue, other!.SatisfyToMaxValue);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ContinuousEffectSpec(ContinuousEffectSpec original)
		{
			NeedId = original.NeedId;
			PointsPerHour = original.PointsPerHour;
			SatisfyToMaxValue = original.SatisfyToMaxValue;
		}

		public ContinuousEffectSpec()
		{
		}
	}
}
