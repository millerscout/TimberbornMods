using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedSpecs
{
	public record BonusEffectivenessMultiplierSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BonusEffectivenessMultiplierSpec);
			}
		}

		[Serialize]
		public string BonusId { get; init; }

		[Serialize]
		public float EffectivenessMultiplier { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BonusEffectivenessMultiplierSpec");
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
			builder.Append("BonusId = ");
			builder.Append((object)BonusId);
			builder.Append(", EffectivenessMultiplier = ");
			builder.Append(EffectivenessMultiplier.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BonusId)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(EffectivenessMultiplier);
		}

		[CompilerGenerated]
		public virtual bool Equals(BonusEffectivenessMultiplierSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(BonusId, other!.BonusId))
				{
					return EqualityComparer<float>.Default.Equals(EffectivenessMultiplier, other!.EffectivenessMultiplier);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BonusEffectivenessMultiplierSpec(BonusEffectivenessMultiplierSpec original)
		{
			BonusId = original.BonusId;
			EffectivenessMultiplier = original.EffectivenessMultiplier;
		}

		public BonusEffectivenessMultiplierSpec()
		{
		}
	}
}
