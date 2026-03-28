using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GameSceneLoading
{
	internal record GameTipSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GameTipSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> Tips { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GameTipSpec");
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
			builder.Append("Tips = ");
			builder.Append(Tips.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Tips);
		}

		[CompilerGenerated]
		public virtual bool Equals(GameTipSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Tips, other!.Tips);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GameTipSpec(GameTipSpec original)
			: base(original)
		{
			Tips = original.Tips;
		}

		public GameTipSpec()
		{
		}
	}
}
