using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ScienceSystem
{
	internal record ScienceNeedingBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ScienceNeedingBuildingSpec);
			}
		}

		[Serialize]
		public int ScienceUsedPerHour { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ScienceNeedingBuildingSpec");
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
			builder.Append("ScienceUsedPerHour = ");
			builder.Append(ScienceUsedPerHour.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ScienceUsedPerHour);
		}

		[CompilerGenerated]
		public virtual bool Equals(ScienceNeedingBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(ScienceUsedPerHour, other!.ScienceUsedPerHour);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ScienceNeedingBuildingSpec(ScienceNeedingBuildingSpec original)
			: base(original)
		{
			ScienceUsedPerHour = original.ScienceUsedPerHour;
		}

		public ScienceNeedingBuildingSpec()
		{
		}
	}
}
