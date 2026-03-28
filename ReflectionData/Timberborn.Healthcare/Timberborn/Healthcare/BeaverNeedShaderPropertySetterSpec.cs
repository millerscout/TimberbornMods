using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Healthcare
{
	internal record BeaverNeedShaderPropertySetterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BeaverNeedShaderPropertySetterSpec);
			}
		}

		[Serialize]
		public ImmutableArray<BeaverNeedShaderPropertySet> PropertySets { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BeaverNeedShaderPropertySetterSpec");
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
			builder.Append("PropertySets = ");
			builder.Append(PropertySets.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<BeaverNeedShaderPropertySet>>.Default.GetHashCode(PropertySets);
		}

		[CompilerGenerated]
		public virtual bool Equals(BeaverNeedShaderPropertySetterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<BeaverNeedShaderPropertySet>>.Default.Equals(PropertySets, other!.PropertySets);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BeaverNeedShaderPropertySetterSpec(BeaverNeedShaderPropertySetterSpec original)
			: base(original)
		{
			PropertySets = original.PropertySets;
		}

		public BeaverNeedShaderPropertySetterSpec()
		{
		}
	}
}
