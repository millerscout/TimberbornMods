using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.PrioritySystemUI
{
	internal record PriorityColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PriorityColorsSpec);
			}
		}

		[Serialize]
		public Color HighlightVeryLow { get; init; }

		[Serialize]
		public Color HighlightLow { get; init; }

		[Serialize]
		public Color HighlightNormal { get; init; }

		[Serialize]
		public Color HighlightHigh { get; init; }

		[Serialize]
		public Color HighlightVeryHigh { get; init; }

		[Serialize]
		public Color ButtonVeryLow { get; init; }

		[Serialize]
		public Color ButtonLow { get; init; }

		[Serialize]
		public Color ButtonNormal { get; init; }

		[Serialize]
		public Color ButtonHigh { get; init; }

		[Serialize]
		public Color ButtonVeryHigh { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PriorityColorsSpec");
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
			builder.Append("HighlightVeryLow = ");
			builder.Append(HighlightVeryLow.ToString());
			builder.Append(", HighlightLow = ");
			builder.Append(HighlightLow.ToString());
			builder.Append(", HighlightNormal = ");
			builder.Append(HighlightNormal.ToString());
			builder.Append(", HighlightHigh = ");
			builder.Append(HighlightHigh.ToString());
			builder.Append(", HighlightVeryHigh = ");
			builder.Append(HighlightVeryHigh.ToString());
			builder.Append(", ButtonVeryLow = ");
			builder.Append(ButtonVeryLow.ToString());
			builder.Append(", ButtonLow = ");
			builder.Append(ButtonLow.ToString());
			builder.Append(", ButtonNormal = ");
			builder.Append(ButtonNormal.ToString());
			builder.Append(", ButtonHigh = ");
			builder.Append(ButtonHigh.ToString());
			builder.Append(", ButtonVeryHigh = ");
			builder.Append(ButtonVeryHigh.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(HighlightVeryLow)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(HighlightLow)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(HighlightNormal)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(HighlightHigh)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(HighlightVeryHigh)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ButtonVeryLow)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ButtonLow)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ButtonNormal)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ButtonHigh)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ButtonVeryHigh);
		}

		[CompilerGenerated]
		public virtual bool Equals(PriorityColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(HighlightVeryLow, other!.HighlightVeryLow) && EqualityComparer<Color>.Default.Equals(HighlightLow, other!.HighlightLow) && EqualityComparer<Color>.Default.Equals(HighlightNormal, other!.HighlightNormal) && EqualityComparer<Color>.Default.Equals(HighlightHigh, other!.HighlightHigh) && EqualityComparer<Color>.Default.Equals(HighlightVeryHigh, other!.HighlightVeryHigh) && EqualityComparer<Color>.Default.Equals(ButtonVeryLow, other!.ButtonVeryLow) && EqualityComparer<Color>.Default.Equals(ButtonLow, other!.ButtonLow) && EqualityComparer<Color>.Default.Equals(ButtonNormal, other!.ButtonNormal) && EqualityComparer<Color>.Default.Equals(ButtonHigh, other!.ButtonHigh))
				{
					return EqualityComparer<Color>.Default.Equals(ButtonVeryHigh, other!.ButtonVeryHigh);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PriorityColorsSpec(PriorityColorsSpec original)
			: base(original)
		{
			HighlightVeryLow = original.HighlightVeryLow;
			HighlightLow = original.HighlightLow;
			HighlightNormal = original.HighlightNormal;
			HighlightHigh = original.HighlightHigh;
			HighlightVeryHigh = original.HighlightVeryHigh;
			ButtonVeryLow = original.ButtonVeryLow;
			ButtonLow = original.ButtonLow;
			ButtonNormal = original.ButtonNormal;
			ButtonHigh = original.ButtonHigh;
			ButtonVeryHigh = original.ButtonVeryHigh;
		}

		public PriorityColorsSpec()
		{
		}
	}
}
