using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CharacterMovementSystem
{
	internal record MovementAnimatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MovementAnimatorSpec);
			}
		}

		[Serialize]
		public float AnimationSpeedScale { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MovementAnimatorSpec");
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
			builder.Append("AnimationSpeedScale = ");
			builder.Append(AnimationSpeedScale.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(AnimationSpeedScale);
		}

		[CompilerGenerated]
		public virtual bool Equals(MovementAnimatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(AnimationSpeedScale, other!.AnimationSpeedScale);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MovementAnimatorSpec(MovementAnimatorSpec original)
			: base(original)
		{
			AnimationSpeedScale = original.AnimationSpeedScale;
		}

		public MovementAnimatorSpec()
		{
		}
	}
}
