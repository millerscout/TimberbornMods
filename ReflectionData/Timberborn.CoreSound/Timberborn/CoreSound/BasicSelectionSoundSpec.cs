using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CoreSound
{
	internal record BasicSelectionSoundSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BasicSelectionSoundSpec);
			}
		}

		[Serialize]
		public string SoundName { get; init; }

		[Serialize]
		public string AlternativeSoundName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BasicSelectionSoundSpec");
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
			builder.Append("SoundName = ");
			builder.Append((object)SoundName);
			builder.Append(", AlternativeSoundName = ");
			builder.Append((object)AlternativeSoundName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SoundName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AlternativeSoundName);
		}

		[CompilerGenerated]
		public virtual bool Equals(BasicSelectionSoundSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(SoundName, other!.SoundName))
				{
					return EqualityComparer<string>.Default.Equals(AlternativeSoundName, other!.AlternativeSoundName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BasicSelectionSoundSpec(BasicSelectionSoundSpec original)
			: base(original)
		{
			SoundName = original.SoundName;
			AlternativeSoundName = original.AlternativeSoundName;
		}

		public BasicSelectionSoundSpec()
		{
		}
	}
}
