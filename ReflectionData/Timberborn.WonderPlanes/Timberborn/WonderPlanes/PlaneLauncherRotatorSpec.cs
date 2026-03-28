using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.UnityEngineSpecs;

namespace Timberborn.WonderPlanes
{
	internal record PlaneLauncherRotatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlaneLauncherRotatorSpec);
			}
		}

		[Serialize]
		public string RotatedElementName { get; init; }

		[Serialize]
		public float FullRotationDuration { get; init; }

		[Serialize]
		public AnimationCurveSpec RotationCurve { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlaneLauncherRotatorSpec");
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
			builder.Append("RotatedElementName = ");
			builder.Append((object)RotatedElementName);
			builder.Append(", FullRotationDuration = ");
			builder.Append(FullRotationDuration.ToString());
			builder.Append(", RotationCurve = ");
			builder.Append(RotationCurve);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RotatedElementName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FullRotationDuration)) * -1521134295 + EqualityComparer<AnimationCurveSpec>.Default.GetHashCode(RotationCurve);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlaneLauncherRotatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(RotatedElementName, other!.RotatedElementName) && EqualityComparer<float>.Default.Equals(FullRotationDuration, other!.FullRotationDuration))
				{
					return EqualityComparer<AnimationCurveSpec>.Default.Equals(RotationCurve, other!.RotationCurve);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlaneLauncherRotatorSpec(PlaneLauncherRotatorSpec original)
			: base(original)
		{
			RotatedElementName = original.RotatedElementName;
			FullRotationDuration = original.FullRotationDuration;
			RotationCurve = original.RotationCurve;
		}

		public PlaneLauncherRotatorSpec()
		{
		}
	}
}
