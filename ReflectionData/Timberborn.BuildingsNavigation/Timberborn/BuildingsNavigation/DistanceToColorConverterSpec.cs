using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.CoreUI;

namespace Timberborn.BuildingsNavigation
{
	internal record DistanceToColorConverterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DistanceToColorConverterSpec);
			}
		}

		[Serialize]
		public ImmutableArray<GradientPointSpec> DistanceGradient { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DistanceToColorConverterSpec");
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
			builder.Append("DistanceGradient = ");
			builder.Append(DistanceGradient.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<GradientPointSpec>>.Default.GetHashCode(DistanceGradient);
		}

		[CompilerGenerated]
		public virtual bool Equals(DistanceToColorConverterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<GradientPointSpec>>.Default.Equals(DistanceGradient, other!.DistanceGradient);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DistanceToColorConverterSpec(DistanceToColorConverterSpec original)
			: base(original)
		{
			DistanceGradient = original.DistanceGradient;
		}

		public DistanceToColorConverterSpec()
		{
		}
	}
}
