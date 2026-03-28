using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkshopsEffects
{
	internal record ManufactoryProgressVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ManufactoryProgressVisualizerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<ProgressStepSpec> ProgressSteps { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ManufactoryProgressVisualizerSpec");
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
			builder.Append("ProgressSteps = ");
			builder.Append(ProgressSteps.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<ProgressStepSpec>>.Default.GetHashCode(ProgressSteps);
		}

		[CompilerGenerated]
		public virtual bool Equals(ManufactoryProgressVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<ProgressStepSpec>>.Default.Equals(ProgressSteps, other!.ProgressSteps);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ManufactoryProgressVisualizerSpec(ManufactoryProgressVisualizerSpec original)
			: base(original)
		{
			ProgressSteps = original.ProgressSteps;
		}

		public ManufactoryProgressVisualizerSpec()
		{
		}
	}
}
