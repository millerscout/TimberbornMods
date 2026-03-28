using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SoilContaminationSystem
{
	internal record SoilContaminationMapSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SoilContaminationMapSpec);
			}
		}

		[Serialize]
		public float MaxMapContamination { get; init; }

		[Serialize]
		public float ContaminationThreshold { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SoilContaminationMapSpec");
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
			builder.Append("MaxMapContamination = ");
			builder.Append(MaxMapContamination.ToString());
			builder.Append(", ContaminationThreshold = ");
			builder.Append(ContaminationThreshold.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxMapContamination)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ContaminationThreshold);
		}

		[CompilerGenerated]
		public virtual bool Equals(SoilContaminationMapSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MaxMapContamination, other!.MaxMapContamination))
				{
					return EqualityComparer<float>.Default.Equals(ContaminationThreshold, other!.ContaminationThreshold);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SoilContaminationMapSpec(SoilContaminationMapSpec original)
			: base(original)
		{
			MaxMapContamination = original.MaxMapContamination;
			ContaminationThreshold = original.ContaminationThreshold;
		}

		public SoilContaminationMapSpec()
		{
		}
	}
}
