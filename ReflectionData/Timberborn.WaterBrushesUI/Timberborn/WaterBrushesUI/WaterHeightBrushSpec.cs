using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterBrushesUI
{
	internal record WaterHeightBrushSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterHeightBrushSpec);
			}
		}

		[Serialize]
		public Color AddingTileColor { get; init; }

		[Serialize]
		public Color RemovingTileColor { get; init; }

		[Serialize]
		public Color ContaminatedTileColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterHeightBrushSpec");
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
			builder.Append("AddingTileColor = ");
			builder.Append(AddingTileColor.ToString());
			builder.Append(", RemovingTileColor = ");
			builder.Append(RemovingTileColor.ToString());
			builder.Append(", ContaminatedTileColor = ");
			builder.Append(ContaminatedTileColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(AddingTileColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(RemovingTileColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ContaminatedTileColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterHeightBrushSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(AddingTileColor, other!.AddingTileColor) && EqualityComparer<Color>.Default.Equals(RemovingTileColor, other!.RemovingTileColor))
				{
					return EqualityComparer<Color>.Default.Equals(ContaminatedTileColor, other!.ContaminatedTileColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterHeightBrushSpec(WaterHeightBrushSpec original)
			: base(original)
		{
			AddingTileColor = original.AddingTileColor;
			RemovingTileColor = original.RemovingTileColor;
			ContaminatedTileColor = original.ContaminatedTileColor;
		}

		public WaterHeightBrushSpec()
		{
		}
	}
}
