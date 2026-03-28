using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.PowerGeneration
{
	internal record WaterPoweredGeneratorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterPoweredGeneratorSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector2Int> Blocks { get; init; }

		[Serialize]
		public Vector2 ExpectedWaterDirection { get; init; }

		[Serialize]
		public float MinRequiredOutflow { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterPoweredGeneratorSpec");
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
			builder.Append("Blocks = ");
			builder.Append(Blocks.ToString());
			builder.Append(", ExpectedWaterDirection = ");
			builder.Append(ExpectedWaterDirection.ToString());
			builder.Append(", MinRequiredOutflow = ");
			builder.Append(MinRequiredOutflow.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<Vector2Int>>.Default.GetHashCode(Blocks)) * -1521134295 + EqualityComparer<Vector2>.Default.GetHashCode(ExpectedWaterDirection)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinRequiredOutflow);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterPoweredGeneratorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<Vector2Int>>.Default.Equals(Blocks, other!.Blocks) && EqualityComparer<Vector2>.Default.Equals(ExpectedWaterDirection, other!.ExpectedWaterDirection))
				{
					return EqualityComparer<float>.Default.Equals(MinRequiredOutflow, other!.MinRequiredOutflow);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterPoweredGeneratorSpec(WaterPoweredGeneratorSpec original)
			: base(original)
		{
			Blocks = original.Blocks;
			ExpectedWaterDirection = original.ExpectedWaterDirection;
			MinRequiredOutflow = original.MinRequiredOutflow;
		}

		public WaterPoweredGeneratorSpec()
		{
		}
	}
}
