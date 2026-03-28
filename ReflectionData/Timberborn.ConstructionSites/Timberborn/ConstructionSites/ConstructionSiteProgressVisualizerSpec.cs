using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ConstructionSites
{
	internal record ConstructionSiteProgressVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ConstructionSiteProgressVisualizerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<float> ProgressThresholds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ConstructionSiteProgressVisualizerSpec");
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
			builder.Append("ProgressThresholds = ");
			builder.Append(ProgressThresholds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<float>>.Default.GetHashCode(ProgressThresholds);
		}

		[CompilerGenerated]
		public virtual bool Equals(ConstructionSiteProgressVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<float>>.Default.Equals(ProgressThresholds, other!.ProgressThresholds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ConstructionSiteProgressVisualizerSpec(ConstructionSiteProgressVisualizerSpec original)
			: base(original)
		{
			ProgressThresholds = original.ProgressThresholds;
		}

		public ConstructionSiteProgressVisualizerSpec()
		{
		}
	}
}
