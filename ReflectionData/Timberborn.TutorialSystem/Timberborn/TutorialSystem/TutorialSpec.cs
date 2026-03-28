using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Common;
using Timberborn.LocalizationSerialization;

namespace Timberborn.TutorialSystem
{
	internal record TutorialSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TutorialSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize("NameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		public string NameLocKey { get; init; }

		[Serialize]
		public ImmutableArray<string> RequiredTutorialIds { get; init; }

		[BackwardCompatible(2026, 1, 15, Compatibility.Save)]
		[Serialize]
		public string SkipIfTutorialFinished { get; init; }

		[Serialize]
		public int SortOrder { get; init; }

		[Serialize]
		public ImmutableArray<string> Stages { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TutorialSpec");
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
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", NameLocKey = ");
			builder.Append((object)NameLocKey);
			builder.Append(", RequiredTutorialIds = ");
			builder.Append(RequiredTutorialIds.ToString());
			builder.Append(", SkipIfTutorialFinished = ");
			builder.Append((object)SkipIfTutorialFinished);
			builder.Append(", SortOrder = ");
			builder.Append(SortOrder.ToString());
			builder.Append(", Stages = ");
			builder.Append(Stages.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NameLocKey)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(RequiredTutorialIds)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SkipIfTutorialFinished)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SortOrder)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Stages);
		}

		[CompilerGenerated]
		public virtual bool Equals(TutorialSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<string>.Default.Equals(NameLocKey, other!.NameLocKey) && EqualityComparer<ImmutableArray<string>>.Default.Equals(RequiredTutorialIds, other!.RequiredTutorialIds) && EqualityComparer<string>.Default.Equals(SkipIfTutorialFinished, other!.SkipIfTutorialFinished) && EqualityComparer<int>.Default.Equals(SortOrder, other!.SortOrder))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Stages, other!.Stages);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TutorialSpec(TutorialSpec original)
			: base(original)
		{
			Id = original.Id;
			DisplayName = original.DisplayName;
			NameLocKey = original.NameLocKey;
			RequiredTutorialIds = original.RequiredTutorialIds;
			SkipIfTutorialFinished = original.SkipIfTutorialFinished;
			SortOrder = original.SortOrder;
			Stages = original.Stages;
		}

		public TutorialSpec()
		{
		}
	}
}
