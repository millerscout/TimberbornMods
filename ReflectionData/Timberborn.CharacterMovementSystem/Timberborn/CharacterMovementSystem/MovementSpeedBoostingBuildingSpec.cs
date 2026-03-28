using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CharacterMovementSystem
{
	public record MovementSpeedBoostingBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MovementSpeedBoostingBuildingSpec);
			}
		}

		[Serialize]
		public int BoostPercentage { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MovementSpeedBoostingBuildingSpec");
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
			builder.Append("BoostPercentage = ");
			builder.Append(BoostPercentage.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BoostPercentage);
		}

		[CompilerGenerated]
		public virtual bool Equals(MovementSpeedBoostingBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(BoostPercentage, other!.BoostPercentage);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MovementSpeedBoostingBuildingSpec(MovementSpeedBoostingBuildingSpec original)
			: base(original)
		{
			BoostPercentage = original.BoostPercentage;
		}

		public MovementSpeedBoostingBuildingSpec()
		{
		}
	}
}
