using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.NeedSpecs;

namespace Timberborn.RangedEffectSystem
{
	internal record ContinuousEffectBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ContinuousEffectBuildingSpec);
			}
		}

		[Serialize]
		public ImmutableArray<ContinuousEffectSpec> Effects { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ContinuousEffectBuildingSpec");
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
			builder.Append("Effects = ");
			builder.Append(Effects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.GetHashCode(Effects);
		}

		[CompilerGenerated]
		public virtual bool Equals(ContinuousEffectBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.Equals(Effects, other!.Effects);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ContinuousEffectBuildingSpec(ContinuousEffectBuildingSpec original)
			: base(original)
		{
			Effects = original.Effects;
		}

		public ContinuousEffectBuildingSpec()
		{
		}
	}
}
