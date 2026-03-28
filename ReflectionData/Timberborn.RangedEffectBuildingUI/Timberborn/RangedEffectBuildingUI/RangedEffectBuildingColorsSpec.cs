using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.RangedEffectBuildingUI
{
	internal record RangedEffectBuildingColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RangedEffectBuildingColorsSpec);
			}
		}

		[Serialize]
		public Color BuildingRangeTile { get; init; }

		[Serialize]
		public Color BuildingRangeObject { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RangedEffectBuildingColorsSpec");
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
			builder.Append("BuildingRangeTile = ");
			builder.Append(BuildingRangeTile.ToString());
			builder.Append(", BuildingRangeObject = ");
			builder.Append(BuildingRangeObject.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(BuildingRangeTile)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(BuildingRangeObject);
		}

		[CompilerGenerated]
		public virtual bool Equals(RangedEffectBuildingColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(BuildingRangeTile, other!.BuildingRangeTile))
				{
					return EqualityComparer<Color>.Default.Equals(BuildingRangeObject, other!.BuildingRangeObject);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RangedEffectBuildingColorsSpec(RangedEffectBuildingColorsSpec original)
			: base(original)
		{
			BuildingRangeTile = original.BuildingRangeTile;
			BuildingRangeObject = original.BuildingRangeObject;
		}

		public RangedEffectBuildingColorsSpec()
		{
		}
	}
}
