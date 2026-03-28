using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SoakedEffects
{
	internal record NeedAffectedBySoakednessSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedAffectedBySoakednessSpec);
			}
		}

		[Serialize]
		public float PointsPerHour { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedAffectedBySoakednessSpec");
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
			builder.Append("PointsPerHour = ");
			builder.Append(PointsPerHour.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(PointsPerHour);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedAffectedBySoakednessSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(PointsPerHour, other!.PointsPerHour);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedAffectedBySoakednessSpec(NeedAffectedBySoakednessSpec original)
			: base(original)
		{
			PointsPerHour = original.PointsPerHour;
		}

		public NeedAffectedBySoakednessSpec()
		{
		}
	}
}
