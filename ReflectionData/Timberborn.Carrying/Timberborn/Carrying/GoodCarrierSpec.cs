using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Carrying
{
	internal record GoodCarrierSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodCarrierSpec);
			}
		}

		[Serialize]
		public int BaseLiftingCapacity { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodCarrierSpec");
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
			builder.Append("BaseLiftingCapacity = ");
			builder.Append(BaseLiftingCapacity.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BaseLiftingCapacity);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodCarrierSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(BaseLiftingCapacity, other!.BaseLiftingCapacity);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodCarrierSpec(GoodCarrierSpec original)
			: base(original)
		{
			BaseLiftingCapacity = original.BaseLiftingCapacity;
		}

		public GoodCarrierSpec()
		{
		}
	}
}
