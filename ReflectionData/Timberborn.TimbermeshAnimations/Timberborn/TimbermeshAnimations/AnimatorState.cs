using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TimbermeshAnimations
{
	internal record AnimatorState
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AnimatorState);
			}
		}

		[Serialize]
		public string StateName { get; init; }

		[Serialize]
		public string AnimationName { get; init; }

		[Serialize]
		public float Speed { get; init; }

		[Serialize]
		public string SpeedModifier { get; init; }

		[Serialize]
		public bool Looped { get; init; }

		[Serialize]
		public ImmutableArray<AnimatorStateCondition> Conditions { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AnimatorState");
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
			builder.Append("StateName = ");
			builder.Append((object)StateName);
			builder.Append(", AnimationName = ");
			builder.Append((object)AnimationName);
			builder.Append(", Speed = ");
			builder.Append(Speed.ToString());
			builder.Append(", SpeedModifier = ");
			builder.Append((object)SpeedModifier);
			builder.Append(", Looped = ");
			builder.Append(Looped.ToString());
			builder.Append(", Conditions = ");
			builder.Append(Conditions.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StateName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AnimationName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Speed)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SpeedModifier)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Looped)) * -1521134295 + EqualityComparer<ImmutableArray<AnimatorStateCondition>>.Default.GetHashCode(Conditions);
		}

		[CompilerGenerated]
		public virtual bool Equals(AnimatorState? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(StateName, other!.StateName) && EqualityComparer<string>.Default.Equals(AnimationName, other!.AnimationName) && EqualityComparer<float>.Default.Equals(Speed, other!.Speed) && EqualityComparer<string>.Default.Equals(SpeedModifier, other!.SpeedModifier) && EqualityComparer<bool>.Default.Equals(Looped, other!.Looped))
				{
					return EqualityComparer<ImmutableArray<AnimatorStateCondition>>.Default.Equals(Conditions, other!.Conditions);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AnimatorState(AnimatorState original)
		{
			StateName = original.StateName;
			AnimationName = original.AnimationName;
			Speed = original.Speed;
			SpeedModifier = original.SpeedModifier;
			Looped = original.Looped;
			Conditions = original.Conditions;
		}

		public AnimatorState()
		{
			Speed = 1f;
			Looped = true;
			base._002Ector();
		}
	}
}
