using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedSpecs
{
	public record InstantEffectSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(InstantEffectSpec);
			}
		}

		[Serialize]
		public string NeedId { get; init; }

		[Serialize]
		public float Points { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("InstantEffectSpec");
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
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NeedId)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Points);
		}

		[CompilerGenerated]
		public virtual bool Equals(InstantEffectSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(NeedId, other!.NeedId))
				{
					return EqualityComparer<float>.Default.Equals(Points, other!.Points);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected InstantEffectSpec(InstantEffectSpec original)
		{
			NeedId = original.NeedId;
			Points = original.Points;
		}

		public InstantEffectSpec()
		{
		}
	}
}
