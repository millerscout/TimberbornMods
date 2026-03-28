using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockObjectTools
{
	internal record BlockObjectDeletionToolSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectDeletionToolSpec);
			}
		}

		[Serialize]
		public Color DeletedObjectHighlightColor { get; init; }

		[Serialize]
		public Color DeletedAreaTileColor { get; init; }

		[Serialize]
		public Color DeletedAreaSideColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectDeletionToolSpec");
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
			builder.Append("DeletedObjectHighlightColor = ");
			builder.Append(DeletedObjectHighlightColor.ToString());
			builder.Append(", DeletedAreaTileColor = ");
			builder.Append(DeletedAreaTileColor.ToString());
			builder.Append(", DeletedAreaSideColor = ");
			builder.Append(DeletedAreaSideColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(DeletedObjectHighlightColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(DeletedAreaTileColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(DeletedAreaSideColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectDeletionToolSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(DeletedObjectHighlightColor, other!.DeletedObjectHighlightColor) && EqualityComparer<Color>.Default.Equals(DeletedAreaTileColor, other!.DeletedAreaTileColor))
				{
					return EqualityComparer<Color>.Default.Equals(DeletedAreaSideColor, other!.DeletedAreaSideColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectDeletionToolSpec(BlockObjectDeletionToolSpec original)
			: base(original)
		{
			DeletedObjectHighlightColor = original.DeletedObjectHighlightColor;
			DeletedAreaTileColor = original.DeletedAreaTileColor;
			DeletedAreaSideColor = original.DeletedAreaSideColor;
		}

		public BlockObjectDeletionToolSpec()
		{
		}
	}
}
