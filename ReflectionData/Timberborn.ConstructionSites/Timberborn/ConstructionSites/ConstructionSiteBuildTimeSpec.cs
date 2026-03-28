using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ConstructionSites
{
	internal record ConstructionSiteBuildTimeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ConstructionSiteBuildTimeSpec);
			}
		}

		[Serialize]
		public float ConstructionTimeInHours { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ConstructionSiteBuildTimeSpec");
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
			builder.Append("ConstructionTimeInHours = ");
			builder.Append(ConstructionTimeInHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ConstructionTimeInHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(ConstructionSiteBuildTimeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(ConstructionTimeInHours, other!.ConstructionTimeInHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ConstructionSiteBuildTimeSpec(ConstructionSiteBuildTimeSpec original)
			: base(original)
		{
			ConstructionTimeInHours = original.ConstructionTimeInHours;
		}

		public ConstructionSiteBuildTimeSpec()
		{
			ConstructionTimeInHours = 1f;
			base._002Ector();
		}
	}
}
