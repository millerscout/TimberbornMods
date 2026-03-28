using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterObjects
{
	internal record FinishableWaterObstacleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FinishableWaterObstacleSpec);
			}
		}

		[Serialize]
		public float Height { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FinishableWaterObstacleSpec");
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
			builder.Append("Height = ");
			builder.Append(Height.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Height);
		}

		[CompilerGenerated]
		public virtual bool Equals(FinishableWaterObstacleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(Height, other!.Height);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FinishableWaterObstacleSpec(FinishableWaterObstacleSpec original)
			: base(original)
		{
			Height = original.Height;
		}

		public FinishableWaterObstacleSpec()
		{
		}
	}
}
