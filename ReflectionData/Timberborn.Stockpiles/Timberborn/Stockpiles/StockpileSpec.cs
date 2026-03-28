using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Stockpiles
{
	public record StockpileSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StockpileSpec);
			}
		}

		[Serialize]
		public int MaxCapacity { get; init; }

		[Serialize]
		public string WhitelistedGoodType { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StockpileSpec");
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
			builder.Append("MaxCapacity = ");
			builder.Append(MaxCapacity.ToString());
			builder.Append(", WhitelistedGoodType = ");
			builder.Append((object)WhitelistedGoodType);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxCapacity)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WhitelistedGoodType);
		}

		[CompilerGenerated]
		public virtual bool Equals(StockpileSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MaxCapacity, other!.MaxCapacity))
				{
					return EqualityComparer<string>.Default.Equals(WhitelistedGoodType, other!.WhitelistedGoodType);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected StockpileSpec(StockpileSpec original)
			: base(original)
		{
			MaxCapacity = original.MaxCapacity;
			WhitelistedGoodType = original.WhitelistedGoodType;
		}

		public StockpileSpec()
		{
		}
	}
}
