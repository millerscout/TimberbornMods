using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BonusSystem
{
	public record BonusSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BonusSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public float MultiplierDelta { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BonusSpec");
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
			builder.Append(", MultiplierDelta = ");
			builder.Append(MultiplierDelta.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MultiplierDelta);
		}

		[CompilerGenerated]
		public virtual bool Equals(BonusSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Id, other!.Id))
				{
					return EqualityComparer<float>.Default.Equals(MultiplierDelta, other!.MultiplierDelta);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BonusSpec(BonusSpec original)
		{
			Id = original.Id;
			MultiplierDelta = original.MultiplierDelta;
		}

		public BonusSpec()
		{
		}
	}
}
