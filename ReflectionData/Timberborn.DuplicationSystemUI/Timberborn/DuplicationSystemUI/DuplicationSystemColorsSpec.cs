using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.DuplicationSystemUI
{
	internal record DuplicationSystemColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DuplicationSystemColorsSpec);
			}
		}

		[Serialize]
		public Color SourceColor { get; init; }

		[Serialize]
		public Color TargetColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DuplicationSystemColorsSpec");
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
			builder.Append("SourceColor = ");
			builder.Append(SourceColor.ToString());
			builder.Append(", TargetColor = ");
			builder.Append(TargetColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(SourceColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(TargetColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(DuplicationSystemColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(SourceColor, other!.SourceColor))
				{
					return EqualityComparer<Color>.Default.Equals(TargetColor, other!.TargetColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DuplicationSystemColorsSpec(DuplicationSystemColorsSpec original)
			: base(original)
		{
			SourceColor = original.SourceColor;
			TargetColor = original.TargetColor;
		}

		public DuplicationSystemColorsSpec()
		{
		}
	}
}
