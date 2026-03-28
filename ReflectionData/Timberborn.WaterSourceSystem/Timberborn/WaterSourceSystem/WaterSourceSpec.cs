using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterSourceSystem
{
	internal record WaterSourceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterSourceSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector2Int> Coordinates { get; init; }

		[Serialize]
		public float DefaultStrength { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterSourceSpec");
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
			builder.Append(", DefaultStrength = ");
			builder.Append(DefaultStrength.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<Vector2Int>>.Default.GetHashCode(Coordinates)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DefaultStrength);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterSourceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<Vector2Int>>.Default.Equals(Coordinates, other!.Coordinates))
				{
					return EqualityComparer<float>.Default.Equals(DefaultStrength, other!.DefaultStrength);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterSourceSpec(WaterSourceSpec original)
			: base(original)
		{
			Coordinates = original.Coordinates;
			DefaultStrength = original.DefaultStrength;
		}

		public WaterSourceSpec()
		{
		}
	}
}
