using System;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.WaterBuildings;

namespace Timberborn.WaterWorkshops
{
	internal record ManufactoryWaterContaminationConsumerSpec : ComponentSpec, IContaminatedWaterNeedingBuilding
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ManufactoryWaterContaminationConsumerSpec);
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ManufactoryWaterContaminationConsumerSpec");
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
		public virtual bool Equals(ManufactoryWaterContaminationConsumerSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected ManufactoryWaterContaminationConsumerSpec(ManufactoryWaterContaminationConsumerSpec original)
			: base(original)
		{
		}

		public ManufactoryWaterContaminationConsumerSpec()
		{
		}
	}
}
