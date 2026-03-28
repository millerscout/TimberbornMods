using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GameSound
{
	internal record MusicSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MusicSpec);
			}
		}

		[Serialize]
		public string DroughtTrack { get; init; }

		[Serialize]
		public string StandardTrack { get; init; }

		[Serialize]
		public string StandardPhrase { get; init; }

		[Serialize]
		public float MinDelay { get; init; }

		[Serialize]
		public float MaxDelay { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MusicSpec");
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
			builder.Append("DroughtTrack = ");
			builder.Append((object)DroughtTrack);
			builder.Append(", StandardTrack = ");
			builder.Append((object)StandardTrack);
			builder.Append(", StandardPhrase = ");
			builder.Append((object)StandardPhrase);
			builder.Append(", MinDelay = ");
			builder.Append(MinDelay.ToString());
			builder.Append(", MaxDelay = ");
			builder.Append(MaxDelay.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DroughtTrack)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StandardTrack)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StandardPhrase)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinDelay)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxDelay);
		}

		[CompilerGenerated]
		public virtual bool Equals(MusicSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(DroughtTrack, other!.DroughtTrack) && EqualityComparer<string>.Default.Equals(StandardTrack, other!.StandardTrack) && EqualityComparer<string>.Default.Equals(StandardPhrase, other!.StandardPhrase) && EqualityComparer<float>.Default.Equals(MinDelay, other!.MinDelay))
				{
					return EqualityComparer<float>.Default.Equals(MaxDelay, other!.MaxDelay);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MusicSpec(MusicSpec original)
			: base(original)
		{
			DroughtTrack = original.DroughtTrack;
			StandardTrack = original.StandardTrack;
			StandardPhrase = original.StandardPhrase;
			MinDelay = original.MinDelay;
			MaxDelay = original.MaxDelay;
		}

		public MusicSpec()
		{
		}
	}
}
