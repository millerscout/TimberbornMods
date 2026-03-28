using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.QuickNotificationSystem
{
	internal record QuickNotificationSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(QuickNotificationSpec);
			}
		}

		[Serialize]
		public float Duration { get; init; }

		[Serialize]
		public float ExtendedDuration { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("QuickNotificationSpec");
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
			builder.Append("Duration = ");
			builder.Append(Duration.ToString());
			builder.Append(", ExtendedDuration = ");
			builder.Append(ExtendedDuration.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Duration)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ExtendedDuration);
		}

		[CompilerGenerated]
		public virtual bool Equals(QuickNotificationSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(Duration, other!.Duration))
				{
					return EqualityComparer<float>.Default.Equals(ExtendedDuration, other!.ExtendedDuration);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected QuickNotificationSpec(QuickNotificationSpec original)
			: base(original)
		{
			Duration = original.Duration;
			ExtendedDuration = original.ExtendedDuration;
		}

		public QuickNotificationSpec()
		{
		}
	}
}
