using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Pollination
{
	internal record HiveSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(HiveSpec);
			}
		}

		[Serialize]
		public int PollinationRadius { get; init; }

		[Serialize]
		public float HoursBetweenPollinations { get; init; }

		[Serialize]
		public float GrowthTimeReduction { get; init; }

		[Serialize]
		public int PlantsPerPollination { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("HiveSpec");
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
			builder.Append("PollinationRadius = ");
			builder.Append(PollinationRadius.ToString());
			builder.Append(", HoursBetweenPollinations = ");
			builder.Append(HoursBetweenPollinations.ToString());
			builder.Append(", GrowthTimeReduction = ");
			builder.Append(GrowthTimeReduction.ToString());
			builder.Append(", PlantsPerPollination = ");
			builder.Append(PlantsPerPollination.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(PollinationRadius)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(HoursBetweenPollinations)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(GrowthTimeReduction)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(PlantsPerPollination);
		}

		[CompilerGenerated]
		public virtual bool Equals(HiveSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(PollinationRadius, other!.PollinationRadius) && EqualityComparer<float>.Default.Equals(HoursBetweenPollinations, other!.HoursBetweenPollinations) && EqualityComparer<float>.Default.Equals(GrowthTimeReduction, other!.GrowthTimeReduction))
				{
					return EqualityComparer<int>.Default.Equals(PlantsPerPollination, other!.PlantsPerPollination);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected HiveSpec(HiveSpec original)
			: base(original)
		{
			PollinationRadius = original.PollinationRadius;
			HoursBetweenPollinations = original.HoursBetweenPollinations;
			GrowthTimeReduction = original.GrowthTimeReduction;
			PlantsPerPollination = original.PlantsPerPollination;
		}

		public HiveSpec()
		{
		}
	}
}
