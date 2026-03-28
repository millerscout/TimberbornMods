using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkSystem
{
	public record WorkplaceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WorkplaceSpec);
			}
		}

		[Serialize]
		public int MaxWorkers { get; init; }

		[Serialize]
		public int DefaultWorkers { get; init; }

		[Serialize]
		public string DefaultWorkerType { get; init; }

		[Serialize]
		public bool DisallowOtherWorkerTypes { get; init; }

		[Serialize]
		public ImmutableArray<WorkerTypeUnlockCost> WorkerTypeUnlockCosts { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WorkplaceSpec");
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
			builder.Append("MaxWorkers = ");
			builder.Append(MaxWorkers.ToString());
			builder.Append(", DefaultWorkers = ");
			builder.Append(DefaultWorkers.ToString());
			builder.Append(", DefaultWorkerType = ");
			builder.Append((object)DefaultWorkerType);
			builder.Append(", DisallowOtherWorkerTypes = ");
			builder.Append(DisallowOtherWorkerTypes.ToString());
			builder.Append(", WorkerTypeUnlockCosts = ");
			builder.Append(WorkerTypeUnlockCosts.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxWorkers)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(DefaultWorkers)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DefaultWorkerType)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DisallowOtherWorkerTypes)) * -1521134295 + EqualityComparer<ImmutableArray<WorkerTypeUnlockCost>>.Default.GetHashCode(WorkerTypeUnlockCosts);
		}

		[CompilerGenerated]
		public virtual bool Equals(WorkplaceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MaxWorkers, other!.MaxWorkers) && EqualityComparer<int>.Default.Equals(DefaultWorkers, other!.DefaultWorkers) && EqualityComparer<string>.Default.Equals(DefaultWorkerType, other!.DefaultWorkerType) && EqualityComparer<bool>.Default.Equals(DisallowOtherWorkerTypes, other!.DisallowOtherWorkerTypes))
				{
					return EqualityComparer<ImmutableArray<WorkerTypeUnlockCost>>.Default.Equals(WorkerTypeUnlockCosts, other!.WorkerTypeUnlockCosts);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WorkplaceSpec(WorkplaceSpec original)
			: base(original)
		{
			MaxWorkers = original.MaxWorkers;
			DefaultWorkers = original.DefaultWorkers;
			DefaultWorkerType = original.DefaultWorkerType;
			DisallowOtherWorkerTypes = original.DisallowOtherWorkerTypes;
			WorkerTypeUnlockCosts = original.WorkerTypeUnlockCosts;
		}

		public WorkplaceSpec()
		{
			MaxWorkers = 1;
			DefaultWorkers = 1;
			DefaultWorkerType = "Beaver";
			base._002Ector();
		}
	}
}
