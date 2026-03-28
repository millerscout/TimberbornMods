using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	internal record PrioritySlotRetrieverSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PrioritySlotRetrieverSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> PrioritySlotNames { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PrioritySlotRetrieverSpec");
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
			builder.Append("PrioritySlotNames = ");
			builder.Append(PrioritySlotNames.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(PrioritySlotNames);
		}

		[CompilerGenerated]
		public virtual bool Equals(PrioritySlotRetrieverSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(PrioritySlotNames, other!.PrioritySlotNames);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PrioritySlotRetrieverSpec(PrioritySlotRetrieverSpec original)
			: base(original)
		{
			PrioritySlotNames = original.PrioritySlotNames;
		}

		public PrioritySlotRetrieverSpec()
		{
		}
	}
}
