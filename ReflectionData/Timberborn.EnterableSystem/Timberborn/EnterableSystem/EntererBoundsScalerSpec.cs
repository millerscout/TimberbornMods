using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.EnterableSystem
{
	internal record EntererBoundsScalerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EntererBoundsScalerSpec);
			}
		}

		[Serialize]
		public float Scale { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EntererBoundsScalerSpec");
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
			builder.Append("Scale = ");
			builder.Append(Scale.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Scale);
		}

		[CompilerGenerated]
		public virtual bool Equals(EntererBoundsScalerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(Scale, other!.Scale);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected EntererBoundsScalerSpec(EntererBoundsScalerSpec original)
			: base(original)
		{
			Scale = original.Scale;
		}

		public EntererBoundsScalerSpec()
		{
		}
	}
}
