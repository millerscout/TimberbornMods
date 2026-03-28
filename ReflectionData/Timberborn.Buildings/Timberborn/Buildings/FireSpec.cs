using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Buildings
{
	internal record FireSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FireSpec);
			}
		}

		[Serialize]
		public string AttachmentId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FireSpec");
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
		public virtual bool Equals(FireSpec? other)
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
		protected FireSpec(FireSpec original)
			: base(original)
		{
			AttachmentId = original.AttachmentId;
		}

		public FireSpec()
		{
		}
	}
}
