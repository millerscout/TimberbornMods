using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Goods;

namespace Timberborn.Reproduction
{
	internal record BreedingPodSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BreedingPodSpec);
			}
		}

		[Serialize]
		public string EmbryoName { get; init; }

		[Serialize]
		public float CycleLengthInDays { get; init; }

		[Serialize]
		public int CyclesUntilFullyGrown { get; init; }

		[Serialize]
		public int CyclesCapacity { get; init; }

		[Serialize]
		public ImmutableArray<GoodAmountSpec> NutrientsPerCycle { get; init; }

		[Serialize]
		public bool SpawnAdults { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BreedingPodSpec");
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
			builder.Append("EmbryoName = ");
			builder.Append((object)EmbryoName);
			builder.Append(", CycleLengthInDays = ");
			builder.Append(CycleLengthInDays.ToString());
			builder.Append(", CyclesUntilFullyGrown = ");
			builder.Append(CyclesUntilFullyGrown.ToString());
			builder.Append(", CyclesCapacity = ");
			builder.Append(CyclesCapacity.ToString());
			builder.Append(", NutrientsPerCycle = ");
			builder.Append(NutrientsPerCycle.ToString());
			builder.Append(", SpawnAdults = ");
			builder.Append(SpawnAdults.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EmbryoName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(CycleLengthInDays)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CyclesUntilFullyGrown)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CyclesCapacity)) * -1521134295 + EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.GetHashCode(NutrientsPerCycle)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(SpawnAdults);
		}

		[CompilerGenerated]
		public virtual bool Equals(BreedingPodSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(EmbryoName, other!.EmbryoName) && EqualityComparer<float>.Default.Equals(CycleLengthInDays, other!.CycleLengthInDays) && EqualityComparer<int>.Default.Equals(CyclesUntilFullyGrown, other!.CyclesUntilFullyGrown) && EqualityComparer<int>.Default.Equals(CyclesCapacity, other!.CyclesCapacity) && EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.Equals(NutrientsPerCycle, other!.NutrientsPerCycle))
				{
					return EqualityComparer<bool>.Default.Equals(SpawnAdults, other!.SpawnAdults);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BreedingPodSpec(BreedingPodSpec original)
			: base(original)
		{
			EmbryoName = original.EmbryoName;
			CycleLengthInDays = original.CycleLengthInDays;
			CyclesUntilFullyGrown = original.CyclesUntilFullyGrown;
			CyclesCapacity = original.CyclesCapacity;
			NutrientsPerCycle = original.NutrientsPerCycle;
			SpawnAdults = original.SpawnAdults;
		}

		public BreedingPodSpec()
		{
		}
	}
}
