using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Wandering
{
	internal record IdleAnimationVariantSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(IdleAnimationVariantSpec);
			}
		}

		[Serialize]
		public float Probability { get; init; }

		[Serialize]
		public string Variant { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("IdleAnimationVariantSpec");
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
			builder.Append("Probability = ");
			builder.Append(Probability.ToString());
			builder.Append(", Variant = ");
			builder.Append((object)Variant);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Probability)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Variant);
		}

		[CompilerGenerated]
		public virtual bool Equals(IdleAnimationVariantSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<float>.Default.Equals(Probability, other!.Probability))
				{
					return EqualityComparer<string>.Default.Equals(Variant, other!.Variant);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected IdleAnimationVariantSpec(IdleAnimationVariantSpec original)
		{
			Probability = original.Probability;
			Variant = original.Variant;
		}

		public IdleAnimationVariantSpec()
		{
		}
	}
}
