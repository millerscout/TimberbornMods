using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterSourceSystem
{
	public record WaterDepthStrengthModifierSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterDepthStrengthModifierSpec);
			}
		}

		[Serialize]
		public float DepthLimit { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterDepthStrengthModifierSpec");
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
			builder.Append("DepthLimit = ");
			builder.Append(DepthLimit.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DepthLimit);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterDepthStrengthModifierSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(DepthLimit, other!.DepthLimit);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterDepthStrengthModifierSpec(WaterDepthStrengthModifierSpec original)
			: base(original)
		{
			DepthLimit = original.DepthLimit;
		}

		public WaterDepthStrengthModifierSpec()
		{
			DepthLimit = 0.8f;
			base._002Ector();
		}
	}
}
