using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NaturalResourcesMoisture
{
	public record WateredNaturalResourceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WateredNaturalResourceSpec);
			}
		}

		[Serialize]
		public float DaysToDieDry { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WateredNaturalResourceSpec");
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
			builder.Append("DaysToDieDry = ");
			builder.Append(DaysToDieDry.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DaysToDieDry);
		}

		[CompilerGenerated]
		public virtual bool Equals(WateredNaturalResourceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(DaysToDieDry, other!.DaysToDieDry);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WateredNaturalResourceSpec(WateredNaturalResourceSpec original)
			: base(original)
		{
			DaysToDieDry = original.DaysToDieDry;
		}

		public WateredNaturalResourceSpec()
		{
		}
	}
}
