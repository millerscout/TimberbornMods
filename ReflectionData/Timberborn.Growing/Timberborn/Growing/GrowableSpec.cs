using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Growing
{
	public record GrowableSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GrowableSpec);
			}
		}

		[Serialize]
		public float GrowthTimeInDays { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GrowableSpec");
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
			builder.Append("GrowthTimeInDays = ");
			builder.Append(GrowthTimeInDays.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(GrowthTimeInDays);
		}

		[CompilerGenerated]
		public virtual bool Equals(GrowableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(GrowthTimeInDays, other!.GrowthTimeInDays);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GrowableSpec(GrowableSpec original)
			: base(original)
		{
			GrowthTimeInDays = original.GrowthTimeInDays;
		}

		public GrowableSpec()
		{
		}
	}
}
