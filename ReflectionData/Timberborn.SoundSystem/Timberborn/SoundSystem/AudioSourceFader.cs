using System.Collections.Generic;
using Timberborn.SingletonSystem;
using UnityEngine;

namespace Timberborn.SoundSystem
{
	internal class AudioSourceFader : IUpdatableSingleton
	{
		private static readonly float FadeLengthInSeconds = 3f;

		private readonly Dictionary<AudioSource, AudioSourceFade> _audioSourceFades = new Dictionary<AudioSource, AudioSourceFade>();

		private readonly List<AudioSource> _fadesToRemove = new List<AudioSource>();

		public void UpdateSingleton()
		{
			ProgressFades();
			RemoveFinished();
		}

		public void FadeIn(AudioSource audioSource, float delay)
		{
			_audioSourceFades[audioSource] = AudioSourceFade.FadeIn(delay, FadeLengthInSeconds);
		}

		public void FadeOut(AudioSource audioSource)
		{
			_audioSourceFades[audioSource] = AudioSourceFade.FadeOut(FadeLengthInSeconds);
		}

		public void RemoveFaders(AudioSource audioSource)
		{
			_audioSourceFades.Remove(audioSource);
		}

		private void ProgressFades()
		{
			foreach (KeyValuePair<AudioSource, AudioSourceFade> audioSourceFade2 in _audioSourceFades)
			{
				audioSourceFade2.Deconstruct(out var key, out var value);
				AudioSource audioSource = key;
				AudioSourceFade audioSourceFade = value;
				if (audioSourceFade.DelayEndTime < Time.unscaledTime)
				{
					if ((bool)audioSource && audioSourceFade.FadeEndTime > Time.unscaledTime)
					{
						ProgressFade(audioSource, audioSourceFade);
					}
					else
					{
						EndFade(audioSource, audioSourceFade);
					}
				}
			}
		}

		private static void ProgressFade(AudioSource audioSource, AudioSourceFade audioSourceFade)
		{
			float num = FadeLengthInSeconds - (audioSourceFade.FadeEndTime - Time.unscaledTime);
			audioSource.volume = Mathf.Lerp(audioSource.volume, audioSourceFade.TargetVolume, num / FadeLengthInSeconds);
		}

		private void EndFade(AudioSource audioSource, AudioSourceFade audioSourceFade)
		{
			if ((bool)audioSource)
			{
				audioSource.volume = audioSourceFade.TargetVolume;
			}
			_fadesToRemove.Add(audioSource);
		}

		private void RemoveFinished()
		{
			foreach (AudioSource item in _fadesToRemove)
			{
				_audioSourceFades.Remove(item);
			}
			_fadesToRemove.Clear();
		}
	}
}
