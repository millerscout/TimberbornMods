using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine.Audio;

namespace Timberborn.SoundSystem
{
	internal record AudioMixerGroupRetrieverSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AudioMixerGroupRetrieverSpec);
			}
		}

		[Serialize]
		public AssetRef<AudioMixer> AudioMixer { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AudioMixerGroupRetrieverSpec");
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
			builder.Append("AudioMixer = ");
			builder.Append(AudioMixer);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<UnityEngine.Audio.AudioMixer>>.Default.GetHashCode(AudioMixer);
		}

		[CompilerGenerated]
		public virtual bool Equals(AudioMixerGroupRetrieverSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<AssetRef<UnityEngine.Audio.AudioMixer>>.Default.Equals(AudioMixer, other!.AudioMixer);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AudioMixerGroupRetrieverSpec(AudioMixerGroupRetrieverSpec original)
			: base(original)
		{
			AudioMixer = original.AudioMixer;
		}

		public AudioMixerGroupRetrieverSpec()
		{
		}
	}
}
