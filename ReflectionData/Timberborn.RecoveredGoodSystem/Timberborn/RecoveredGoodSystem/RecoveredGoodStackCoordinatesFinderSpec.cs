using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.RecoveredGoodSystem
{
	internal record RecoveredGoodStackCoordinatesFinderSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RecoveredGoodStackCoordinatesFinderSpec);
			}
		}

		[Serialize]
		public int NeighboursRange { get; init; }

		[Serialize]
		public int MaxUpperSearch { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RecoveredGoodStackCoordinatesFinderSpec");
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
			builder.Append("NeighboursRange = ");
			builder.Append(NeighboursRange.ToString());
			builder.Append(", MaxUpperSearch = ");
			builder.Append(MaxUpperSearch.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(NeighboursRange)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxUpperSearch);
		}

		[CompilerGenerated]
		public virtual bool Equals(RecoveredGoodStackCoordinatesFinderSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(NeighboursRange, other!.NeighboursRange))
				{
					return EqualityComparer<int>.Default.Equals(MaxUpperSearch, other!.MaxUpperSearch);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RecoveredGoodStackCoordinatesFinderSpec(RecoveredGoodStackCoordinatesFinderSpec original)
			: base(original)
		{
			NeighboursRange = original.NeighboursRange;
			MaxUpperSearch = original.MaxUpperSearch;
		}

		public RecoveredGoodStackCoordinatesFinderSpec()
		{
		}
	}
}
