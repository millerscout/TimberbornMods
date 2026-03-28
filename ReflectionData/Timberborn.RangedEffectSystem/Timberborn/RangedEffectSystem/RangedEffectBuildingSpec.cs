using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.RangedEffectSystem
{
	internal record RangedEffectBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RangedEffectBuildingSpec);
			}
		}

		[Serialize]
		public int EffectRadius { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RangedEffectBuildingSpec");
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
			builder.Append("EffectRadius = ");
			builder.Append(EffectRadius.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(EffectRadius);
		}

		[CompilerGenerated]
		public virtual bool Equals(RangedEffectBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(EffectRadius, other!.EffectRadius);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RangedEffectBuildingSpec(RangedEffectBuildingSpec original)
			: base(original)
		{
			EffectRadius = original.EffectRadius;
		}

		public RangedEffectBuildingSpec()
		{
		}
	}
}
