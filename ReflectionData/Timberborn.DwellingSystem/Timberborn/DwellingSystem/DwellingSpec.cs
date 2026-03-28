using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.NeedSpecs;

namespace Timberborn.DwellingSystem
{
	internal record DwellingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DwellingSpec);
			}
		}

		[Serialize]
		public int MaxBeavers { get; init; }

		[Serialize]
		public ImmutableArray<ContinuousEffectSpec> SleepEffects { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DwellingSpec");
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
			builder.Append("MaxBeavers = ");
			builder.Append(MaxBeavers.ToString());
			builder.Append(", SleepEffects = ");
			builder.Append(SleepEffects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxBeavers)) * -1521134295 + EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.GetHashCode(SleepEffects);
		}

		[CompilerGenerated]
		public virtual bool Equals(DwellingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MaxBeavers, other!.MaxBeavers))
				{
					return EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.Equals(SleepEffects, other!.SleepEffects);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DwellingSpec(DwellingSpec original)
			: base(original)
		{
			MaxBeavers = original.MaxBeavers;
			SleepEffects = original.SleepEffects;
		}

		public DwellingSpec()
		{
		}
	}
}
