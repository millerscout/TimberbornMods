using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.HazardousWeatherSystemUI
{
	internal record HazardousWeatherUISpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(HazardousWeatherUISpec);
			}
		}

		[Serialize]
		public int ApproachingNotificationDays { get; init; }

		[Serialize]
		public float MaxDayProgressLeftToNotify { get; init; }

		[Serialize]
		public float NotificationDuration { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("HazardousWeatherUISpec");
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
			builder.Append("ApproachingNotificationDays = ");
			builder.Append(ApproachingNotificationDays.ToString());
			builder.Append(", MaxDayProgressLeftToNotify = ");
			builder.Append(MaxDayProgressLeftToNotify.ToString());
			builder.Append(", NotificationDuration = ");
			builder.Append(NotificationDuration.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ApproachingNotificationDays)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxDayProgressLeftToNotify)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(NotificationDuration);
		}

		[CompilerGenerated]
		public virtual bool Equals(HazardousWeatherUISpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(ApproachingNotificationDays, other!.ApproachingNotificationDays) && EqualityComparer<float>.Default.Equals(MaxDayProgressLeftToNotify, other!.MaxDayProgressLeftToNotify))
				{
					return EqualityComparer<float>.Default.Equals(NotificationDuration, other!.NotificationDuration);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected HazardousWeatherUISpec(HazardousWeatherUISpec original)
			: base(original)
		{
			ApproachingNotificationDays = original.ApproachingNotificationDays;
			MaxDayProgressLeftToNotify = original.MaxDayProgressLeftToNotify;
			NotificationDuration = original.NotificationDuration;
		}

		public HazardousWeatherUISpec()
		{
		}
	}
}
