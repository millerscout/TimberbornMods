using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PowerManagement
{
	internal record GravityBatterySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GravityBatterySpec);
			}
		}

		[Serialize]
		public int CapacityPerTile { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GravityBatterySpec");
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
			builder.Append("CapacityPerTile = ");
			builder.Append(CapacityPerTile.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CapacityPerTile);
		}

		[CompilerGenerated]
		public virtual bool Equals(GravityBatterySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(CapacityPerTile, other!.CapacityPerTile);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GravityBatterySpec(GravityBatterySpec original)
			: base(original)
		{
			CapacityPerTile = original.CapacityPerTile;
		}

		public GravityBatterySpec()
		{
		}
	}
}
