using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.GameSaveRepositorySystem
{
	public record SettlementReference(string SettlementName, string SaveDirectory)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SettlementReference);
			}
		}

		public SettlementReference(string SettlementName, string SaveDirectory)
		{
			this.SettlementName = ;
			this.SaveDirectory = SaveDirectory;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SettlementReference");
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
			builder.Append("SettlementName = ");
			builder.Append((object)SettlementName);
			builder.Append(", SaveDirectory = ");
			builder.Append((object)SaveDirectory);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SettlementName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SaveDirectory);
		}

		[CompilerGenerated]
		public virtual bool Equals(SettlementReference? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(SettlementName, other!.SettlementName))
				{
					return EqualityComparer<string>.Default.Equals(SaveDirectory, other!.SaveDirectory);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SettlementReference(SettlementReference original)
		{
			SettlementName = original.SettlementName;
			SaveDirectory = original.SaveDirectory;
		}
	}
}
