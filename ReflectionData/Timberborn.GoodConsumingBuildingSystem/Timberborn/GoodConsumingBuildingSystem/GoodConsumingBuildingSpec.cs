using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GoodConsumingBuildingSystem
{
	internal record GoodConsumingBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodConsumingBuildingSpec);
			}
		}

		[Serialize]
		public int FullInventoryWorkHours { get; init; }

		[Serialize]
		public ImmutableArray<ConsumedGoodSpec> ConsumedGoods { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodConsumingBuildingSpec");
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
			builder.Append("FullInventoryWorkHours = ");
			builder.Append(FullInventoryWorkHours.ToString());
			builder.Append(", ConsumedGoods = ");
			builder.Append(ConsumedGoods.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FullInventoryWorkHours)) * -1521134295 + EqualityComparer<ImmutableArray<ConsumedGoodSpec>>.Default.GetHashCode(ConsumedGoods);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodConsumingBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(FullInventoryWorkHours, other!.FullInventoryWorkHours))
				{
					return EqualityComparer<ImmutableArray<ConsumedGoodSpec>>.Default.Equals(ConsumedGoods, other!.ConsumedGoods);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodConsumingBuildingSpec(GoodConsumingBuildingSpec original)
			: base(original)
		{
			FullInventoryWorkHours = original.FullInventoryWorkHours;
			ConsumedGoods = original.ConsumedGoods;
		}

		public GoodConsumingBuildingSpec()
		{
		}
	}
}
