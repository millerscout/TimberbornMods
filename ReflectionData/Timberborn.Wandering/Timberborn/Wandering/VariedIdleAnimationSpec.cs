using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Wandering
{
	internal record VariedIdleAnimationSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(VariedIdleAnimationSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> Variants { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("VariedIdleAnimationSpec");
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
			builder.Append("Variants = ");
			builder.Append(Variants.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Variants);
		}

		[CompilerGenerated]
		public virtual bool Equals(VariedIdleAnimationSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Variants, other!.Variants);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected VariedIdleAnimationSpec(VariedIdleAnimationSpec original)
			: base(original)
		{
			Variants = original.Variants;
		}

		public VariedIdleAnimationSpec()
		{
		}
	}
}
