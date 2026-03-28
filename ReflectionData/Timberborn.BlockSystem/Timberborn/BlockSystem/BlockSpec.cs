using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockSystem
{
	public record BlockSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockSpec);
			}
		}

		[Serialize]
		public MatterBelow MatterBelow { get; init; }

		[Serialize]
		public BlockOccupations Occupations { get; init; }

		[Serialize]
		public BlockStackable Stackable { get; init; }

		[Serialize]
		public bool OccupyAllBelow { get; init; }

		[Serialize]
		public bool Underground { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockSpec");
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
			builder.Append("MatterBelow = ");
			builder.Append(MatterBelow.ToString());
			builder.Append(", Occupations = ");
			builder.Append(Occupations.ToString());
			builder.Append(", Stackable = ");
			builder.Append(Stackable.ToString());
			builder.Append(", OccupyAllBelow = ");
			builder.Append(OccupyAllBelow.ToString());
			builder.Append(", Underground = ");
			builder.Append(Underground.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<MatterBelow>.Default.GetHashCode(MatterBelow)) * -1521134295 + EqualityComparer<BlockOccupations>.Default.GetHashCode(Occupations)) * -1521134295 + EqualityComparer<BlockStackable>.Default.GetHashCode(Stackable)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(OccupyAllBelow)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Underground);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<MatterBelow>.Default.Equals(MatterBelow, other!.MatterBelow) && EqualityComparer<BlockOccupations>.Default.Equals(Occupations, other!.Occupations) && EqualityComparer<BlockStackable>.Default.Equals(Stackable, other!.Stackable) && EqualityComparer<bool>.Default.Equals(OccupyAllBelow, other!.OccupyAllBelow))
				{
					return EqualityComparer<bool>.Default.Equals(Underground, other!.Underground);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockSpec(BlockSpec original)
		{
			MatterBelow = original.MatterBelow;
			Occupations = original.Occupations;
			Stackable = original.Stackable;
			OccupyAllBelow = original.OccupyAllBelow;
			Underground = original.Underground;
		}

		public BlockSpec()
		{
		}
	}
}
