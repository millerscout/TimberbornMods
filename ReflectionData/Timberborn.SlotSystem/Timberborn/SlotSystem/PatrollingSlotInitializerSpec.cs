using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	internal record PatrollingSlotInitializerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PatrollingSlotInitializerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<PatrollingSlotSpec> PatrollingSlots { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PatrollingSlotInitializerSpec");
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
			builder.Append("PatrollingSlots = ");
			builder.Append(PatrollingSlots.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<PatrollingSlotSpec>>.Default.GetHashCode(PatrollingSlots);
		}

		[CompilerGenerated]
		public virtual bool Equals(PatrollingSlotInitializerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<PatrollingSlotSpec>>.Default.Equals(PatrollingSlots, other!.PatrollingSlots);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PatrollingSlotInitializerSpec(PatrollingSlotInitializerSpec original)
			: base(original)
		{
			PatrollingSlots = original.PatrollingSlots;
		}

		public PatrollingSlotInitializerSpec()
		{
		}
	}
}
