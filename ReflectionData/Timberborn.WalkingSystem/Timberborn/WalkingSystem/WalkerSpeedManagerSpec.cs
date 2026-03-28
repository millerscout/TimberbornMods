using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WalkingSystem
{
	internal record WalkerSpeedManagerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WalkerSpeedManagerSpec);
			}
		}

		[Serialize]
		public float BaseWalkingSpeed { get; init; }

		[Serialize]
		public float BaseSlowedSpeed { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WalkerSpeedManagerSpec");
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
			builder.Append("BaseWalkingSpeed = ");
			builder.Append(BaseWalkingSpeed.ToString());
			builder.Append(", BaseSlowedSpeed = ");
			builder.Append(BaseSlowedSpeed.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BaseWalkingSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BaseSlowedSpeed);
		}

		[CompilerGenerated]
		public virtual bool Equals(WalkerSpeedManagerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(BaseWalkingSpeed, other!.BaseWalkingSpeed))
				{
					return EqualityComparer<float>.Default.Equals(BaseSlowedSpeed, other!.BaseSlowedSpeed);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WalkerSpeedManagerSpec(WalkerSpeedManagerSpec original)
			: base(original)
		{
			BaseWalkingSpeed = original.BaseWalkingSpeed;
			BaseSlowedSpeed = original.BaseSlowedSpeed;
		}

		public WalkerSpeedManagerSpec()
		{
		}
	}
}
