using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.StockpileVisualization
{
	internal record StockpilePlaneVisualization
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StockpilePlaneVisualization);
			}
		}

		[Serialize]
		public Vector3 CenterOffset { get; init; }

		[Serialize]
		public Vector2 MovementRange { get; init; }

		[Serialize]
		public string GoodVisualizationId { get; init; }

		[Serialize]
		public string GoodVisualizationVariant { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StockpilePlaneVisualization");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("CenterOffset = ");
			builder.Append(CenterOffset.ToString());
			builder.Append(", MovementRange = ");
			builder.Append(MovementRange.ToString());
			builder.Append(", GoodVisualizationId = ");
			builder.Append((object)GoodVisualizationId);
			builder.Append(", GoodVisualizationVariant = ");
			builder.Append((object)GoodVisualizationVariant);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(CenterOffset)) * -1521134295 + EqualityComparer<Vector2>.Default.GetHashCode(MovementRange)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodVisualizationId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodVisualizationVariant);
		}

		[CompilerGenerated]
		public virtual bool Equals(StockpilePlaneVisualization? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Vector3>.Default.Equals(CenterOffset, other!.CenterOffset) && EqualityComparer<Vector2>.Default.Equals(MovementRange, other!.MovementRange) && EqualityComparer<string>.Default.Equals(GoodVisualizationId, other!.GoodVisualizationId))
				{
					return EqualityComparer<string>.Default.Equals(GoodVisualizationVariant, other!.GoodVisualizationVariant);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected StockpilePlaneVisualization(StockpilePlaneVisualization original)
		{
			CenterOffset = original.CenterOffset;
			MovementRange = original.MovementRange;
			GoodVisualizationId = original.GoodVisualizationId;
			GoodVisualizationVariant = original.GoodVisualizationVariant;
		}

		public StockpilePlaneVisualization()
		{
		}
	}
}
