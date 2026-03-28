using System;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterSourceSystem
{
	internal record WaterSourceRegulatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterSourceRegulatorSpec);
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterSourceRegulatorSpec");
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
		public virtual bool Equals(WaterSourceRegulatorSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterSourceRegulatorSpec(WaterSourceRegulatorSpec original)
			: base(original)
		{
		}

		public WaterSourceRegulatorSpec()
		{
		}
	}
}
