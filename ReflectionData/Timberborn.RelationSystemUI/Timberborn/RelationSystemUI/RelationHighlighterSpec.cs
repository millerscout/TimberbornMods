using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.RelationSystemUI
{
	internal record RelationHighlighterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RelationHighlighterSpec);
			}
		}

		[Serialize]
		public Color RelationSelection { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RelationHighlighterSpec");
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
			builder.Append("RelationSelection = ");
			builder.Append(RelationSelection.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(RelationSelection);
		}

		[CompilerGenerated]
		public virtual bool Equals(RelationHighlighterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Color>.Default.Equals(RelationSelection, other!.RelationSelection);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RelationHighlighterSpec(RelationHighlighterSpec original)
			: base(original)
		{
			RelationSelection = original.RelationSelection;
		}

		public RelationHighlighterSpec()
		{
		}
	}
}
