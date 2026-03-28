using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WellbeingUI
{
	internal record WellbeingBonusesSubjectSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WellbeingBonusesSubjectSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> Bonuses { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WellbeingBonusesSubjectSpec");
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
			builder.Append("Bonuses = ");
			builder.Append(Bonuses.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Bonuses);
		}

		[CompilerGenerated]
		public virtual bool Equals(WellbeingBonusesSubjectSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Bonuses, other!.Bonuses);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WellbeingBonusesSubjectSpec(WellbeingBonusesSubjectSpec original)
			: base(original)
		{
			Bonuses = original.Bonuses;
		}

		public WellbeingBonusesSubjectSpec()
		{
		}
	}
}
