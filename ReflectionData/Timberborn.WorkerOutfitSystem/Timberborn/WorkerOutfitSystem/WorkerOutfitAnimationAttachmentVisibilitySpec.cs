using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkerOutfitSystem
{
	internal record WorkerOutfitAnimationAttachmentVisibilitySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WorkerOutfitAnimationAttachmentVisibilitySpec);
			}
		}

		[Serialize]
		public ImmutableArray<WorkerOutfitAnimationAttachmentSpec> WorkerOutfitAnimationAttachments { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WorkerOutfitAnimationAttachmentVisibilitySpec");
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
			builder.Append("WorkerOutfitAnimationAttachments = ");
			builder.Append(WorkerOutfitAnimationAttachments.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<WorkerOutfitAnimationAttachmentSpec>>.Default.GetHashCode(WorkerOutfitAnimationAttachments);
		}

		[CompilerGenerated]
		public virtual bool Equals(WorkerOutfitAnimationAttachmentVisibilitySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<WorkerOutfitAnimationAttachmentSpec>>.Default.Equals(WorkerOutfitAnimationAttachments, other!.WorkerOutfitAnimationAttachments);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WorkerOutfitAnimationAttachmentVisibilitySpec(WorkerOutfitAnimationAttachmentVisibilitySpec original)
			: base(original)
		{
			WorkerOutfitAnimationAttachments = original.WorkerOutfitAnimationAttachments;
		}

		public WorkerOutfitAnimationAttachmentVisibilitySpec()
		{
		}
	}
}
