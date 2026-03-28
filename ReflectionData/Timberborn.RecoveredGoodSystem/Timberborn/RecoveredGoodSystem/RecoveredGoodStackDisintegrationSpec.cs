using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.RecoveredGoodSystem
{
	internal record RecoveredGoodStackDisintegrationSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RecoveredGoodStackDisintegrationSpec);
			}
		}

		[Serialize]
		public float DaysToDisintegrate { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RecoveredGoodStackDisintegrationSpec");
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
			builder.Append("DaysToDisintegrate = ");
			builder.Append(DaysToDisintegrate.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DaysToDisintegrate);
		}

		[CompilerGenerated]
		public virtual bool Equals(RecoveredGoodStackDisintegrationSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(DaysToDisintegrate, other!.DaysToDisintegrate);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RecoveredGoodStackDisintegrationSpec(RecoveredGoodStackDisintegrationSpec original)
			: base(original)
		{
			DaysToDisintegrate = original.DaysToDisintegrate;
		}

		public RecoveredGoodStackDisintegrationSpec()
		{
		}
	}
}
