using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Wellbeing
{
	internal record WellbeingTierSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WellbeingTierSpec);
			}
		}

		[Serialize]
		public string CharacterType { get; init; }

		[Serialize]
		public string BonusId { get; init; }

		[Serialize]
		public ImmutableArray<WellbeingTierBonusSpec> Bonuses { get; init; }

		[Serialize]
		public int WellbeingThreshold { get; init; }

		[Serialize]
		public float MultiplierIncrement { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WellbeingTierSpec");
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
			builder.Append("CharacterType = ");
			builder.Append((object)CharacterType);
			builder.Append(", BonusId = ");
			builder.Append((object)BonusId);
			builder.Append(", Bonuses = ");
			builder.Append(Bonuses.ToString());
			builder.Append(", WellbeingThreshold = ");
			builder.Append(WellbeingThreshold.ToString());
			builder.Append(", MultiplierIncrement = ");
			builder.Append(MultiplierIncrement.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CharacterType)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BonusId)) * -1521134295 + EqualityComparer<ImmutableArray<WellbeingTierBonusSpec>>.Default.GetHashCode(Bonuses)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(WellbeingThreshold)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MultiplierIncrement);
		}

		[CompilerGenerated]
		public virtual bool Equals(WellbeingTierSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(CharacterType, other!.CharacterType) && EqualityComparer<string>.Default.Equals(BonusId, other!.BonusId) && EqualityComparer<ImmutableArray<WellbeingTierBonusSpec>>.Default.Equals(Bonuses, other!.Bonuses) && EqualityComparer<int>.Default.Equals(WellbeingThreshold, other!.WellbeingThreshold))
				{
					return EqualityComparer<float>.Default.Equals(MultiplierIncrement, other!.MultiplierIncrement);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WellbeingTierSpec(WellbeingTierSpec original)
			: base(original)
		{
			CharacterType = original.CharacterType;
			BonusId = original.BonusId;
			Bonuses = original.Bonuses;
			WellbeingThreshold = original.WellbeingThreshold;
			MultiplierIncrement = original.MultiplierIncrement;
		}

		public WellbeingTierSpec()
		{
		}
	}
}
