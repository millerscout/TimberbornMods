using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NaturalResourcesMoisture
{
	public record FloodableNaturalResourceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FloodableNaturalResourceSpec);
			}
		}

		[Serialize]
		public int MinWaterHeight { get; init; }

		[Serialize]
		public int MaxWaterHeight { get; init; }

		[Serialize]
		public float DaysToDie { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FloodableNaturalResourceSpec");
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
			builder.Append("MinWaterHeight = ");
			builder.Append(MinWaterHeight.ToString());
			builder.Append(", MaxWaterHeight = ");
			builder.Append(MaxWaterHeight.ToString());
			builder.Append(", DaysToDie = ");
			builder.Append(DaysToDie.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MinWaterHeight)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxWaterHeight)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DaysToDie);
		}

		[CompilerGenerated]
		public virtual bool Equals(FloodableNaturalResourceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MinWaterHeight, other!.MinWaterHeight) && EqualityComparer<int>.Default.Equals(MaxWaterHeight, other!.MaxWaterHeight))
				{
					return EqualityComparer<float>.Default.Equals(DaysToDie, other!.DaysToDie);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FloodableNaturalResourceSpec(FloodableNaturalResourceSpec original)
			: base(original)
		{
			MinWaterHeight = original.MinWaterHeight;
			MaxWaterHeight = original.MaxWaterHeight;
			DaysToDie = original.DaysToDie;
		}

		public FloodableNaturalResourceSpec()
		{
		}
	}
}
