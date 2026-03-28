using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterBuildings
{
	internal record StreamGaugeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StreamGaugeSpec);
			}
		}

		[Serialize]
		public float MaxWaterLevel { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StreamGaugeSpec");
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
			builder.Append("MaxWaterLevel = ");
			builder.Append(MaxWaterLevel.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWaterLevel);
		}

		[CompilerGenerated]
		public virtual bool Equals(StreamGaugeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(MaxWaterLevel, other!.MaxWaterLevel);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected StreamGaugeSpec(StreamGaugeSpec original)
			: base(original)
		{
			MaxWaterLevel = original.MaxWaterLevel;
		}

		public StreamGaugeSpec()
		{
		}
	}
}
