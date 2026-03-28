using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	internal record UnfinishedStateSlotDisablerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UnfinishedStateSlotDisablerSpec);
			}
		}

		[Serialize]
		public string SlotKeyword { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UnfinishedStateSlotDisablerSpec");
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
			builder.Append("SlotKeyword = ");
			builder.Append((object)SlotKeyword);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SlotKeyword);
		}

		[CompilerGenerated]
		public virtual bool Equals(UnfinishedStateSlotDisablerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(SlotKeyword, other!.SlotKeyword);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UnfinishedStateSlotDisablerSpec(UnfinishedStateSlotDisablerSpec original)
			: base(original)
		{
			SlotKeyword = original.SlotKeyword;
		}

		public UnfinishedStateSlotDisablerSpec()
		{
		}
	}
}
