using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.BonusSystem;

namespace Timberborn.NeedSpecs
{
	public record PunitiveNeedSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PunitiveNeedSpec);
			}
		}

		[Serialize]
		public ImmutableArray<BonusSpec> Penalties { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PunitiveNeedSpec");
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
			builder.Append("Penalties = ");
			builder.Append(Penalties.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<BonusSpec>>.Default.GetHashCode(Penalties);
		}

		[CompilerGenerated]
		public virtual bool Equals(PunitiveNeedSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<BonusSpec>>.Default.Equals(Penalties, other!.Penalties);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PunitiveNeedSpec(PunitiveNeedSpec original)
			: base(original)
		{
			Penalties = original.Penalties;
		}

		public PunitiveNeedSpec()
		{
		}
	}
}
