using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedApplication
{
	internal record YieldRemoverWorkplaceEffectsSpec : ComponentSpec, INeedEffectsSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(YieldRemoverWorkplaceEffectsSpec);
			}
		}

		[Serialize]
		public string YieldGoodId { get; init; }

		[Serialize]
		public int MinimumAttemptsThreshold { get; init; }

		[Serialize]
		public ImmutableArray<NeedApplierEffectSpec> Effects { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("YieldRemoverWorkplaceEffectsSpec");
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
			builder.Append("YieldGoodId = ");
			builder.Append((object)YieldGoodId);
			builder.Append(", MinimumAttemptsThreshold = ");
			builder.Append(MinimumAttemptsThreshold.ToString());
			builder.Append(", Effects = ");
			builder.Append(Effects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(YieldGoodId)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MinimumAttemptsThreshold)) * -1521134295 + EqualityComparer<ImmutableArray<NeedApplierEffectSpec>>.Default.GetHashCode(Effects);
		}

		[CompilerGenerated]
		public virtual bool Equals(YieldRemoverWorkplaceEffectsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(YieldGoodId, other!.YieldGoodId) && EqualityComparer<int>.Default.Equals(MinimumAttemptsThreshold, other!.MinimumAttemptsThreshold))
				{
					return EqualityComparer<ImmutableArray<NeedApplierEffectSpec>>.Default.Equals(Effects, other!.Effects);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected YieldRemoverWorkplaceEffectsSpec(YieldRemoverWorkplaceEffectsSpec original)
			: base(original)
		{
			YieldGoodId = original.YieldGoodId;
			MinimumAttemptsThreshold = original.MinimumAttemptsThreshold;
			Effects = original.Effects;
		}

		public YieldRemoverWorkplaceEffectsSpec()
		{
		}
	}
}
