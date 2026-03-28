using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedApplication
{
	internal record AreaNeedApplierSpec : ComponentSpec, INeedEffectsSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AreaNeedApplierSpec);
			}
		}

		[Serialize]
		public int ApplicationRadius { get; init; }

		[Serialize]
		public ImmutableArray<NeedApplierEffectSpec> Effects { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AreaNeedApplierSpec");
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
			builder.Append("ApplicationRadius = ");
			builder.Append(ApplicationRadius.ToString());
			builder.Append(", Effects = ");
			builder.Append(Effects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ApplicationRadius)) * -1521134295 + EqualityComparer<ImmutableArray<NeedApplierEffectSpec>>.Default.GetHashCode(Effects);
		}

		[CompilerGenerated]
		public virtual bool Equals(AreaNeedApplierSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(ApplicationRadius, other!.ApplicationRadius))
				{
					return EqualityComparer<ImmutableArray<NeedApplierEffectSpec>>.Default.Equals(Effects, other!.Effects);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AreaNeedApplierSpec(AreaNeedApplierSpec original)
			: base(original)
		{
			ApplicationRadius = original.ApplicationRadius;
			Effects = original.Effects;
		}

		public AreaNeedApplierSpec()
		{
		}
	}
}
