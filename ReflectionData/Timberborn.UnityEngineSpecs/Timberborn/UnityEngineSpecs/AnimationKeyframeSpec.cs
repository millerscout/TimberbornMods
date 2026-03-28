using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.UnityEngineSpecs
{
	public record AnimationKeyframeSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AnimationKeyframeSpec);
			}
		}

		[Serialize]
		public float Time { get; init; }

		[Serialize]
		public float Value { get; init; }

		[Serialize]
		public float InTangent { get; init; }

		[Serialize]
		public float OutTangent { get; init; }

		[Serialize]
		public int WeightedMode { get; init; }

		[Serialize]
		public float InWeight { get; init; }

		[Serialize]
		public float OutWeight { get; init; }

		public static AnimationKeyframeSpec FromKeyframe(Keyframe keyframe)
		{
			return new AnimationKeyframeSpec
			{
				Time = keyframe.time,
				Value = keyframe.value,
				InTangent = keyframe.inTangent,
				OutTangent = keyframe.outTangent,
				WeightedMode = (int)keyframe.weightedMode,
				InWeight = keyframe.inWeight,
				OutWeight = keyframe.outWeight
			};
		}

		public Keyframe ToKeyframe()
		{
			Keyframe result = default(Keyframe);
			result.time = Time;
			result.value = Value;
			result.inTangent = InTangent;
			result.outTangent = OutTangent;
			result.weightedMode = (WeightedMode)WeightedMode;
			result.inWeight = InWeight;
			result.outWeight = OutWeight;
			return result;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AnimationKeyframeSpec");
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
			builder.Append("Time = ");
			builder.Append(Time.ToString());
			builder.Append(", Value = ");
			builder.Append(Value.ToString());
			builder.Append(", InTangent = ");
			builder.Append(InTangent.ToString());
			builder.Append(", OutTangent = ");
			builder.Append(OutTangent.ToString());
			builder.Append(", WeightedMode = ");
			builder.Append(WeightedMode.ToString());
			builder.Append(", InWeight = ");
			builder.Append(InWeight.ToString());
			builder.Append(", OutWeight = ");
			builder.Append(OutWeight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Time)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Value)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(InTangent)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(OutTangent)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(WeightedMode)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(InWeight)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(OutWeight);
		}

		[CompilerGenerated]
		public virtual bool Equals(AnimationKeyframeSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<float>.Default.Equals(Time, other!.Time) && EqualityComparer<float>.Default.Equals(Value, other!.Value) && EqualityComparer<float>.Default.Equals(InTangent, other!.InTangent) && EqualityComparer<float>.Default.Equals(OutTangent, other!.OutTangent) && EqualityComparer<int>.Default.Equals(WeightedMode, other!.WeightedMode) && EqualityComparer<float>.Default.Equals(InWeight, other!.InWeight))
				{
					return EqualityComparer<float>.Default.Equals(OutWeight, other!.OutWeight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AnimationKeyframeSpec(AnimationKeyframeSpec original)
		{
			Time = original.Time;
			Value = original.Value;
			InTangent = original.InTangent;
			OutTangent = original.OutTangent;
			WeightedMode = original.WeightedMode;
			InWeight = original.InWeight;
			OutWeight = original.OutWeight;
		}

		public AnimationKeyframeSpec()
		{
		}
	}
}
