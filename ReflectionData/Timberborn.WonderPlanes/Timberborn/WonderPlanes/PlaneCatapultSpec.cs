using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.UnityEngineSpecs;

namespace Timberborn.WonderPlanes
{
	internal record PlaneCatapultSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlaneCatapultSpec);
			}
		}

		[Serialize]
		public AnimationCurveSpec SpeedCurve { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlaneCatapultSpec");
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
			builder.Append("SpeedCurve = ");
			builder.Append(SpeedCurve);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<AnimationCurveSpec>.Default.GetHashCode(SpeedCurve);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlaneCatapultSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<AnimationCurveSpec>.Default.Equals(SpeedCurve, other!.SpeedCurve);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlaneCatapultSpec(PlaneCatapultSpec original)
			: base(original)
		{
			SpeedCurve = original.SpeedCurve;
		}

		public PlaneCatapultSpec()
		{
		}
	}
}
