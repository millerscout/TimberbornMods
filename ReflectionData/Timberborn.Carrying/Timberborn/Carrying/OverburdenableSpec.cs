using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.BonusSystem;

namespace Timberborn.Carrying
{
	internal record OverburdenableSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(OverburdenableSpec);
			}
		}

		[Serialize]
		public ImmutableArray<BonusSpec> OverburdenedBonuses { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("OverburdenableSpec");
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
			builder.Append("OverburdenedBonuses = ");
			builder.Append(OverburdenedBonuses.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<BonusSpec>>.Default.GetHashCode(OverburdenedBonuses);
		}

		[CompilerGenerated]
		public virtual bool Equals(OverburdenableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<BonusSpec>>.Default.Equals(OverburdenedBonuses, other!.OverburdenedBonuses);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected OverburdenableSpec(OverburdenableSpec original)
			: base(original)
		{
			OverburdenedBonuses = original.OverburdenedBonuses;
		}

		public OverburdenableSpec()
		{
		}
	}
}
