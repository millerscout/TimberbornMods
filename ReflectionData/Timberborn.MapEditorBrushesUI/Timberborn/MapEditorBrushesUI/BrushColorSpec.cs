using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.MapEditorBrushesUI
{
	internal record BrushColorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BrushColorSpec);
			}
		}

		[Serialize]
		public Color Neutral { get; init; }

		[Serialize]
		public Color Positive { get; init; }

		[Serialize]
		public Color Negative { get; init; }

		[Serialize]
		public Color Objects { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BrushColorSpec");
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
			builder.Append("Neutral = ");
			builder.Append(Neutral.ToString());
			builder.Append(", Positive = ");
			builder.Append(Positive.ToString());
			builder.Append(", Negative = ");
			builder.Append(Negative.ToString());
			builder.Append(", Objects = ");
			builder.Append(Objects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(Neutral)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(Positive)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(Negative)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(Objects);
		}

		[CompilerGenerated]
		public virtual bool Equals(BrushColorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(Neutral, other!.Neutral) && EqualityComparer<Color>.Default.Equals(Positive, other!.Positive) && EqualityComparer<Color>.Default.Equals(Negative, other!.Negative))
				{
					return EqualityComparer<Color>.Default.Equals(Objects, other!.Objects);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BrushColorSpec(BrushColorSpec original)
			: base(original)
		{
			Neutral = original.Neutral;
			Positive = original.Positive;
			Negative = original.Negative;
			Objects = original.Objects;
		}

		public BrushColorSpec()
		{
		}
	}
}
