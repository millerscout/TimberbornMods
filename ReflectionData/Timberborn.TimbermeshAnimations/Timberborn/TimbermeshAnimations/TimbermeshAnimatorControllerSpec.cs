using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TimbermeshAnimations
{
	internal record TimbermeshAnimatorControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TimbermeshAnimatorControllerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> BoolParameters { get; init; }

		[Serialize]
		public ImmutableArray<string> FloatParameters { get; init; }

		[Serialize]
		public ImmutableArray<AnimatorState> AnimatorStates { get; init; }

		public IEnumerable<string> UsedBoolParameters => (from c in AnimatorStates.SelectMany((AnimatorState s) => s.Conditions)
			select c.ParameterName).Distinct();

		public IEnumerable<string> UsedFloatParameters => AnimatorStates.Select((AnimatorState s) => s.SpeedModifier).Distinct();

		public IEnumerable<string> AnimationNames => AnimatorStates.Select((AnimatorState s) => s.AnimationName).Distinct();

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TimbermeshAnimatorControllerSpec");
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
			builder.Append("BoolParameters = ");
			builder.Append(BoolParameters.ToString());
			builder.Append(", FloatParameters = ");
			builder.Append(FloatParameters.ToString());
			builder.Append(", AnimatorStates = ");
			builder.Append(AnimatorStates.ToString());
			builder.Append(", UsedBoolParameters = ");
			builder.Append(UsedBoolParameters);
			builder.Append(", UsedFloatParameters = ");
			builder.Append(UsedFloatParameters);
			builder.Append(", AnimationNames = ");
			builder.Append(AnimationNames);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(BoolParameters)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(FloatParameters)) * -1521134295 + EqualityComparer<ImmutableArray<AnimatorState>>.Default.GetHashCode(AnimatorStates);
		}

		[CompilerGenerated]
		public virtual bool Equals(TimbermeshAnimatorControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<string>>.Default.Equals(BoolParameters, other!.BoolParameters) && EqualityComparer<ImmutableArray<string>>.Default.Equals(FloatParameters, other!.FloatParameters))
				{
					return EqualityComparer<ImmutableArray<AnimatorState>>.Default.Equals(AnimatorStates, other!.AnimatorStates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TimbermeshAnimatorControllerSpec(TimbermeshAnimatorControllerSpec original)
			: base(original)
		{
			BoolParameters = original.BoolParameters;
			FloatParameters = original.FloatParameters;
			AnimatorStates = original.AnimatorStates;
		}

		public TimbermeshAnimatorControllerSpec()
		{
		}
	}
}
