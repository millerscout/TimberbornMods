using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Carrying
{
	internal record GoodCarrierModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodCarrierModelSpec);
			}
		}

		[Serialize]
		public string CarriedInHandsAttachmentName { get; init; }

		[Serialize]
		public string BackpackAttachmentName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodCarrierModelSpec");
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
			builder.Append("CarriedInHandsAttachmentName = ");
			builder.Append((object)CarriedInHandsAttachmentName);
			builder.Append(", BackpackAttachmentName = ");
			builder.Append((object)BackpackAttachmentName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CarriedInHandsAttachmentName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BackpackAttachmentName);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodCarrierModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(CarriedInHandsAttachmentName, other!.CarriedInHandsAttachmentName))
				{
					return EqualityComparer<string>.Default.Equals(BackpackAttachmentName, other!.BackpackAttachmentName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodCarrierModelSpec(GoodCarrierModelSpec original)
			: base(original)
		{
			CarriedInHandsAttachmentName = original.CarriedInHandsAttachmentName;
			BackpackAttachmentName = original.BackpackAttachmentName;
		}

		public GoodCarrierModelSpec()
		{
		}
	}
}
