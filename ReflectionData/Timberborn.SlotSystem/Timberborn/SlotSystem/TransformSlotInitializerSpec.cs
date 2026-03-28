using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	internal record TransformSlotInitializerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TransformSlotInitializerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<TransformSlotSpec> Slots { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TransformSlotInitializerSpec");
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
			builder.Append("Slots = ");
			builder.Append(Slots.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<TransformSlotSpec>>.Default.GetHashCode(Slots);
		}

		[CompilerGenerated]
		public virtual bool Equals(TransformSlotInitializerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<TransformSlotSpec>>.Default.Equals(Slots, other!.Slots);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TransformSlotInitializerSpec(TransformSlotInitializerSpec original)
			: base(original)
		{
			Slots = original.Slots;
		}

		public TransformSlotInitializerSpec()
		{
		}
	}
}
