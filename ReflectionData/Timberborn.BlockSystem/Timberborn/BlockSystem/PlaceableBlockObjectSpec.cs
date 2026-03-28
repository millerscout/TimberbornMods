using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.TemplateSystem;

namespace Timberborn.BlockSystem
{
	public record PlaceableBlockObjectSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlaceableBlockObjectSpec);
			}
		}

		[Serialize]
		public string ToolGroupId { get; init; }

		[Serialize]
		public int ToolOrder { get; init; }

		[Serialize]
		public ToolShapes ToolShape { get; init; }

		[Serialize]
		public BlockObjectLayout Layout { get; init; }

		[Serialize]
		public CustomPivotSpec CustomPivot { get; init; }

		[Serialize]
		public bool CanBeAttachedToTerrainSide { get; init; }

		[Serialize]
		public bool DevModeTool { get; init; }

		public bool UsableWithCurrentFeatureToggles => GetSpec<TemplateSpec>().UsableWithCurrentFeatureToggles;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlaceableBlockObjectSpec");
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
			builder.Append("ToolGroupId = ");
			builder.Append((object)ToolGroupId);
			builder.Append(", ToolOrder = ");
			builder.Append(ToolOrder.ToString());
			builder.Append(", ToolShape = ");
			builder.Append(ToolShape.ToString());
			builder.Append(", Layout = ");
			builder.Append(Layout.ToString());
			builder.Append(", CustomPivot = ");
			builder.Append(CustomPivot);
			builder.Append(", CanBeAttachedToTerrainSide = ");
			builder.Append(CanBeAttachedToTerrainSide.ToString());
			builder.Append(", DevModeTool = ");
			builder.Append(DevModeTool.ToString());
			builder.Append(", UsableWithCurrentFeatureToggles = ");
			builder.Append(UsableWithCurrentFeatureToggles.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ToolGroupId)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ToolOrder)) * -1521134295 + EqualityComparer<ToolShapes>.Default.GetHashCode(ToolShape)) * -1521134295 + EqualityComparer<BlockObjectLayout>.Default.GetHashCode(Layout)) * -1521134295 + EqualityComparer<CustomPivotSpec>.Default.GetHashCode(CustomPivot)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(CanBeAttachedToTerrainSide)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DevModeTool);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlaceableBlockObjectSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(ToolGroupId, other!.ToolGroupId) && EqualityComparer<int>.Default.Equals(ToolOrder, other!.ToolOrder) && EqualityComparer<ToolShapes>.Default.Equals(ToolShape, other!.ToolShape) && EqualityComparer<BlockObjectLayout>.Default.Equals(Layout, other!.Layout) && EqualityComparer<CustomPivotSpec>.Default.Equals(CustomPivot, other!.CustomPivot) && EqualityComparer<bool>.Default.Equals(CanBeAttachedToTerrainSide, other!.CanBeAttachedToTerrainSide))
				{
					return EqualityComparer<bool>.Default.Equals(DevModeTool, other!.DevModeTool);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlaceableBlockObjectSpec(PlaceableBlockObjectSpec original)
			: base(original)
		{
			ToolGroupId = original.ToolGroupId;
			ToolOrder = original.ToolOrder;
			ToolShape = original.ToolShape;
			Layout = original.Layout;
			CustomPivot = original.CustomPivot;
			CanBeAttachedToTerrainSide = original.CanBeAttachedToTerrainSide;
			DevModeTool = original.DevModeTool;
		}

		public PlaceableBlockObjectSpec()
		{
		}
	}
}
