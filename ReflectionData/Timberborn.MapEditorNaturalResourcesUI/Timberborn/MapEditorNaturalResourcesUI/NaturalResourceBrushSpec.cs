using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.MapEditorNaturalResourcesUI
{
	internal record NaturalResourceBrushSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NaturalResourceBrushSpec);
			}
		}

		[Serialize]
		public Color RemovalTileColor { get; init; }

		[Serialize]
		public Color SpawnTileColor { get; init; }

		[Serialize]
		public string DefaultNaturalResourceId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NaturalResourceBrushSpec");
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
			builder.Append("RemovalTileColor = ");
			builder.Append(RemovalTileColor.ToString());
			builder.Append(", SpawnTileColor = ");
			builder.Append(SpawnTileColor.ToString());
			builder.Append(", DefaultNaturalResourceId = ");
			builder.Append((object)DefaultNaturalResourceId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(RemovalTileColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(SpawnTileColor)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DefaultNaturalResourceId);
		}

		[CompilerGenerated]
		public virtual bool Equals(NaturalResourceBrushSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(RemovalTileColor, other!.RemovalTileColor) && EqualityComparer<Color>.Default.Equals(SpawnTileColor, other!.SpawnTileColor))
				{
					return EqualityComparer<string>.Default.Equals(DefaultNaturalResourceId, other!.DefaultNaturalResourceId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NaturalResourceBrushSpec(NaturalResourceBrushSpec original)
			: base(original)
		{
			RemovalTileColor = original.RemovalTileColor;
			SpawnTileColor = original.SpawnTileColor;
			DefaultNaturalResourceId = original.DefaultNaturalResourceId;
		}

		public NaturalResourceBrushSpec()
		{
		}
	}
}
