using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Goods
{
	public record GoodAmountSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodAmountSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public int Amount { get; init; }

		public GoodAmount ToGoodAmount()
		{
			return new GoodAmount(Id, Amount);
		}

		public override string ToString()
		{
			return $"{Amount}x {Id}";
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", Amount = ");
			builder.Append(Amount.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Amount);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodAmountSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Id, other!.Id))
				{
					return EqualityComparer<int>.Default.Equals(Amount, other!.Amount);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodAmountSpec(GoodAmountSpec original)
		{
			Id = original.Id;
			Amount = original.Amount;
		}

		public GoodAmountSpec()
		{
		}
	}
}
