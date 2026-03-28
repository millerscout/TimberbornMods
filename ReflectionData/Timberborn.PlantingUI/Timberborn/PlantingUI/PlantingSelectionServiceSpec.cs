using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.PlantingUI
{
	internal record PlantingSelectionServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlantingSelectionServiceSpec);
			}
		}

		[Serialize]
		public Color PlantingToolTile { get; init; }

		[Serialize]
		public Color ToolActionTile { get; init; }

		[Serialize]
		public Color ToolNoActionTile { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlantingSelectionServiceSpec");
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
			builder.Append("PlantingToolTile = ");
			builder.Append(PlantingToolTile.ToString());
			builder.Append(", ToolActionTile = ");
			builder.Append(ToolActionTile.ToString());
			builder.Append(", ToolNoActionTile = ");
			builder.Append(ToolNoActionTile.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(PlantingToolTile)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ToolActionTile)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ToolNoActionTile);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlantingSelectionServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(PlantingToolTile, other!.PlantingToolTile) && EqualityComparer<Color>.Default.Equals(ToolActionTile, other!.ToolActionTile))
				{
					return EqualityComparer<Color>.Default.Equals(ToolNoActionTile, other!.ToolNoActionTile);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlantingSelectionServiceSpec(PlantingSelectionServiceSpec original)
			: base(original)
		{
			PlantingToolTile = original.PlantingToolTile;
			ToolActionTile = original.ToolActionTile;
			ToolNoActionTile = original.ToolNoActionTile;
		}

		public PlantingSelectionServiceSpec()
		{
		}
	}
}
