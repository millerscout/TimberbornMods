using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CameraSystem
{
	internal record MouseCameraControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MouseCameraControllerSpec);
			}
		}

		[Serialize]
		public float RmbRotationSpeed { get; init; }

		[Serialize]
		public float RmbRotationMinDistance { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MouseCameraControllerSpec");
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
			builder.Append("RmbRotationSpeed = ");
			builder.Append(RmbRotationSpeed.ToString());
			builder.Append(", RmbRotationMinDistance = ");
			builder.Append(RmbRotationMinDistance.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RmbRotationSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RmbRotationMinDistance);
		}

		[CompilerGenerated]
		public virtual bool Equals(MouseCameraControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(RmbRotationSpeed, other!.RmbRotationSpeed))
				{
					return EqualityComparer<float>.Default.Equals(RmbRotationMinDistance, other!.RmbRotationMinDistance);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MouseCameraControllerSpec(MouseCameraControllerSpec original)
			: base(original)
		{
			RmbRotationSpeed = original.RmbRotationSpeed;
			RmbRotationMinDistance = original.RmbRotationMinDistance;
		}

		public MouseCameraControllerSpec()
		{
		}
	}
}
