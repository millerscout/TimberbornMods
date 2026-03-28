using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GameSound
{
	internal record GameUISoundSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GameUISoundSpec);
			}
		}

		[Serialize]
		public string WellbeingHighscore { get; init; }

		[Serialize]
		public string FieldPlaced { get; init; }

		[Serialize]
		public string BlinkingSoundKey { get; init; }

		[Serialize]
		public string BadtideStartedSoundKey { get; init; }

		[Serialize]
		public string DroughtStartedSoundKey { get; init; }

		[Serialize]
		public string TemperateWeatherStartedSoundKey { get; init; }

		[Serialize]
		public string WonderCongratulationSoundKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GameUISoundSpec");
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
			builder.Append("WellbeingHighscore = ");
			builder.Append((object)WellbeingHighscore);
			builder.Append(", FieldPlaced = ");
			builder.Append((object)FieldPlaced);
			builder.Append(", BlinkingSoundKey = ");
			builder.Append((object)BlinkingSoundKey);
			builder.Append(", BadtideStartedSoundKey = ");
			builder.Append((object)BadtideStartedSoundKey);
			builder.Append(", DroughtStartedSoundKey = ");
			builder.Append((object)DroughtStartedSoundKey);
			builder.Append(", TemperateWeatherStartedSoundKey = ");
			builder.Append((object)TemperateWeatherStartedSoundKey);
			builder.Append(", WonderCongratulationSoundKey = ");
			builder.Append((object)WonderCongratulationSoundKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WellbeingHighscore)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FieldPlaced)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BlinkingSoundKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BadtideStartedSoundKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DroughtStartedSoundKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TemperateWeatherStartedSoundKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WonderCongratulationSoundKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(GameUISoundSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(WellbeingHighscore, other!.WellbeingHighscore) && EqualityComparer<string>.Default.Equals(FieldPlaced, other!.FieldPlaced) && EqualityComparer<string>.Default.Equals(BlinkingSoundKey, other!.BlinkingSoundKey) && EqualityComparer<string>.Default.Equals(BadtideStartedSoundKey, other!.BadtideStartedSoundKey) && EqualityComparer<string>.Default.Equals(DroughtStartedSoundKey, other!.DroughtStartedSoundKey) && EqualityComparer<string>.Default.Equals(TemperateWeatherStartedSoundKey, other!.TemperateWeatherStartedSoundKey))
				{
					return EqualityComparer<string>.Default.Equals(WonderCongratulationSoundKey, other!.WonderCongratulationSoundKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GameUISoundSpec(GameUISoundSpec original)
			: base(original)
		{
			WellbeingHighscore = original.WellbeingHighscore;
			FieldPlaced = original.FieldPlaced;
			BlinkingSoundKey = original.BlinkingSoundKey;
			BadtideStartedSoundKey = original.BadtideStartedSoundKey;
			DroughtStartedSoundKey = original.DroughtStartedSoundKey;
			TemperateWeatherStartedSoundKey = original.TemperateWeatherStartedSoundKey;
			WonderCongratulationSoundKey = original.WonderCongratulationSoundKey;
		}

		public GameUISoundSpec()
		{
		}
	}
}
