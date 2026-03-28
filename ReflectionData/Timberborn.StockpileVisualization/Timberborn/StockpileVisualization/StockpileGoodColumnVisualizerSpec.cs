using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.StockpileVisualization
{
	internal record StockpileGoodColumnVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StockpileGoodColumnVisualizerSpec);
			}
		}

		[Serialize]
		public Vector3 CenterOffset { get; init; }

		[Serialize]
		public string GoodVisualizationId { get; init; }

		[Serialize]
		public string GoodVisualizationVariant { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StockpileGoodColumnVisualizerSpec");
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
			builder.Append(", GoodVisualizationId = ");
			builder.Append((object)GoodVisualizationId);
			builder.Append(", GoodVisualizationVariant = ");
			builder.Append((object)GoodVisualizationVariant);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(CenterOffset)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodVisualizationId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodVisualizationVariant);
		}

		[CompilerGenerated]
		public virtual bool Equals(StockpileGoodColumnVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3>.Default.Equals(CenterOffset, other!.CenterOffset) && EqualityComparer<string>.Default.Equals(GoodVisualizationId, other!.GoodVisualizationId))
				{
					return EqualityComparer<string>.Default.Equals(GoodVisualizationVariant, other!.GoodVisualizationVariant);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected StockpileGoodColumnVisualizerSpec(StockpileGoodColumnVisualizerSpec original)
			: base(original)
		{
			CenterOffset = original.CenterOffset;
			GoodVisualizationId = original.GoodVisualizationId;
			GoodVisualizationVariant = original.GoodVisualizationVariant;
		}

		public StockpileGoodColumnVisualizerSpec()
		{
		}
	}
}
