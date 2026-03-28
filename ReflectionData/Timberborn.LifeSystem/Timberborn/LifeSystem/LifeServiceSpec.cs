using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.LifeSystem
{
	internal record LifeServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(LifeServiceSpec);
			}
		}

		[Serialize]
		public int AverageLifespan { get; init; }

		[Serialize]
		public int DaysOfChildhood { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LifeServiceSpec");
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
			builder.Append("AverageLifespan = ");
			builder.Append(AverageLifespan.ToString());
			builder.Append(", DaysOfChildhood = ");
			builder.Append(DaysOfChildhood.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AverageLifespan)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(DaysOfChildhood);
		}

		[CompilerGenerated]
		public virtual bool Equals(LifeServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(AverageLifespan, other!.AverageLifespan))
				{
					return EqualityComparer<int>.Default.Equals(DaysOfChildhood, other!.DaysOfChildhood);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected LifeServiceSpec(LifeServiceSpec original)
			: base(original)
		{
			AverageLifespan = original.AverageLifespan;
			DaysOfChildhood = original.DaysOfChildhood;
		}

		public LifeServiceSpec()
		{
		}
	}
}
