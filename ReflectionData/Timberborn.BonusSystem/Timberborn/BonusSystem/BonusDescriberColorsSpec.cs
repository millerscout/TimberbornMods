using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BonusSystem
{
	internal record BonusDescriberColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BonusDescriberColorsSpec);
			}
		}

		[Serialize]
		public Color PositiveBonusHighlight { get; init; }

		[Serialize]
		public Color NegativeBonusHighlight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BonusDescriberColorsSpec");
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
			builder.Append("PositiveBonusHighlight = ");
			builder.Append(PositiveBonusHighlight.ToString());
			builder.Append(", NegativeBonusHighlight = ");
			builder.Append(NegativeBonusHighlight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(PositiveBonusHighlight)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(NegativeBonusHighlight);
		}

		[CompilerGenerated]
		public virtual bool Equals(BonusDescriberColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(PositiveBonusHighlight, other!.PositiveBonusHighlight))
				{
					return EqualityComparer<Color>.Default.Equals(NegativeBonusHighlight, other!.NegativeBonusHighlight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BonusDescriberColorsSpec(BonusDescriberColorsSpec original)
			: base(original)
		{
			PositiveBonusHighlight = original.PositiveBonusHighlight;
			NegativeBonusHighlight = original.NegativeBonusHighlight;
		}

		public BonusDescriberColorsSpec()
		{
		}
	}
}
