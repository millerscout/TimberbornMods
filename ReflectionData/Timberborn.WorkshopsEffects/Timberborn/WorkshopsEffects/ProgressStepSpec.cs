using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkshopsEffects
{
	internal record ProgressStepSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ProgressStepSpec);
			}
		}

		[Serialize]
		public float Threshold { get; init; }

		[Serialize]
		public ImmutableArray<string> ModelNames { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ProgressStepSpec");
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
			builder.Append("Threshold = ");
			builder.Append(Threshold.ToString());
			builder.Append(", ModelNames = ");
			builder.Append(ModelNames.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Threshold)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(ModelNames);
		}

		[CompilerGenerated]
		public virtual bool Equals(ProgressStepSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<float>.Default.Equals(Threshold, other!.Threshold))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(ModelNames, other!.ModelNames);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ProgressStepSpec(ProgressStepSpec original)
		{
			Threshold = original.Threshold;
			ModelNames = original.ModelNames;
		}

		public ProgressStepSpec()
		{
		}
	}
}
