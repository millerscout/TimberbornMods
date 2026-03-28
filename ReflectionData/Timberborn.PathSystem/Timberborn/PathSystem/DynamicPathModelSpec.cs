using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PathSystem
{
	internal record DynamicPathModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DynamicPathModelSpec);
			}
		}

		[Serialize]
		public string GroundModelPrefix { get; init; }

		[Serialize]
		public string RoofModelPrefix { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DynamicPathModelSpec");
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
			builder.Append("GroundModelPrefix = ");
			builder.Append((object)GroundModelPrefix);
			builder.Append(", RoofModelPrefix = ");
			builder.Append((object)RoofModelPrefix);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GroundModelPrefix)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RoofModelPrefix);
		}

		[CompilerGenerated]
		public virtual bool Equals(DynamicPathModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(GroundModelPrefix, other!.GroundModelPrefix))
				{
					return EqualityComparer<string>.Default.Equals(RoofModelPrefix, other!.RoofModelPrefix);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DynamicPathModelSpec(DynamicPathModelSpec original)
			: base(original)
		{
			GroundModelPrefix = original.GroundModelPrefix;
			RoofModelPrefix = original.RoofModelPrefix;
		}

		public DynamicPathModelSpec()
		{
		}
	}
}
