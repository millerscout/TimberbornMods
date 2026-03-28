using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.ForestryUI
{
	internal record TreeCuttingColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TreeCuttingColorsSpec);
			}
		}

		[Serialize]
		public Color ToolActionTile { get; init; }

		[Serialize]
		public Color ToolNoActionTile { get; init; }

		[Serialize]
		public Color CuttingAreaTile { get; init; }

		[Serialize]
		public Color CuttingAreaHighlight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TreeCuttingColorsSpec");
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
			builder.Append("ToolActionTile = ");
			builder.Append(ToolActionTile.ToString());
			builder.Append(", ToolNoActionTile = ");
			builder.Append(ToolNoActionTile.ToString());
			builder.Append(", CuttingAreaTile = ");
			builder.Append(CuttingAreaTile.ToString());
			builder.Append(", CuttingAreaHighlight = ");
			builder.Append(CuttingAreaHighlight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ToolActionTile)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ToolNoActionTile)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(CuttingAreaTile)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(CuttingAreaHighlight);
		}

		[CompilerGenerated]
		public virtual bool Equals(TreeCuttingColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(ToolActionTile, other!.ToolActionTile) && EqualityComparer<Color>.Default.Equals(ToolNoActionTile, other!.ToolNoActionTile) && EqualityComparer<Color>.Default.Equals(CuttingAreaTile, other!.CuttingAreaTile))
				{
					return EqualityComparer<Color>.Default.Equals(CuttingAreaHighlight, other!.CuttingAreaHighlight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TreeCuttingColorsSpec(TreeCuttingColorsSpec original)
			: base(original)
		{
			ToolActionTile = original.ToolActionTile;
			ToolNoActionTile = original.ToolNoActionTile;
			CuttingAreaTile = original.CuttingAreaTile;
			CuttingAreaHighlight = original.CuttingAreaHighlight;
		}

		public TreeCuttingColorsSpec()
		{
		}
	}
}
