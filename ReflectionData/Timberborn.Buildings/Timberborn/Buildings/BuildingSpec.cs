using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Goods;

namespace Timberborn.Buildings
{
	public record BuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildingSpec);
			}
		}

		[Serialize]
		public string SelectionSoundName { get; init; }

		[Serialize]
		public string LoopingSoundName { get; init; }

		[Serialize]
		public ImmutableArray<GoodAmountSpec> BuildingCost { get; init; }

		[Serialize]
		public int ScienceCost { get; init; }

		[Serialize]
		public bool PlaceFinished { get; init; }

		[Serialize]
		public bool FinishableWithBeaversOnSite { get; init; }

		[Serialize]
		public bool DrawRangeBoundsOnIt { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildingSpec");
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
			builder.Append("SelectionSoundName = ");
			builder.Append((object)SelectionSoundName);
			builder.Append(", LoopingSoundName = ");
			builder.Append((object)LoopingSoundName);
			builder.Append(", BuildingCost = ");
			builder.Append(BuildingCost.ToString());
			builder.Append(", ScienceCost = ");
			builder.Append(ScienceCost.ToString());
			builder.Append(", PlaceFinished = ");
			builder.Append(PlaceFinished.ToString());
			builder.Append(", FinishableWithBeaversOnSite = ");
			builder.Append(FinishableWithBeaversOnSite.ToString());
			builder.Append(", DrawRangeBoundsOnIt = ");
			builder.Append(DrawRangeBoundsOnIt.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SelectionSoundName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LoopingSoundName)) * -1521134295 + EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.GetHashCode(BuildingCost)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ScienceCost)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(PlaceFinished)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(FinishableWithBeaversOnSite)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DrawRangeBoundsOnIt);
		}

		[CompilerGenerated]
		public virtual bool Equals(BuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(SelectionSoundName, other!.SelectionSoundName) && EqualityComparer<string>.Default.Equals(LoopingSoundName, other!.LoopingSoundName) && EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.Equals(BuildingCost, other!.BuildingCost) && EqualityComparer<int>.Default.Equals(ScienceCost, other!.ScienceCost) && EqualityComparer<bool>.Default.Equals(PlaceFinished, other!.PlaceFinished) && EqualityComparer<bool>.Default.Equals(FinishableWithBeaversOnSite, other!.FinishableWithBeaversOnSite))
				{
					return EqualityComparer<bool>.Default.Equals(DrawRangeBoundsOnIt, other!.DrawRangeBoundsOnIt);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BuildingSpec(BuildingSpec original)
			: base(original)
		{
			SelectionSoundName = original.SelectionSoundName;
			LoopingSoundName = original.LoopingSoundName;
			BuildingCost = original.BuildingCost;
			ScienceCost = original.ScienceCost;
			PlaceFinished = original.PlaceFinished;
			FinishableWithBeaversOnSite = original.FinishableWithBeaversOnSite;
			DrawRangeBoundsOnIt = original.DrawRangeBoundsOnIt;
		}

		public BuildingSpec()
		{
			SelectionSoundName = "Default";
			base._002Ector();
		}
	}
}
