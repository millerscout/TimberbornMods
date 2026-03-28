using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterBuildings
{
	internal record WaterOutputSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterOutputSpec);
			}
		}

		[Serialize]
		public Vector3Int WaterCoordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterOutputSpec");
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
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(WaterCoordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterOutputSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(WaterCoordinates, other!.WaterCoordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterOutputSpec(WaterOutputSpec original)
			: base(original)
		{
			WaterCoordinates = original.WaterCoordinates;
		}

		public WaterOutputSpec()
		{
		}
	}
}
