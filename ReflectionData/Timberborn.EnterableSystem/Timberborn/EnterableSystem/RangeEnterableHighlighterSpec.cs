using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.EnterableSystem
{
	internal record RangeEnterableHighlighterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RangeEnterableHighlighterSpec);
			}
		}

		[Serialize]
		public Color BuildingInRange { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RangeEnterableHighlighterSpec");
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
			builder.Append("BuildingInRange = ");
			builder.Append(BuildingInRange.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(BuildingInRange);
		}

		[CompilerGenerated]
		public virtual bool Equals(RangeEnterableHighlighterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Color>.Default.Equals(BuildingInRange, other!.BuildingInRange);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RangeEnterableHighlighterSpec(RangeEnterableHighlighterSpec original)
			: base(original)
		{
			BuildingInRange = original.BuildingInRange;
		}

		public RangeEnterableHighlighterSpec()
		{
		}
	}
}
