using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MechanicalSystemUI
{
	internal record MechanicalNodeAnimatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MechanicalNodeAnimatorSpec);
			}
		}

		[Serialize]
		public float MinSpeedMultiplier { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MechanicalNodeAnimatorSpec");
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
			builder.Append("MinSpeedMultiplier = ");
			builder.Append(MinSpeedMultiplier.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinSpeedMultiplier);
		}

		[CompilerGenerated]
		public virtual bool Equals(MechanicalNodeAnimatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(MinSpeedMultiplier, other!.MinSpeedMultiplier);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MechanicalNodeAnimatorSpec(MechanicalNodeAnimatorSpec original)
			: base(original)
		{
			MinSpeedMultiplier = original.MinSpeedMultiplier;
		}

		public MechanicalNodeAnimatorSpec()
		{
		}
	}
}
