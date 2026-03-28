using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CameraSystem
{
	internal record EdgePanningCameraTargetPickerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EdgePanningCameraTargetPickerSpec);
			}
		}

		[Serialize]
		public float MinBaseSpeed { get; init; }

		[Serialize]
		public float MaxBaseSpeed { get; init; }

		[Serialize]
		public float FastMovementSpeedBonus { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EdgePanningCameraTargetPickerSpec");
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
			builder.Append("MinBaseSpeed = ");
			builder.Append(MinBaseSpeed.ToString());
			builder.Append(", MaxBaseSpeed = ");
			builder.Append(MaxBaseSpeed.ToString());
			builder.Append(", FastMovementSpeedBonus = ");
			builder.Append(FastMovementSpeedBonus.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinBaseSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxBaseSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FastMovementSpeedBonus);
		}

		[CompilerGenerated]
		public virtual bool Equals(EdgePanningCameraTargetPickerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MinBaseSpeed, other!.MinBaseSpeed) && EqualityComparer<float>.Default.Equals(MaxBaseSpeed, other!.MaxBaseSpeed))
				{
					return EqualityComparer<float>.Default.Equals(FastMovementSpeedBonus, other!.FastMovementSpeedBonus);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected EdgePanningCameraTargetPickerSpec(EdgePanningCameraTargetPickerSpec original)
			: base(original)
		{
			MinBaseSpeed = original.MinBaseSpeed;
			MaxBaseSpeed = original.MaxBaseSpeed;
			FastMovementSpeedBonus = original.FastMovementSpeedBonus;
		}

		public EdgePanningCameraTargetPickerSpec()
		{
		}
	}
}
