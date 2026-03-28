using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkerOutfitSystem
{
	internal record WorkerOutfitAnimationAttachmentSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WorkerOutfitAnimationAttachmentSpec);
			}
		}

		[Serialize]
		public string WorkerOutfit { get; init; }

		[Serialize]
		public ImmutableArray<string> AnimationNames { get; init; }

		[Serialize]
		public ImmutableArray<string> ShowWhenActive { get; init; }

		[Serialize]
		public ImmutableArray<string> HideWhenActive { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WorkerOutfitAnimationAttachmentSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("WorkerOutfit = ");
			builder.Append((object)WorkerOutfit);
			builder.Append(", AnimationNames = ");
			builder.Append(AnimationNames.ToString());
			builder.Append(", ShowWhenActive = ");
			builder.Append(ShowWhenActive.ToString());
			builder.Append(", HideWhenActive = ");
			builder.Append(HideWhenActive.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WorkerOutfit)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(AnimationNames)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(ShowWhenActive)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(HideWhenActive);
		}

		[CompilerGenerated]
		public virtual bool Equals(WorkerOutfitAnimationAttachmentSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(WorkerOutfit, other!.WorkerOutfit) && EqualityComparer<ImmutableArray<string>>.Default.Equals(AnimationNames, other!.AnimationNames) && EqualityComparer<ImmutableArray<string>>.Default.Equals(ShowWhenActive, other!.ShowWhenActive))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(HideWhenActive, other!.HideWhenActive);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WorkerOutfitAnimationAttachmentSpec(WorkerOutfitAnimationAttachmentSpec original)
		{
			WorkerOutfit = original.WorkerOutfit;
			AnimationNames = original.AnimationNames;
			ShowWhenActive = original.ShowWhenActive;
			HideWhenActive = original.HideWhenActive;
		}

		public WorkerOutfitAnimationAttachmentSpec()
		{
		}
	}
}
