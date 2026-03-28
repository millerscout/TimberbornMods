using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Terraforming
{
	internal record DrillScrewBuilderSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DrillScrewBuilderSpec);
			}
		}

		[Serialize]
		public string ParentName { get; init; }

		[Serialize]
		public Vector3 AnchorPosition { get; init; }

		[Serialize]
		public float DrillRadius { get; init; }

		[Serialize]
		public string ScrewHeadPrefabPath { get; init; }

		[Serialize]
		public string ScrewAxisPrefabPath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DrillScrewBuilderSpec");
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
			builder.Append("ParentName = ");
			builder.Append((object)ParentName);
			builder.Append(", AnchorPosition = ");
			builder.Append(AnchorPosition.ToString());
			builder.Append(", DrillRadius = ");
			builder.Append(DrillRadius.ToString());
			builder.Append(", ScrewHeadPrefabPath = ");
			builder.Append((object)ScrewHeadPrefabPath);
			builder.Append(", ScrewAxisPrefabPath = ");
			builder.Append((object)ScrewAxisPrefabPath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParentName)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(AnchorPosition)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DrillRadius)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ScrewHeadPrefabPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ScrewAxisPrefabPath);
		}

		[CompilerGenerated]
		public virtual bool Equals(DrillScrewBuilderSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(ParentName, other!.ParentName) && EqualityComparer<Vector3>.Default.Equals(AnchorPosition, other!.AnchorPosition) && EqualityComparer<float>.Default.Equals(DrillRadius, other!.DrillRadius) && EqualityComparer<string>.Default.Equals(ScrewHeadPrefabPath, other!.ScrewHeadPrefabPath))
				{
					return EqualityComparer<string>.Default.Equals(ScrewAxisPrefabPath, other!.ScrewAxisPrefabPath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DrillScrewBuilderSpec(DrillScrewBuilderSpec original)
			: base(original)
		{
			ParentName = original.ParentName;
			AnchorPosition = original.AnchorPosition;
			DrillRadius = original.DrillRadius;
			ScrewHeadPrefabPath = original.ScrewHeadPrefabPath;
			ScrewAxisPrefabPath = original.ScrewAxisPrefabPath;
		}

		public DrillScrewBuilderSpec()
		{
		}
	}
}
