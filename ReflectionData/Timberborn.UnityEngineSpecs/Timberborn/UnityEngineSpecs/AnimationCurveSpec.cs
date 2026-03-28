using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.UnityEngineSpecs
{
	public record AnimationCurveSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AnimationCurveSpec);
			}
		}

		[Serialize]
		public ImmutableArray<AnimationKeyframeSpec> Keys { get; init; }

		[Serialize]
		public WrapMode PreWrapMode { get; init; }

		[Serialize]
		public WrapMode PostWrapMode { get; init; }

		public static AnimationCurveSpec FromAnimationCurve(AnimationCurve curve)
		{
			return new AnimationCurveSpec
			{
				Keys = curve.keys.Select(AnimationKeyframeSpec.FromKeyframe).ToImmutableArray(),
				PreWrapMode = curve.preWrapMode,
				PostWrapMode = curve.postWrapMode
			};
		}

		public AnimationCurve ToAnimationCurve()
		{
			return new AnimationCurve(Keys.Select((AnimationKeyframeSpec key) => key.ToKeyframe()).ToArray())
			{
				preWrapMode = PreWrapMode,
				postWrapMode = PostWrapMode
			};
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AnimationCurveSpec");
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
			builder.Append("Keys = ");
			builder.Append(Keys.ToString());
			builder.Append(", PreWrapMode = ");
			builder.Append(PreWrapMode.ToString());
			builder.Append(", PostWrapMode = ");
			builder.Append(PostWrapMode.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ImmutableArray<AnimationKeyframeSpec>>.Default.GetHashCode(Keys)) * -1521134295 + EqualityComparer<WrapMode>.Default.GetHashCode(PreWrapMode)) * -1521134295 + EqualityComparer<WrapMode>.Default.GetHashCode(PostWrapMode);
		}

		[CompilerGenerated]
		public virtual bool Equals(AnimationCurveSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<ImmutableArray<AnimationKeyframeSpec>>.Default.Equals(Keys, other!.Keys) && EqualityComparer<WrapMode>.Default.Equals(PreWrapMode, other!.PreWrapMode))
				{
					return EqualityComparer<WrapMode>.Default.Equals(PostWrapMode, other!.PostWrapMode);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AnimationCurveSpec(AnimationCurveSpec original)
		{
			Keys = original.Keys;
			PreWrapMode = original.PreWrapMode;
			PostWrapMode = original.PostWrapMode;
		}

		public AnimationCurveSpec()
		{
		}
	}
}
