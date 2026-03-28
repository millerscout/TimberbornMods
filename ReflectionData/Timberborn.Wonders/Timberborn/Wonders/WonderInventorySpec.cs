using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Goods;

namespace Timberborn.Wonders
{
	internal record WonderInventorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WonderInventorySpec);
			}
		}

		[Serialize]
		public ImmutableArray<GoodAmountSpec> RequiredGoods { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WonderInventorySpec");
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
			builder.Append("RequiredGoods = ");
			builder.Append(RequiredGoods.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.GetHashCode(RequiredGoods);
		}

		[CompilerGenerated]
		public virtual bool Equals(WonderInventorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.Equals(RequiredGoods, other!.RequiredGoods);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WonderInventorySpec(WonderInventorySpec original)
			: base(original)
		{
			RequiredGoods = original.RequiredGoods;
		}

		public WonderInventorySpec()
		{
		}
	}
}
