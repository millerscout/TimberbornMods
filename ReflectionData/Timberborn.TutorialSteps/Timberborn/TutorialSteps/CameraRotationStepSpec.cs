using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record CameraRotationStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CameraRotationStepSpec);
			}
		}

		[Serialize]
		public RotationDirection Direction { get; init; }

		[Serialize]
		public float Angle { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CameraRotationStepSpec");
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
			builder.Append("Direction = ");
			builder.Append(Direction.ToString());
			builder.Append(", Angle = ");
			builder.Append(Angle.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<RotationDirection>.Default.GetHashCode(Direction)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Angle);
		}

		[CompilerGenerated]
		public virtual bool Equals(CameraRotationStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<RotationDirection>.Default.Equals(Direction, other!.Direction))
				{
					return EqualityComparer<float>.Default.Equals(Angle, other!.Angle);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CameraRotationStepSpec(CameraRotationStepSpec original)
			: base(original)
		{
			Direction = original.Direction;
			Angle = original.Angle;
		}

		public CameraRotationStepSpec()
		{
		}
	}
}
