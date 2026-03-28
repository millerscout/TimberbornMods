using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CameraSystem
{
	internal record KeyboardCameraControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(KeyboardCameraControllerSpec);
			}
		}

		[Serialize]
		public int JumpRotationAngle { get; init; }

		[Serialize]
		public int JumpRotationSpeedInAnglePerUpdate { get; init; }

		[Serialize]
		public float BaseZoomSpeed { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("KeyboardCameraControllerSpec");
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
			builder.Append("JumpRotationAngle = ");
			builder.Append(JumpRotationAngle.ToString());
			builder.Append(", JumpRotationSpeedInAnglePerUpdate = ");
			builder.Append(JumpRotationSpeedInAnglePerUpdate.ToString());
			builder.Append(", BaseZoomSpeed = ");
			builder.Append(BaseZoomSpeed.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(JumpRotationAngle)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(JumpRotationSpeedInAnglePerUpdate)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BaseZoomSpeed);
		}

		[CompilerGenerated]
		public virtual bool Equals(KeyboardCameraControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(JumpRotationAngle, other!.JumpRotationAngle) && EqualityComparer<int>.Default.Equals(JumpRotationSpeedInAnglePerUpdate, other!.JumpRotationSpeedInAnglePerUpdate))
				{
					return EqualityComparer<float>.Default.Equals(BaseZoomSpeed, other!.BaseZoomSpeed);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected KeyboardCameraControllerSpec(KeyboardCameraControllerSpec original)
			: base(original)
		{
			JumpRotationAngle = original.JumpRotationAngle;
			JumpRotationSpeedInAnglePerUpdate = original.JumpRotationSpeedInAnglePerUpdate;
			BaseZoomSpeed = original.BaseZoomSpeed;
		}

		public KeyboardCameraControllerSpec()
		{
		}
	}
}
