using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterBuildings
{
	internal record WaterMoverSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterMoverSpec);
			}
		}

		[Serialize]
		public float WaterPerSecond { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterMoverSpec");
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
			builder.Append("WaterPerSecond = ");
			builder.Append(WaterPerSecond.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(WaterPerSecond);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterMoverSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(WaterPerSecond, other!.WaterPerSecond);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterMoverSpec(WaterMoverSpec original)
			: base(original)
		{
			WaterPerSecond = original.WaterPerSecond;
		}

		public WaterMoverSpec()
		{
		}
	}
}
