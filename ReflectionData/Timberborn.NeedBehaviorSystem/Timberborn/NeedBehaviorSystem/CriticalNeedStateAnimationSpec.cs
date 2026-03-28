using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedBehaviorSystem
{
	internal record CriticalNeedStateAnimationSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CriticalNeedStateAnimationSpec);
			}
		}

		[Serialize]
		public string NeedId { get; init; }

		[Serialize]
		public string Animation { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CriticalNeedStateAnimationSpec");
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
			builder.Append("NeedId = ");
			builder.Append((object)NeedId);
			builder.Append(", Animation = ");
			builder.Append((object)Animation);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NeedId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Animation);
		}

		[CompilerGenerated]
		public virtual bool Equals(CriticalNeedStateAnimationSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(NeedId, other!.NeedId))
				{
					return EqualityComparer<string>.Default.Equals(Animation, other!.Animation);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CriticalNeedStateAnimationSpec(CriticalNeedStateAnimationSpec original)
			: base(original)
		{
			NeedId = original.NeedId;
			Animation = original.Animation;
		}

		public CriticalNeedStateAnimationSpec()
		{
		}
	}
}
