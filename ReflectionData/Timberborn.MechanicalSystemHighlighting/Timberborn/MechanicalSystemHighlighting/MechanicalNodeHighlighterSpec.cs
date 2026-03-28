using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.MechanicalSystemHighlighting
{
	internal record MechanicalNodeHighlighterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MechanicalNodeHighlighterSpec);
			}
		}

		[Serialize]
		public Color HighlightColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MechanicalNodeHighlighterSpec");
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
			builder.Append("HighlightColor = ");
			builder.Append(HighlightColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(HighlightColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(MechanicalNodeHighlighterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Color>.Default.Equals(HighlightColor, other!.HighlightColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MechanicalNodeHighlighterSpec(MechanicalNodeHighlighterSpec original)
			: base(original)
		{
			HighlightColor = original.HighlightColor;
		}

		public MechanicalNodeHighlighterSpec()
		{
		}
	}
}
