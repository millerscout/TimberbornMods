using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Yielding;

namespace Timberborn.Ruins
{
	internal record RuinSpec : ComponentSpec, IYielderDecorable, IOrderableYielder
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RuinSpec);
			}
		}

		[Serialize]
		public string ModelParentName { get; init; }

		[Serialize]
		public int RuinHeight { get; init; }

		[Serialize]
		public YielderSpec Yielder { get; init; }

		public int Order => RuinHeight;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RuinSpec");
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
			builder.Append("ModelParentName = ");
			builder.Append((object)ModelParentName);
			builder.Append(", RuinHeight = ");
			builder.Append(RuinHeight.ToString());
			builder.Append(", Yielder = ");
			builder.Append(Yielder);
			builder.Append(", Order = ");
			builder.Append(Order.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ModelParentName)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(RuinHeight)) * -1521134295 + EqualityComparer<YielderSpec>.Default.GetHashCode(Yielder);
		}

		[CompilerGenerated]
		public virtual bool Equals(RuinSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(ModelParentName, other!.ModelParentName) && EqualityComparer<int>.Default.Equals(RuinHeight, other!.RuinHeight))
				{
					return EqualityComparer<YielderSpec>.Default.Equals(Yielder, other!.Yielder);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RuinSpec(RuinSpec original)
			: base(original)
		{
			ModelParentName = original.ModelParentName;
			RuinHeight = original.RuinHeight;
			Yielder = original.Yielder;
		}

		public RuinSpec()
		{
		}
	}
}
