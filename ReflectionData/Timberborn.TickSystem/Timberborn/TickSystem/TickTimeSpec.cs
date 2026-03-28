using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TickSystem
{
	internal record TickTimeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TickTimeSpec);
			}
		}

		[Serialize]
		public float TickIntervalInSeconds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TickTimeSpec");
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
			builder.Append("TickIntervalInSeconds = ");
			builder.Append(TickIntervalInSeconds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(TickIntervalInSeconds);
		}

		[CompilerGenerated]
		public virtual bool Equals(TickTimeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(TickIntervalInSeconds, other!.TickIntervalInSeconds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TickTimeSpec(TickTimeSpec original)
			: base(original)
		{
			TickIntervalInSeconds = original.TickIntervalInSeconds;
		}

		public TickTimeSpec()
		{
		}
	}
}
