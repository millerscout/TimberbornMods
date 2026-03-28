using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.TutorialSystem
{
	internal record TutorialStageSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TutorialStageSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize("IntroLocKey")]
		public LocalizedText Intro { get; init; }

		[Serialize]
		public string IntroLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TutorialStageSpec");
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
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", Intro = ");
			builder.Append(Intro);
			builder.Append(", IntroLocKey = ");
			builder.Append((object)IntroLocKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(Intro)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IntroLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(TutorialStageSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<LocalizedText>.Default.Equals(Intro, other!.Intro))
				{
					return EqualityComparer<string>.Default.Equals(IntroLocKey, other!.IntroLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TutorialStageSpec(TutorialStageSpec original)
			: base(original)
		{
			Id = original.Id;
			Intro = original.Intro;
			IntroLocKey = original.IntroLocKey;
		}

		public TutorialStageSpec()
		{
		}
	}
}
