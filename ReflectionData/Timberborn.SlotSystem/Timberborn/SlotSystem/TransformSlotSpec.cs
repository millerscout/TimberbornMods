using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	public record TransformSlotSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TransformSlotSpec);
			}
		}

		[Serialize]
		public string SlotKeyword { get; init; }

		[Serialize]
		public string Animation { get; init; }

		[Serialize]
		public bool Inanimate { get; init; }

		[Serialize]
		public bool RandomizeYRotation { get; init; }

		[Serialize]
		public bool WaterSlot { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TransformSlotSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("SlotKeyword = ");
			builder.Append((object)SlotKeyword);
			builder.Append(", Animation = ");
			builder.Append((object)Animation);
			builder.Append(", Inanimate = ");
			builder.Append(Inanimate.ToString());
			builder.Append(", RandomizeYRotation = ");
			builder.Append(RandomizeYRotation.ToString());
			builder.Append(", WaterSlot = ");
			builder.Append(WaterSlot.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SlotKeyword)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Animation)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Inanimate)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(RandomizeYRotation)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(WaterSlot);
		}

		[CompilerGenerated]
		public virtual bool Equals(TransformSlotSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(SlotKeyword, other!.SlotKeyword) && EqualityComparer<string>.Default.Equals(Animation, other!.Animation) && EqualityComparer<bool>.Default.Equals(Inanimate, other!.Inanimate) && EqualityComparer<bool>.Default.Equals(RandomizeYRotation, other!.RandomizeYRotation))
				{
					return EqualityComparer<bool>.Default.Equals(WaterSlot, other!.WaterSlot);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TransformSlotSpec(TransformSlotSpec original)
		{
			SlotKeyword = original.SlotKeyword;
			Animation = original.Animation;
			Inanimate = original.Inanimate;
			RandomizeYRotation = original.RandomizeYRotation;
			WaterSlot = original.WaterSlot;
		}

		public TransformSlotSpec()
		{
		}
	}
}
