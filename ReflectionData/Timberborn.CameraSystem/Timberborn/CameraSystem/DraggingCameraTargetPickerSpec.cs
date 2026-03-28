using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CameraSystem
{
	internal record DraggingCameraTargetPickerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DraggingCameraTargetPickerSpec);
			}
		}

		[Serialize]
		public float MovementSpeed { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DraggingCameraTargetPickerSpec");
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
			builder.Append("MovementSpeed = ");
			builder.Append(MovementSpeed.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MovementSpeed);
		}

		[CompilerGenerated]
		public virtual bool Equals(DraggingCameraTargetPickerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(MovementSpeed, other!.MovementSpeed);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DraggingCameraTargetPickerSpec(DraggingCameraTargetPickerSpec original)
			: base(original)
		{
			MovementSpeed = original.MovementSpeed;
		}

		public DraggingCameraTargetPickerSpec()
		{
		}
	}
}
