using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Yielding;

namespace Timberborn.Gathering
{
	public record GatherableSpec : ComponentSpec, IYielderDecorable
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GatherableSpec);
			}
		}

		[Serialize]
		public float YieldGrowthTimeInDays { get; init; }

		[Serialize]
		public YielderSpec Yielder { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GatherableSpec");
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
			builder.Append("YieldGrowthTimeInDays = ");
			builder.Append(YieldGrowthTimeInDays.ToString());
			builder.Append(", Yielder = ");
			builder.Append(Yielder);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(YieldGrowthTimeInDays)) * -1521134295 + EqualityComparer<YielderSpec>.Default.GetHashCode(Yielder);
		}

		[CompilerGenerated]
		public virtual bool Equals(GatherableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(YieldGrowthTimeInDays, other!.YieldGrowthTimeInDays))
				{
					return EqualityComparer<YielderSpec>.Default.Equals(Yielder, other!.Yielder);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GatherableSpec(GatherableSpec original)
			: base(original)
		{
			YieldGrowthTimeInDays = original.YieldGrowthTimeInDays;
			Yielder = original.Yielder;
		}

		public GatherableSpec()
		{
		}
	}
}
