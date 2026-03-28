using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.MapStateSystem
{
	public record MapSizeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MapSizeSpec);
			}
		}

		[Serialize]
		public Vector2Int DefaultMapSize { get; init; }

		[Serialize]
		public int MinMapSize { get; init; }

		[Serialize]
		public int MaxMapSize { get; init; }

		[Serialize]
		public int MaxMapEditorTerrainHeight { get; init; }

		[Serialize]
		public int MaxGameTerrainHeight { get; init; }

		[Serialize]
		public int MaxHeightAboveTerrain { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MapSizeSpec");
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
			builder.Append("DefaultMapSize = ");
			builder.Append(DefaultMapSize.ToString());
			builder.Append(", MinMapSize = ");
			builder.Append(MinMapSize.ToString());
			builder.Append(", MaxMapSize = ");
			builder.Append(MaxMapSize.ToString());
			builder.Append(", MaxMapEditorTerrainHeight = ");
			builder.Append(MaxMapEditorTerrainHeight.ToString());
			builder.Append(", MaxGameTerrainHeight = ");
			builder.Append(MaxGameTerrainHeight.ToString());
			builder.Append(", MaxHeightAboveTerrain = ");
			builder.Append(MaxHeightAboveTerrain.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<Vector2Int>.Default.GetHashCode(DefaultMapSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MinMapSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxMapSize)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxMapEditorTerrainHeight)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxGameTerrainHeight)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxHeightAboveTerrain);
		}

		[CompilerGenerated]
		public virtual bool Equals(MapSizeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector2Int>.Default.Equals(DefaultMapSize, other!.DefaultMapSize) && EqualityComparer<int>.Default.Equals(MinMapSize, other!.MinMapSize) && EqualityComparer<int>.Default.Equals(MaxMapSize, other!.MaxMapSize) && EqualityComparer<int>.Default.Equals(MaxMapEditorTerrainHeight, other!.MaxMapEditorTerrainHeight) && EqualityComparer<int>.Default.Equals(MaxGameTerrainHeight, other!.MaxGameTerrainHeight))
				{
					return EqualityComparer<int>.Default.Equals(MaxHeightAboveTerrain, other!.MaxHeightAboveTerrain);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MapSizeSpec(MapSizeSpec original)
			: base(original)
		{
			DefaultMapSize = original.DefaultMapSize;
			MinMapSize = original.MinMapSize;
			MaxMapSize = original.MaxMapSize;
			MaxMapEditorTerrainHeight = original.MaxMapEditorTerrainHeight;
			MaxGameTerrainHeight = original.MaxGameTerrainHeight;
			MaxHeightAboveTerrain = original.MaxHeightAboveTerrain;
		}

		public MapSizeSpec()
		{
		}
	}
}
