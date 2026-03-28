using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Illumination
{
	internal record IlluminationPresetSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(IlluminationPresetSpec);
			}
		}

		[Serialize]
		public int Order { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("IlluminationPresetSpec");
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
			builder.Append("Order = ");
			builder.Append(Order.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order);
		}

		[CompilerGenerated]
		public virtual bool Equals(IlluminationPresetSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(Order, other!.Order);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected IlluminationPresetSpec(IlluminationPresetSpec original)
			: base(original)
		{
			Order = original.Order;
		}

		public IlluminationPresetSpec()
		{
		}
	}
}
