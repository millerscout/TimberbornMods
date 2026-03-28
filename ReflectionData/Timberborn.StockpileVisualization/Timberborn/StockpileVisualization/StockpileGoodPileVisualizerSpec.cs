using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.StockpileVisualization
{
	internal record StockpileGoodPileVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StockpileGoodPileVisualizerSpec);
			}
		}

		[Serialize]
		public Vector3 CenterOffset { get; init; }

		[Serialize]
		public ImmutableArray<string> GoodPileVisualizations { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StockpileGoodPileVisualizerSpec");
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
			builder.Append("CenterOffset = ");
			builder.Append(CenterOffset.ToString());
			builder.Append(", GoodPileVisualizations = ");
			builder.Append(GoodPileVisualizations.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(CenterOffset)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(GoodPileVisualizations);
		}

		[CompilerGenerated]
		public virtual bool Equals(StockpileGoodPileVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3>.Default.Equals(CenterOffset, other!.CenterOffset))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(GoodPileVisualizations, other!.GoodPileVisualizations);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected StockpileGoodPileVisualizerSpec(StockpileGoodPileVisualizerSpec original)
			: base(original)
		{
			CenterOffset = original.CenterOffset;
			GoodPileVisualizations = original.GoodPileVisualizations;
		}

		public StockpileGoodPileVisualizerSpec()
		{
		}
	}
}
