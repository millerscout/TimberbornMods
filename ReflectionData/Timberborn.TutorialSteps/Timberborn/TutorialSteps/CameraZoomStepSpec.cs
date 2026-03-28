using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record CameraZoomStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CameraZoomStepSpec);
			}
		}

		[Serialize]
		public ZoomDirection Direction { get; init; }

		[Serialize]
		public float Threshold { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CameraZoomStepSpec");
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
			builder.Append(", Threshold = ");
			builder.Append(Threshold.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ZoomDirection>.Default.GetHashCode(Direction)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Threshold);
		}

		[CompilerGenerated]
		public virtual bool Equals(CameraZoomStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ZoomDirection>.Default.Equals(Direction, other!.Direction))
				{
					return EqualityComparer<float>.Default.Equals(Threshold, other!.Threshold);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CameraZoomStepSpec(CameraZoomStepSpec original)
			: base(original)
		{
			Direction = original.Direction;
			Threshold = original.Threshold;
		}

		public CameraZoomStepSpec()
		{
		}
	}
}
