using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedApplication
{
	internal record DemolishableEffectsSpec : ComponentSpec, INeedEffectsSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DemolishableEffectsSpec);
			}
		}

		[Serialize]
		public ImmutableArray<NeedApplierEffectSpec> Effects { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DemolishableEffectsSpec");
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
			builder.Append("Effects = ");
			builder.Append(Effects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<NeedApplierEffectSpec>>.Default.GetHashCode(Effects);
		}

		[CompilerGenerated]
		public virtual bool Equals(DemolishableEffectsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<NeedApplierEffectSpec>>.Default.Equals(Effects, other!.Effects);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DemolishableEffectsSpec(DemolishableEffectsSpec original)
			: base(original)
		{
			Effects = original.Effects;
		}

		public DemolishableEffectsSpec()
		{
		}
	}
}
