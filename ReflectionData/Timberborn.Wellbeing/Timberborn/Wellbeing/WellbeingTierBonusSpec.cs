using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Wellbeing
{
	internal record WellbeingTierBonusSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WellbeingTierBonusSpec);
			}
		}

		[Serialize]
		public int Wellbeing { get; init; }

		[Serialize]
		public float Multiplier { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WellbeingTierBonusSpec");
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
			builder.Append("Wellbeing = ");
			builder.Append(Wellbeing.ToString());
			builder.Append(", Multiplier = ");
			builder.Append(Multiplier.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Wellbeing)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Multiplier);
		}

		[CompilerGenerated]
		public virtual bool Equals(WellbeingTierBonusSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<int>.Default.Equals(Wellbeing, other!.Wellbeing))
				{
					return EqualityComparer<float>.Default.Equals(Multiplier, other!.Multiplier);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WellbeingTierBonusSpec(WellbeingTierBonusSpec original)
		{
			Wellbeing = original.Wellbeing;
			Multiplier = original.Multiplier;
		}

		public WellbeingTierBonusSpec()
		{
		}
	}
}
