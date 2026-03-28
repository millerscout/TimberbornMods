using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.TutorialSteps
{
	internal record TutorialColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TutorialColorsSpec);
			}
		}

		[Serialize]
		public Color TutorialBuildingHighlight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TutorialColorsSpec");
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
			builder.Append("TutorialBuildingHighlight = ");
			builder.Append(TutorialBuildingHighlight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(TutorialBuildingHighlight);
		}

		[CompilerGenerated]
		public virtual bool Equals(TutorialColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Color>.Default.Equals(TutorialBuildingHighlight, other!.TutorialBuildingHighlight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TutorialColorsSpec(TutorialColorsSpec original)
			: base(original)
		{
			TutorialBuildingHighlight = original.TutorialBuildingHighlight;
		}

		public TutorialColorsSpec()
		{
		}
	}
}
