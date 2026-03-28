using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.NeedSpecs;

namespace Timberborn.SleepSystem
{
	internal record SleeperSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SleeperSpec);
			}
		}

		[Serialize]
		public ImmutableArray<ContinuousEffectSpec> SleepOutsideEffects { get; init; }

		[Serialize]
		public float MaxOffsetInHours { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SleeperSpec");
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
			builder.Append("SleepOutsideEffects = ");
			builder.Append(SleepOutsideEffects.ToString());
			builder.Append(", MaxOffsetInHours = ");
			builder.Append(MaxOffsetInHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.GetHashCode(SleepOutsideEffects)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxOffsetInHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(SleeperSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.Equals(SleepOutsideEffects, other!.SleepOutsideEffects))
				{
					return EqualityComparer<float>.Default.Equals(MaxOffsetInHours, other!.MaxOffsetInHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SleeperSpec(SleeperSpec original)
			: base(original)
		{
			SleepOutsideEffects = original.SleepOutsideEffects;
			MaxOffsetInHours = original.MaxOffsetInHours;
		}

		public SleeperSpec()
		{
		}
	}
}
