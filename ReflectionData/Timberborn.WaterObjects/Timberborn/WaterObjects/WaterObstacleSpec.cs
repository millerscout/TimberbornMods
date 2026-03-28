using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterObjects
{
	internal record WaterObstacleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterObstacleSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector2Int> Coordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterObstacleSpec");
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
			builder.Append("Coordinates = ");
			builder.Append(Coordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<Vector2Int>>.Default.GetHashCode(Coordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterObstacleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<Vector2Int>>.Default.Equals(Coordinates, other!.Coordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterObstacleSpec(WaterObstacleSpec original)
			: base(original)
		{
			Coordinates = original.Coordinates;
		}

		public WaterObstacleSpec()
		{
		}
	}
}
