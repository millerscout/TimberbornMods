using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.DeteriorationSystem
{
	internal record DeteriorableSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DeteriorableSpec);
			}
		}

		[Serialize]
		public int DeteriorationInDays { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DeteriorableSpec");
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
			builder.Append("DeteriorationInDays = ");
			builder.Append(DeteriorationInDays.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(DeteriorationInDays);
		}

		[CompilerGenerated]
		public virtual bool Equals(DeteriorableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(DeteriorationInDays, other!.DeteriorationInDays);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DeteriorableSpec(DeteriorableSpec original)
			: base(original)
		{
			DeteriorationInDays = original.DeteriorationInDays;
		}

		public DeteriorableSpec()
		{
		}
	}
}
