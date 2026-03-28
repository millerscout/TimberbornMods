using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	internal record SlotAnimationSynchronizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SlotAnimationSynchronizerSpec);
			}
		}

		[Serialize]
		public float MaxTimeOffset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SlotAnimationSynchronizerSpec");
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
			builder.Append("MaxTimeOffset = ");
			builder.Append(MaxTimeOffset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxTimeOffset);
		}

		[CompilerGenerated]
		public virtual bool Equals(SlotAnimationSynchronizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(MaxTimeOffset, other!.MaxTimeOffset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SlotAnimationSynchronizerSpec(SlotAnimationSynchronizerSpec original)
			: base(original)
		{
			MaxTimeOffset = original.MaxTimeOffset;
		}

		public SlotAnimationSynchronizerSpec()
		{
		}
	}
}
