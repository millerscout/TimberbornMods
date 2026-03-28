using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ConstructionSites
{
	internal record ConstructionSiteBuildersLimiterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ConstructionSiteBuildersLimiterSpec);
			}
		}

		[Serialize]
		public int MaxAllowedBuilders { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ConstructionSiteBuildersLimiterSpec");
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
			builder.Append("MaxAllowedBuilders = ");
			builder.Append(MaxAllowedBuilders.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxAllowedBuilders);
		}

		[CompilerGenerated]
		public virtual bool Equals(ConstructionSiteBuildersLimiterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(MaxAllowedBuilders, other!.MaxAllowedBuilders);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ConstructionSiteBuildersLimiterSpec(ConstructionSiteBuildersLimiterSpec original)
			: base(original)
		{
			MaxAllowedBuilders = original.MaxAllowedBuilders;
		}

		public ConstructionSiteBuildersLimiterSpec()
		{
			MaxAllowedBuilders = 1;
			base._002Ector();
		}
	}
}
