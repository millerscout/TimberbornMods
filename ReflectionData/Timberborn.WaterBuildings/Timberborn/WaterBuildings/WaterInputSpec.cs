using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterBuildings
{
	public record WaterInputSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterInputSpec);
			}
		}

		[Serialize]
		public Vector3Int WaterInputCoordinates { get; init; }

		[Serialize]
		public int MaxDepth { get; init; }

		[Serialize]
		public string PipeSegmentPrefabPath { get; init; }

		[Serialize]
		public string PipeParentName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterInputSpec");
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
			builder.Append("WaterInputCoordinates = ");
			builder.Append(WaterInputCoordinates.ToString());
			builder.Append(", MaxDepth = ");
			builder.Append(MaxDepth.ToString());
			builder.Append(", PipeSegmentPrefabPath = ");
			builder.Append((object)PipeSegmentPrefabPath);
			builder.Append(", PipeParentName = ");
			builder.Append((object)PipeParentName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(WaterInputCoordinates)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxDepth)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PipeSegmentPrefabPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PipeParentName);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterInputSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3Int>.Default.Equals(WaterInputCoordinates, other!.WaterInputCoordinates) && EqualityComparer<int>.Default.Equals(MaxDepth, other!.MaxDepth) && EqualityComparer<string>.Default.Equals(PipeSegmentPrefabPath, other!.PipeSegmentPrefabPath))
				{
					return EqualityComparer<string>.Default.Equals(PipeParentName, other!.PipeParentName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterInputSpec(WaterInputSpec original)
			: base(original)
		{
			WaterInputCoordinates = original.WaterInputCoordinates;
			MaxDepth = original.MaxDepth;
			PipeSegmentPrefabPath = original.PipeSegmentPrefabPath;
			PipeParentName = original.PipeParentName;
		}

		public WaterInputSpec()
		{
		}
	}
}
