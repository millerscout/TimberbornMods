using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterBuildings
{
	internal record StreamGaugeAnimationControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StreamGaugeAnimationControllerSpec);
			}
		}

		[Serialize]
		public string MarkerName { get; init; }

		[Serialize]
		public float MaxHeight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StreamGaugeAnimationControllerSpec");
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
			builder.Append("MarkerName = ");
			builder.Append((object)MarkerName);
			builder.Append(", MaxHeight = ");
			builder.Append(MaxHeight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MarkerName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxHeight);
		}

		[CompilerGenerated]
		public virtual bool Equals(StreamGaugeAnimationControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(MarkerName, other!.MarkerName))
				{
					return EqualityComparer<float>.Default.Equals(MaxHeight, other!.MaxHeight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected StreamGaugeAnimationControllerSpec(StreamGaugeAnimationControllerSpec original)
			: base(original)
		{
			MarkerName = original.MarkerName;
			MaxHeight = original.MaxHeight;
		}

		public StreamGaugeAnimationControllerSpec()
		{
		}
	}
}
