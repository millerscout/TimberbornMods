using System;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.DistributionSystem
{
	internal record DistrictCrossingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DistrictCrossingSpec);
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DistrictCrossingSpec");
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
			return base.PrintMembers(builder);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[CompilerGenerated]
		public virtual bool Equals(DistrictCrossingSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected DistrictCrossingSpec(DistrictCrossingSpec original)
			: base(original)
		{
		}

		public DistrictCrossingSpec()
		{
		}
	}
}
