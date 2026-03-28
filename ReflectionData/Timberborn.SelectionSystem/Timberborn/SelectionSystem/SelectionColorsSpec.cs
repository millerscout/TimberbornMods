using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.SelectionSystem
{
	public record SelectionColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SelectionColorsSpec);
			}
		}

		[Serialize]
		public Color EntitySelection { get; init; }

		[Serialize]
		public Color SelectionToolHighlight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SelectionColorsSpec");
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
			builder.Append("EntitySelection = ");
			builder.Append(EntitySelection.ToString());
			builder.Append(", SelectionToolHighlight = ");
			builder.Append(SelectionToolHighlight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(EntitySelection)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(SelectionToolHighlight);
		}

		[CompilerGenerated]
		public virtual bool Equals(SelectionColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(EntitySelection, other!.EntitySelection))
				{
					return EqualityComparer<Color>.Default.Equals(SelectionToolHighlight, other!.SelectionToolHighlight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SelectionColorsSpec(SelectionColorsSpec original)
			: base(original)
		{
			EntitySelection = original.EntitySelection;
			SelectionToolHighlight = original.SelectionToolHighlight;
		}

		public SelectionColorsSpec()
		{
		}
	}
}
