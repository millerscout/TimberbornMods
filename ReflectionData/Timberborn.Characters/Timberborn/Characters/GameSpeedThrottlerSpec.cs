using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Characters
{
	internal record GameSpeedThrottlerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GameSpeedThrottlerSpec);
			}
		}

		[Serialize]
		public int MinPopulation { get; init; }

		[Serialize]
		public int MaxPopulation { get; init; }

		[Serialize]
		public float MinGameSpeedScale { get; init; }

		[Serialize]
		public float MaxGameSpeedScale { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GameSpeedThrottlerSpec");
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
			builder.Append("MinPopulation = ");
			builder.Append(MinPopulation.ToString());
			builder.Append(", MaxPopulation = ");
			builder.Append(MaxPopulation.ToString());
			builder.Append(", MinGameSpeedScale = ");
			builder.Append(MinGameSpeedScale.ToString());
			builder.Append(", MaxGameSpeedScale = ");
			builder.Append(MaxGameSpeedScale.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MinPopulation)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxPopulation)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinGameSpeedScale)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxGameSpeedScale);
		}

		[CompilerGenerated]
		public virtual bool Equals(GameSpeedThrottlerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MinPopulation, other!.MinPopulation) && EqualityComparer<int>.Default.Equals(MaxPopulation, other!.MaxPopulation) && EqualityComparer<float>.Default.Equals(MinGameSpeedScale, other!.MinGameSpeedScale))
				{
					return EqualityComparer<float>.Default.Equals(MaxGameSpeedScale, other!.MaxGameSpeedScale);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GameSpeedThrottlerSpec(GameSpeedThrottlerSpec original)
			: base(original)
		{
			MinPopulation = original.MinPopulation;
			MaxPopulation = original.MaxPopulation;
			MinGameSpeedScale = original.MinGameSpeedScale;
			MaxGameSpeedScale = original.MaxGameSpeedScale;
		}

		public GameSpeedThrottlerSpec()
		{
		}
	}
}
