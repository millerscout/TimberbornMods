using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CameraSystem
{
	internal record CameraServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CameraServiceSpec);
			}
		}

		[Serialize]
		public float HorizontalAngle { get; init; }

		[Serialize]
		public float VerticalAngle { get; init; }

		[Serialize]
		public FloatLimitsSpec VerticalAngleLimits { get; init; }

		[Serialize]
		public float ZoomLevel { get; init; }

		[Serialize]
		public float ZoomSpeed { get; init; }

		[Serialize]
		public float ZoomBase { get; init; }

		[Serialize]
		public float BaseDistance { get; init; }

		[Serialize]
		public FloatLimitsSpec DefaultZoomLimits { get; init; }

		[Serialize]
		public FloatLimitsSpec UnlockedZoomLimits { get; init; }

		[Serialize]
		public FloatLimitsSpec MapEditorZoomLimits { get; init; }

		[Serialize]
		public FloatLimitsSpec FreeModeZoomLimits { get; init; }

		[Serialize]
		public float MapMargin { get; init; }

		[Serialize]
		public float FreeModeMapMargin { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CameraServiceSpec");
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
			builder.Append("HorizontalAngle = ");
			builder.Append(HorizontalAngle.ToString());
			builder.Append(", VerticalAngle = ");
			builder.Append(VerticalAngle.ToString());
			builder.Append(", VerticalAngleLimits = ");
			builder.Append(VerticalAngleLimits);
			builder.Append(", ZoomLevel = ");
			builder.Append(ZoomLevel.ToString());
			builder.Append(", ZoomSpeed = ");
			builder.Append(ZoomSpeed.ToString());
			builder.Append(", ZoomBase = ");
			builder.Append(ZoomBase.ToString());
			builder.Append(", BaseDistance = ");
			builder.Append(BaseDistance.ToString());
			builder.Append(", DefaultZoomLimits = ");
			builder.Append(DefaultZoomLimits);
			builder.Append(", UnlockedZoomLimits = ");
			builder.Append(UnlockedZoomLimits);
			builder.Append(", MapEditorZoomLimits = ");
			builder.Append(MapEditorZoomLimits);
			builder.Append(", FreeModeZoomLimits = ");
			builder.Append(FreeModeZoomLimits);
			builder.Append(", MapMargin = ");
			builder.Append(MapMargin.ToString());
			builder.Append(", FreeModeMapMargin = ");
			builder.Append(FreeModeMapMargin.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(HorizontalAngle)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(VerticalAngle)) * -1521134295 + EqualityComparer<FloatLimitsSpec>.Default.GetHashCode(VerticalAngleLimits)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ZoomLevel)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ZoomSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ZoomBase)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BaseDistance)) * -1521134295 + EqualityComparer<FloatLimitsSpec>.Default.GetHashCode(DefaultZoomLimits)) * -1521134295 + EqualityComparer<FloatLimitsSpec>.Default.GetHashCode(UnlockedZoomLimits)) * -1521134295 + EqualityComparer<FloatLimitsSpec>.Default.GetHashCode(MapEditorZoomLimits)) * -1521134295 + EqualityComparer<FloatLimitsSpec>.Default.GetHashCode(FreeModeZoomLimits)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MapMargin)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FreeModeMapMargin);
		}

		[CompilerGenerated]
		public virtual bool Equals(CameraServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(HorizontalAngle, other!.HorizontalAngle) && EqualityComparer<float>.Default.Equals(VerticalAngle, other!.VerticalAngle) && EqualityComparer<FloatLimitsSpec>.Default.Equals(VerticalAngleLimits, other!.VerticalAngleLimits) && EqualityComparer<float>.Default.Equals(ZoomLevel, other!.ZoomLevel) && EqualityComparer<float>.Default.Equals(ZoomSpeed, other!.ZoomSpeed) && EqualityComparer<float>.Default.Equals(ZoomBase, other!.ZoomBase) && EqualityComparer<float>.Default.Equals(BaseDistance, other!.BaseDistance) && EqualityComparer<FloatLimitsSpec>.Default.Equals(DefaultZoomLimits, other!.DefaultZoomLimits) && EqualityComparer<FloatLimitsSpec>.Default.Equals(UnlockedZoomLimits, other!.UnlockedZoomLimits) && EqualityComparer<FloatLimitsSpec>.Default.Equals(MapEditorZoomLimits, other!.MapEditorZoomLimits) && EqualityComparer<FloatLimitsSpec>.Default.Equals(FreeModeZoomLimits, other!.FreeModeZoomLimits) && EqualityComparer<float>.Default.Equals(MapMargin, other!.MapMargin))
				{
					return EqualityComparer<float>.Default.Equals(FreeModeMapMargin, other!.FreeModeMapMargin);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CameraServiceSpec(CameraServiceSpec original)
			: base(original)
		{
			HorizontalAngle = original.HorizontalAngle;
			VerticalAngle = original.VerticalAngle;
			VerticalAngleLimits = original.VerticalAngleLimits;
			ZoomLevel = original.ZoomLevel;
			ZoomSpeed = original.ZoomSpeed;
			ZoomBase = original.ZoomBase;
			BaseDistance = original.BaseDistance;
			DefaultZoomLimits = original.DefaultZoomLimits;
			UnlockedZoomLimits = original.UnlockedZoomLimits;
			MapEditorZoomLimits = original.MapEditorZoomLimits;
			FreeModeZoomLimits = original.FreeModeZoomLimits;
			MapMargin = original.MapMargin;
			FreeModeMapMargin = original.FreeModeMapMargin;
		}

		public CameraServiceSpec()
		{
		}
	}
}
