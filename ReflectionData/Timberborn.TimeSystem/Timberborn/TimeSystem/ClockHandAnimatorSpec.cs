using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TimeSystem
{
	internal record ClockHandAnimatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ClockHandAnimatorSpec);
			}
		}

		[Serialize]
		public float AngleOffset { get; init; }

		[Serialize]
		public string HandName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ClockHandAnimatorSpec");
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
			builder.Append("AngleOffset = ");
			builder.Append(AngleOffset.ToString());
			builder.Append(", HandName = ");
			builder.Append((object)HandName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(AngleOffset)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HandName);
		}

		[CompilerGenerated]
		public virtual bool Equals(ClockHandAnimatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(AngleOffset, other!.AngleOffset))
				{
					return EqualityComparer<string>.Default.Equals(HandName, other!.HandName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ClockHandAnimatorSpec(ClockHandAnimatorSpec original)
			: base(original)
		{
			AngleOffset = original.AngleOffset;
			HandName = original.HandName;
		}

		public ClockHandAnimatorSpec()
		{
		}
	}
}
