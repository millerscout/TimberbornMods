using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkSystem
{
	public record WorkerTypeUnlockCost
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WorkerTypeUnlockCost);
			}
		}

		[Serialize]
		public string WorkerType { get; init; }

		[Serialize]
		public int ScienceCost { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WorkerTypeUnlockCost");
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
			builder.Append("WorkerType = ");
			builder.Append((object)WorkerType);
			builder.Append(", ScienceCost = ");
			builder.Append(ScienceCost.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WorkerType)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ScienceCost);
		}

		[CompilerGenerated]
		public virtual bool Equals(WorkerTypeUnlockCost? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(WorkerType, other!.WorkerType))
				{
					return EqualityComparer<int>.Default.Equals(ScienceCost, other!.ScienceCost);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WorkerTypeUnlockCost(WorkerTypeUnlockCost original)
		{
			WorkerType = original.WorkerType;
			ScienceCost = original.ScienceCost;
		}

		public WorkerTypeUnlockCost()
		{
		}
	}
}
