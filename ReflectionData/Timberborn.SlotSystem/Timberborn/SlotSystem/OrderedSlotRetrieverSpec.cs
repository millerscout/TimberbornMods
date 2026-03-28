using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using JetBrains.Annotations;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	[UsedImplicitly]
	internal record OrderedSlotRetrieverSpec : ComponentSpec, ICustomSlotRetriever
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(OrderedSlotRetrieverSpec);
			}
		}

		public bool TryGetUnassignedSlot(IEnumerable<ISlot> slots, out ISlot slot)
		{
			foreach (ISlot slot2 in slots)
			{
				if (!slot2.AssignedEnterer)
				{
					slot = slot2;
					return true;
				}
			}
			slot = null;
			return false;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("OrderedSlotRetrieverSpec");
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
			return base.PrintMembers(builder);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[CompilerGenerated]
		public virtual bool Equals(OrderedSlotRetrieverSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected OrderedSlotRetrieverSpec(OrderedSlotRetrieverSpec original)
			: base(original)
		{
		}

		public OrderedSlotRetrieverSpec()
		{
		}
	}
}
