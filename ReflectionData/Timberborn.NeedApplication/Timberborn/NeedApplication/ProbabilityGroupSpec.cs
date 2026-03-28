using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedApplication
{
	internal record ProbabilityGroupSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ProbabilityGroupSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public float Low { get; init; }

		[Serialize]
		public float Medium { get; init; }

		[Serialize]
		public float High { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ProbabilityGroupSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", Low = ");
			builder.Append(Low.ToString());
			builder.Append(", Medium = ");
			builder.Append(Medium.ToString());
			builder.Append(", High = ");
			builder.Append(High.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Low)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Medium)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(High);
		}

		[CompilerGenerated]
		public virtual bool Equals(ProbabilityGroupSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<float>.Default.Equals(Low, other!.Low) && EqualityComparer<float>.Default.Equals(Medium, other!.Medium))
				{
					return EqualityComparer<float>.Default.Equals(High, other!.High);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ProbabilityGroupSpec(ProbabilityGroupSpec original)
		{
			Id = original.Id;
			Low = original.Low;
			Medium = original.Medium;
			High = original.High;
		}

		public ProbabilityGroupSpec()
		{
		}
	}
}
