using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockObstacles
{
	internal record LayeredBlockObstacleVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(LayeredBlockObstacleVisualizerSpec);
			}
		}

		[Serialize]
		public string PositionTransformName { get; init; }

		[Serialize]
		public string ScaleTransformName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LayeredBlockObstacleVisualizerSpec");
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
			builder.Append("PositionTransformName = ");
			builder.Append((object)PositionTransformName);
			builder.Append(", ScaleTransformName = ");
			builder.Append((object)ScaleTransformName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PositionTransformName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ScaleTransformName);
		}

		[CompilerGenerated]
		public virtual bool Equals(LayeredBlockObstacleVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(PositionTransformName, other!.PositionTransformName))
				{
					return EqualityComparer<string>.Default.Equals(ScaleTransformName, other!.ScaleTransformName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected LayeredBlockObstacleVisualizerSpec(LayeredBlockObstacleVisualizerSpec original)
			: base(original)
		{
			PositionTransformName = original.PositionTransformName;
			ScaleTransformName = original.ScaleTransformName;
		}

		public LayeredBlockObstacleVisualizerSpec()
		{
		}
	}
}
