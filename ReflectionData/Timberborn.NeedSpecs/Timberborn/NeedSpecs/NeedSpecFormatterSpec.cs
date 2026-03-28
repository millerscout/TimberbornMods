using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.NeedSpecs
{
	internal record NeedSpecFormatterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedSpecFormatterSpec);
			}
		}

		[Serialize]
		public Color PositiveHighlightColor { get; init; }

		[Serialize]
		public Color NegativeHighlightColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedSpecFormatterSpec");
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
			builder.Append("PositiveHighlightColor = ");
			builder.Append(PositiveHighlightColor.ToString());
			builder.Append(", NegativeHighlightColor = ");
			builder.Append(NegativeHighlightColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(PositiveHighlightColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(NegativeHighlightColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedSpecFormatterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(PositiveHighlightColor, other!.PositiveHighlightColor))
				{
					return EqualityComparer<Color>.Default.Equals(NegativeHighlightColor, other!.NegativeHighlightColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedSpecFormatterSpec(NeedSpecFormatterSpec original)
			: base(original)
		{
			PositiveHighlightColor = original.PositiveHighlightColor;
			NegativeHighlightColor = original.NegativeHighlightColor;
		}

		public NeedSpecFormatterSpec()
		{
		}
	}
}
