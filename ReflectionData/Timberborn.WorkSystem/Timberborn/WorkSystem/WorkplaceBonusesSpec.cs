using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.BonusSystem;

namespace Timberborn.WorkSystem
{
	internal record WorkplaceBonusesSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WorkplaceBonusesSpec);
			}
		}

		[Serialize]
		public ImmutableArray<BonusSpec> WorkerBonuses { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WorkplaceBonusesSpec");
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
			builder.Append("WorkerBonuses = ");
			builder.Append(WorkerBonuses.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<BonusSpec>>.Default.GetHashCode(WorkerBonuses);
		}

		[CompilerGenerated]
		public virtual bool Equals(WorkplaceBonusesSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<BonusSpec>>.Default.Equals(WorkerBonuses, other!.WorkerBonuses);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WorkplaceBonusesSpec(WorkplaceBonusesSpec original)
			: base(original)
		{
			WorkerBonuses = original.WorkerBonuses;
		}

		public WorkplaceBonusesSpec()
		{
		}
	}
}
