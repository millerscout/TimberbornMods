using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.GameDistrictsUI
{
	internal record DistrictConnectionLineRendererSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DistrictConnectionLineRendererSpec);
			}
		}

		[Serialize]
		public AssetRef<LineRenderer> LineRendererPrefab { get; init; }

		[Serialize]
		public float ArcAngle { get; init; }

		[Serialize]
		public int CurvePoints { get; init; }

		[Serialize]
		public float LineCutoff { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DistrictConnectionLineRendererSpec");
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
			builder.Append("LineRendererPrefab = ");
			builder.Append(LineRendererPrefab);
			builder.Append(", ArcAngle = ");
			builder.Append(ArcAngle.ToString());
			builder.Append(", CurvePoints = ");
			builder.Append(CurvePoints.ToString());
			builder.Append(", LineCutoff = ");
			builder.Append(LineCutoff.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<LineRenderer>>.Default.GetHashCode(LineRendererPrefab)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ArcAngle)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CurvePoints)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(LineCutoff);
		}

		[CompilerGenerated]
		public virtual bool Equals(DistrictConnectionLineRendererSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<LineRenderer>>.Default.Equals(LineRendererPrefab, other!.LineRendererPrefab) && EqualityComparer<float>.Default.Equals(ArcAngle, other!.ArcAngle) && EqualityComparer<int>.Default.Equals(CurvePoints, other!.CurvePoints))
				{
					return EqualityComparer<float>.Default.Equals(LineCutoff, other!.LineCutoff);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DistrictConnectionLineRendererSpec(DistrictConnectionLineRendererSpec original)
			: base(original)
		{
			LineRendererPrefab = original.LineRendererPrefab;
			ArcAngle = original.ArcAngle;
			CurvePoints = original.CurvePoints;
			LineCutoff = original.LineCutoff;
		}

		public DistrictConnectionLineRendererSpec()
		{
		}
	}
}
