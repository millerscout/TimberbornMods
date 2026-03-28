using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterBuildings
{
	internal record FloodgateAnimationControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FloodgateAnimationControllerSpec);
			}
		}

		[Serialize]
		public string GateName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FloodgateAnimationControllerSpec");
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
			builder.Append("GateName = ");
			builder.Append((object)GateName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GateName);
		}

		[CompilerGenerated]
		public virtual bool Equals(FloodgateAnimationControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(GateName, other!.GateName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FloodgateAnimationControllerSpec(FloodgateAnimationControllerSpec original)
			: base(original)
		{
			GateName = original.GateName;
		}

		public FloodgateAnimationControllerSpec()
		{
		}
	}
}
