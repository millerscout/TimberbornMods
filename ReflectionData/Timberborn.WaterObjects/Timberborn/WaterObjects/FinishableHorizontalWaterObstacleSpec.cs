using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterObjects
{
	internal record FinishableHorizontalWaterObstacleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FinishableHorizontalWaterObstacleSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector3Int> Obstacles { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FinishableHorizontalWaterObstacleSpec");
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
			builder.Append("Obstacles = ");
			builder.Append(Obstacles.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<Vector3Int>>.Default.GetHashCode(Obstacles);
		}

		[CompilerGenerated]
		public virtual bool Equals(FinishableHorizontalWaterObstacleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<Vector3Int>>.Default.Equals(Obstacles, other!.Obstacles);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FinishableHorizontalWaterObstacleSpec(FinishableHorizontalWaterObstacleSpec original)
			: base(original)
		{
			Obstacles = original.Obstacles;
		}

		public FinishableHorizontalWaterObstacleSpec()
		{
		}
	}
}
