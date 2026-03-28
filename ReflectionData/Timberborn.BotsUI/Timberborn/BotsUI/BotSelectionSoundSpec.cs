using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BotsUI
{
	public record BotSelectionSoundSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BotSelectionSoundSpec);
			}
		}

		[Serialize]
		public string SoundNameKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BotSelectionSoundSpec");
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
			builder.Append("SoundNameKey = ");
			builder.Append((object)SoundNameKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SoundNameKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(BotSelectionSoundSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(SoundNameKey, other!.SoundNameKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BotSelectionSoundSpec(BotSelectionSoundSpec original)
			: base(original)
		{
			SoundNameKey = original.SoundNameKey;
		}

		public BotSelectionSoundSpec()
		{
		}
	}
}
