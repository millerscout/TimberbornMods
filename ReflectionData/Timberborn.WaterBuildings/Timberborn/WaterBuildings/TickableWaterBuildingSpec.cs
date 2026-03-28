using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterBuildings
{
	internal record TickableWaterBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TickableWaterBuildingSpec);
			}
		}

		[Serialize]
		public Vector3Int WaterCoordinates { get; init; }

		[Serialize]
		public float MinWaterHeight { get; init; }

		[Serialize]
		public float ChangeRange { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TickableWaterBuildingSpec");
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
			builder.Append("WaterCoordinates = ");
			builder.Append(WaterCoordinates.ToString());
			builder.Append(", MinWaterHeight = ");
			builder.Append(MinWaterHeight.ToString());
			builder.Append(", ChangeRange = ");
			builder.Append(ChangeRange.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(WaterCoordinates)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinWaterHeight)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ChangeRange);
		}

		[CompilerGenerated]
		public virtual bool Equals(TickableWaterBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3Int>.Default.Equals(WaterCoordinates, other!.WaterCoordinates) && EqualityComparer<float>.Default.Equals(MinWaterHeight, other!.MinWaterHeight))
				{
					return EqualityComparer<float>.Default.Equals(ChangeRange, other!.ChangeRange);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TickableWaterBuildingSpec(TickableWaterBuildingSpec original)
			: base(original)
		{
			WaterCoordinates = original.WaterCoordinates;
			MinWaterHeight = original.MinWaterHeight;
			ChangeRange = original.ChangeRange;
		}

		public TickableWaterBuildingSpec()
		{
		}
	}
}
