using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Yielding
{
	public record YieldRemovingBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(YieldRemovingBuildingSpec);
			}
		}

		[Serialize]
		public string ResourceGroup { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("YieldRemovingBuildingSpec");
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
			builder.Append("ResourceGroup = ");
			builder.Append((object)ResourceGroup);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ResourceGroup);
		}

		[CompilerGenerated]
		public virtual bool Equals(YieldRemovingBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(ResourceGroup, other!.ResourceGroup);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected YieldRemovingBuildingSpec(YieldRemovingBuildingSpec original)
			: base(original)
		{
			ResourceGroup = original.ResourceGroup;
		}

		public YieldRemovingBuildingSpec()
		{
		}
	}
}
