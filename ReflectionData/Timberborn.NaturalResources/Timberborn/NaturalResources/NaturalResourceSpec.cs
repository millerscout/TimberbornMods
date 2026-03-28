using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.TemplateSystem;
using Timberborn.Yielding;

namespace Timberborn.NaturalResources
{
	public record NaturalResourceSpec : ComponentSpec, IOrderableYielder
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NaturalResourceSpec);
			}
		}

		[Serialize]
		public int Order { get; init; }

		public bool UsableWithCurrentFeatureToggles => GetSpec<TemplateSpec>().UsableWithCurrentFeatureToggles;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NaturalResourceSpec");
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
			builder.Append(", UsableWithCurrentFeatureToggles = ");
			builder.Append(UsableWithCurrentFeatureToggles.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order);
		}

		[CompilerGenerated]
		public virtual bool Equals(NaturalResourceSpec? other)
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
		protected NaturalResourceSpec(NaturalResourceSpec original)
			: base(original)
		{
			Order = original.Order;
		}

		public NaturalResourceSpec()
		{
		}
	}
}
