using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SlotSystem
{
	public record PatrollingSlotSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PatrollingSlotSpec);
			}
		}

		[Serialize]
		public float BaseMovementSpeed { get; init; }

		[Serialize]
		public float MaxRandomDeviationOfMovementSpeed { get; init; }

		[Serialize]
		public string SlotKeyword { get; init; }

		[Serialize]
		public string Animation { get; init; }

		[Serialize]
		public bool WaterSlot { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PatrollingSlotSpec");
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
			builder.Append("BaseMovementSpeed = ");
			builder.Append(BaseMovementSpeed.ToString());
			builder.Append(", MaxRandomDeviationOfMovementSpeed = ");
			builder.Append(MaxRandomDeviationOfMovementSpeed.ToString());
			builder.Append(", SlotKeyword = ");
			builder.Append((object)SlotKeyword);
			builder.Append(", Animation = ");
			builder.Append((object)Animation);
			builder.Append(", WaterSlot = ");
			builder.Append(WaterSlot.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BaseMovementSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxRandomDeviationOfMovementSpeed)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SlotKeyword)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Animation)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(WaterSlot);
		}

		[CompilerGenerated]
		public virtual bool Equals(PatrollingSlotSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<float>.Default.Equals(BaseMovementSpeed, other!.BaseMovementSpeed) && EqualityComparer<float>.Default.Equals(MaxRandomDeviationOfMovementSpeed, other!.MaxRandomDeviationOfMovementSpeed) && EqualityComparer<string>.Default.Equals(SlotKeyword, other!.SlotKeyword) && EqualityComparer<string>.Default.Equals(Animation, other!.Animation))
				{
					return EqualityComparer<bool>.Default.Equals(WaterSlot, other!.WaterSlot);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PatrollingSlotSpec(PatrollingSlotSpec original)
		{
			BaseMovementSpeed = original.BaseMovementSpeed;
			MaxRandomDeviationOfMovementSpeed = original.MaxRandomDeviationOfMovementSpeed;
			SlotKeyword = original.SlotKeyword;
			Animation = original.Animation;
			WaterSlot = original.WaterSlot;
		}

		public PatrollingSlotSpec()
		{
		}
	}
}
