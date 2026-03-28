using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WalkingSystem
{
	internal record SwimmingAnimatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SwimmingAnimatorSpec);
			}
		}

		[Serialize]
		public float LowerSwimmingDepthThreshold { get; init; }

		[Serialize]
		public float UpperSwimmingDepthThreshold { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SwimmingAnimatorSpec");
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
			builder.Append("LowerSwimmingDepthThreshold = ");
			builder.Append(LowerSwimmingDepthThreshold.ToString());
			builder.Append(", UpperSwimmingDepthThreshold = ");
			builder.Append(UpperSwimmingDepthThreshold.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(LowerSwimmingDepthThreshold)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(UpperSwimmingDepthThreshold);
		}

		[CompilerGenerated]
		public virtual bool Equals(SwimmingAnimatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(LowerSwimmingDepthThreshold, other!.LowerSwimmingDepthThreshold))
				{
					return EqualityComparer<float>.Default.Equals(UpperSwimmingDepthThreshold, other!.UpperSwimmingDepthThreshold);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SwimmingAnimatorSpec(SwimmingAnimatorSpec original)
			: base(original)
		{
			LowerSwimmingDepthThreshold = original.LowerSwimmingDepthThreshold;
			UpperSwimmingDepthThreshold = original.UpperSwimmingDepthThreshold;
		}

		public SwimmingAnimatorSpec()
		{
		}
	}
}
