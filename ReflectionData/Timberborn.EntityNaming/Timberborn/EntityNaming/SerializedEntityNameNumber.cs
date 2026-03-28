using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.EntityNaming
{
	internal record SerializedEntityNameNumber(string Group, int NextNumber)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SerializedEntityNameNumber);
			}
		}

		public SerializedEntityNameNumber(string Group, int NextNumber)
		{
			this.Group = ;
			this.NextNumber = NextNumber;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SerializedEntityNameNumber");
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
			builder.Append("Group = ");
			builder.Append((object)Group);
			builder.Append(", NextNumber = ");
			builder.Append(NextNumber.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Group)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(NextNumber);
		}

		[CompilerGenerated]
		public virtual bool Equals(SerializedEntityNameNumber? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Group, other!.Group))
				{
					return EqualityComparer<int>.Default.Equals(NextNumber, other!.NextNumber);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SerializedEntityNameNumber(SerializedEntityNameNumber original)
		{
			Group = original.Group;
			NextNumber = original.NextNumber;
		}
	}
}
