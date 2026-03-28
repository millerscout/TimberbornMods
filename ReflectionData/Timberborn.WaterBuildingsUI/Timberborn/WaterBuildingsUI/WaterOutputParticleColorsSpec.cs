using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.CoreUI;

namespace Timberborn.WaterBuildingsUI
{
	internal record WaterOutputParticleColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterOutputParticleColorsSpec);
			}
		}

		[Serialize]
		public ImmutableArray<GradientPointSpec> WaterContaminationParticleGradient { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterOutputParticleColorsSpec");
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
			builder.Append("WaterContaminationParticleGradient = ");
			builder.Append(WaterContaminationParticleGradient.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<GradientPointSpec>>.Default.GetHashCode(WaterContaminationParticleGradient);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterOutputParticleColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<GradientPointSpec>>.Default.Equals(WaterContaminationParticleGradient, other!.WaterContaminationParticleGradient);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterOutputParticleColorsSpec(WaterOutputParticleColorsSpec original)
			: base(original)
		{
			WaterContaminationParticleGradient = original.WaterContaminationParticleGradient;
		}

		public WaterOutputParticleColorsSpec()
		{
		}
	}
}
