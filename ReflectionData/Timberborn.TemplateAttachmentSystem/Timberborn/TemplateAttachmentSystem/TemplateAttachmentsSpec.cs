using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TemplateAttachmentSystem
{
	internal record TemplateAttachmentsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TemplateAttachmentsSpec);
			}
		}

		[Serialize]
		public ImmutableArray<AttachmentDefinition> Attachments { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TemplateAttachmentsSpec");
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
			builder.Append("Attachments = ");
			builder.Append(Attachments.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<AttachmentDefinition>>.Default.GetHashCode(Attachments);
		}

		[CompilerGenerated]
		public virtual bool Equals(TemplateAttachmentsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<AttachmentDefinition>>.Default.Equals(Attachments, other!.Attachments);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TemplateAttachmentsSpec(TemplateAttachmentsSpec original)
			: base(original)
		{
			Attachments = original.Attachments;
		}

		public TemplateAttachmentsSpec()
		{
		}
	}
}
