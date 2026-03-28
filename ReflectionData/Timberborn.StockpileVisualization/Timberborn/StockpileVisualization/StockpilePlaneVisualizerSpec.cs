using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.StockpileVisualization
{
	internal record StockpilePlaneVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StockpilePlaneVisualizerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<StockpilePlaneVisualization> StockpilePlaneVisualizations { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StockpilePlaneVisualizerSpec");
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
			builder.Append("StockpilePlaneVisualizations = ");
			builder.Append(StockpilePlaneVisualizations.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<StockpilePlaneVisualization>>.Default.GetHashCode(StockpilePlaneVisualizations);
		}

		[CompilerGenerated]
		public virtual bool Equals(StockpilePlaneVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<StockpilePlaneVisualization>>.Default.Equals(StockpilePlaneVisualizations, other!.StockpilePlaneVisualizations);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected StockpilePlaneVisualizerSpec(StockpilePlaneVisualizerSpec original)
			: base(original)
		{
			StockpilePlaneVisualizations = original.StockpilePlaneVisualizations;
		}

		public StockpilePlaneVisualizerSpec()
		{
		}
	}
}
