using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Effects;

namespace Timberborn.NeedApplication
{
	public record NeedApplierEffectSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedApplierEffectSpec);
			}
		}

		[Serialize]
		public string NeedId { get; init; }

		[Serialize]
		public float Points { get; init; }

		[Serialize]
		public EffectProbability Probability { get; init; }

		public InstantEffect ToInstantEffect()
		{
			return new InstantEffect(NeedId, Points, 1);
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedApplierEffectSpec");
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
			builder.Append(", Points = ");
			builder.Append(Points.ToString());
			builder.Append(", Probability = ");
			builder.Append(Probability.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NeedId)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Points)) * -1521134295 + EqualityComparer<EffectProbability>.Default.GetHashCode(Probability);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedApplierEffectSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(NeedId, other!.NeedId) && EqualityComparer<float>.Default.Equals(Points, other!.Points))
				{
					return EqualityComparer<EffectProbability>.Default.Equals(Probability, other!.Probability);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedApplierEffectSpec(NeedApplierEffectSpec original)
		{
			NeedId = original.NeedId;
			Points = original.Points;
			Probability = original.Probability;
		}

		public NeedApplierEffectSpec()
		{
		}
	}
}
