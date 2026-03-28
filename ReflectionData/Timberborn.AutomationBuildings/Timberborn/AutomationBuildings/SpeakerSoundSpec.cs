using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.AutomationBuildings
{
	internal record SpeakerSoundSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SpeakerSoundSpec);
			}
		}

		[Serialize]
		public string SoundId { get; init; }

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		private string DisplayNameLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SpeakerSoundSpec");
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
			builder.Append("SoundId = ");
			builder.Append((object)SoundId);
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SoundId)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(SpeakerSoundSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(SoundId, other!.SoundId) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName))
				{
					return EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SpeakerSoundSpec(SpeakerSoundSpec original)
			: base(original)
		{
			SoundId = original.SoundId;
			DisplayName = original.DisplayName;
			DisplayNameLocKey = original.DisplayNameLocKey;
		}

		public SpeakerSoundSpec()
		{
		}
	}
}
