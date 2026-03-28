using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BuilderPrioritySystemUI
{
	internal record BuilderPriorityToolSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuilderPriorityToolSpec);
			}
		}

		[Serialize]
		public Color PriorityHighlightColor { get; init; }

		[Serialize]
		public Color PriorityActionColor { get; init; }

		[Serialize]
		public Color PriorityTileColor { get; init; }

		[Serialize]
		public Color PrioritySideColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuilderPriorityToolSpec");
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
			builder.Append("PriorityHighlightColor = ");
			builder.Append(PriorityHighlightColor.ToString());
			builder.Append(", PriorityActionColor = ");
			builder.Append(PriorityActionColor.ToString());
			builder.Append(", PriorityTileColor = ");
			builder.Append(PriorityTileColor.ToString());
			builder.Append(", PrioritySideColor = ");
			builder.Append(PrioritySideColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(PriorityHighlightColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(PriorityActionColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(PriorityTileColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(PrioritySideColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(BuilderPriorityToolSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(PriorityHighlightColor, other!.PriorityHighlightColor) && EqualityComparer<Color>.Default.Equals(PriorityActionColor, other!.PriorityActionColor) && EqualityComparer<Color>.Default.Equals(PriorityTileColor, other!.PriorityTileColor))
				{
					return EqualityComparer<Color>.Default.Equals(PrioritySideColor, other!.PrioritySideColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BuilderPriorityToolSpec(BuilderPriorityToolSpec original)
			: base(original)
		{
			PriorityHighlightColor = original.PriorityHighlightColor;
			PriorityActionColor = original.PriorityActionColor;
			PriorityTileColor = original.PriorityTileColor;
			PrioritySideColor = original.PrioritySideColor;
		}

		public BuilderPriorityToolSpec()
		{
		}
	}
}
