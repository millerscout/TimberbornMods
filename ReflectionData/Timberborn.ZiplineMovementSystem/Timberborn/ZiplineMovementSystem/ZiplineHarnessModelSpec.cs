using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ZiplineMovementSystem
{
	internal record ZiplineHarnessModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ZiplineHarnessModelSpec);
			}
		}

		[Serialize]
		public string AttachmentId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ZiplineHarnessModelSpec");
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
			builder.Append("AttachmentId = ");
			builder.Append((object)AttachmentId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AttachmentId);
		}

		[CompilerGenerated]
		public virtual bool Equals(ZiplineHarnessModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(AttachmentId, other!.AttachmentId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ZiplineHarnessModelSpec(ZiplineHarnessModelSpec original)
			: base(original)
		{
			AttachmentId = original.AttachmentId;
		}

		public ZiplineHarnessModelSpec()
		{
		}
	}
}
