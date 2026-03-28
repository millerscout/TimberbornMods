using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.Goods
{
	public record SerializedGood(string Id)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SerializedGood);
			}
		}

		public SerializedGood(string Id)
		{
			this.Id = ;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SerializedGood");
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
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
		}

		[CompilerGenerated]
		public virtual bool Equals(SerializedGood? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract)
				{
					return EqualityComparer<string>.Default.Equals(Id, other!.Id);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SerializedGood(SerializedGood original)
		{
			Id = original.Id;
		}
	}
}
