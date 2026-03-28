using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Bots
{
	internal record BotColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BotColorsSpec);
			}
		}

		[Serialize]
		public string BotColorId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BotColorsSpec");
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
			builder.Append("BotColorId = ");
			builder.Append((object)BotColorId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BotColorId);
		}

		[CompilerGenerated]
		public virtual bool Equals(BotColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(BotColorId, other!.BotColorId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BotColorsSpec(BotColorsSpec original)
			: base(original)
		{
			BotColorId = original.BotColorId;
		}

		public BotColorsSpec()
		{
		}
	}
}
