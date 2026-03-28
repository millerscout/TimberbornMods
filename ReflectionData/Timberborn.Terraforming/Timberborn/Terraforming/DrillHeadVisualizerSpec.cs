using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Terraforming
{
	internal record DrillHeadVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DrillHeadVisualizerSpec);
			}
		}

		[Serialize]
		public string HeadTransformName { get; init; }

		[Serialize]
		public float HeadOffset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DrillHeadVisualizerSpec");
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
			builder.Append("HeadTransformName = ");
			builder.Append((object)HeadTransformName);
			builder.Append(", HeadOffset = ");
			builder.Append(HeadOffset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HeadTransformName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(HeadOffset);
		}

		[CompilerGenerated]
		public virtual bool Equals(DrillHeadVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(HeadTransformName, other!.HeadTransformName))
				{
					return EqualityComparer<float>.Default.Equals(HeadOffset, other!.HeadOffset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DrillHeadVisualizerSpec(DrillHeadVisualizerSpec original)
			: base(original)
		{
			HeadTransformName = original.HeadTransformName;
			HeadOffset = original.HeadOffset;
		}

		public DrillHeadVisualizerSpec()
		{
		}
	}
}
