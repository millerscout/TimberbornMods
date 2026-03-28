using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlockSystem;
using Timberborn.BlueprintSystem;
using Timberborn.Coordinates;
using UnityEngine;

namespace Timberborn.Buildings
{
	internal record BuildingAccessibleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildingAccessibleSpec);
			}
		}

		[Serialize]
		public Vector3 LocalAccess { get; init; }

		[Serialize]
		public bool ForceOneFinalAccess { get; init; }

		public Vector3 CalculateAccessFromLocalAccess(BlockObject blockObject)
		{
			Vector3 coordinates = CoordinateSystem.WorldToGrid(LocalAccess);
			return CoordinateSystem.GridToWorld(blockObject.TransformCoordinates(coordinates));
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildingAccessibleSpec");
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
			builder.Append("LocalAccess = ");
			builder.Append(LocalAccess.ToString());
			builder.Append(", ForceOneFinalAccess = ");
			builder.Append(ForceOneFinalAccess.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(LocalAccess)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ForceOneFinalAccess);
		}

		[CompilerGenerated]
		public virtual bool Equals(BuildingAccessibleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3>.Default.Equals(LocalAccess, other!.LocalAccess))
				{
					return EqualityComparer<bool>.Default.Equals(ForceOneFinalAccess, other!.ForceOneFinalAccess);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BuildingAccessibleSpec(BuildingAccessibleSpec original)
			: base(original)
		{
			LocalAccess = original.LocalAccess;
			ForceOneFinalAccess = original.ForceOneFinalAccess;
		}

		public BuildingAccessibleSpec()
		{
		}
	}
}
