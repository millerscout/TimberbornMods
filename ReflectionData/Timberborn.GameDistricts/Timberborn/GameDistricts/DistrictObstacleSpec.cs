using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.GameDistricts
{
	internal record DistrictObstacleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DistrictObstacleSpec);
			}
		}

		[Serialize]
		public Vector3Int CoordinateOffset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DistrictObstacleSpec");
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
			builder.Append("CoordinateOffset = ");
			builder.Append(CoordinateOffset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(CoordinateOffset);
		}

		[CompilerGenerated]
		public virtual bool Equals(DistrictObstacleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(CoordinateOffset, other!.CoordinateOffset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DistrictObstacleSpec(DistrictObstacleSpec original)
			: base(original)
		{
			CoordinateOffset = original.CoordinateOffset;
		}

		public DistrictObstacleSpec()
		{
		}
	}
}
