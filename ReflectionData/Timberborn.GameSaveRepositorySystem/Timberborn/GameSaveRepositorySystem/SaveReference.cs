using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.GameSaveRepositorySystem
{
	public record SaveReference(string SaveName, SettlementReference SettlementReference)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SaveReference);
			}
		}

		public SaveReference(string SaveName, SettlementReference SettlementReference)
		{
			this.SaveName = ;
			this.SettlementReference = SettlementReference;
			base._002Ector();
		}

		public override string ToString()
		{
			return SettlementReference.SettlementName + " - " + SaveName;
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("SaveName = ");
			builder.Append((object)SaveName);
			builder.Append(", SettlementReference = ");
			builder.Append(SettlementReference);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SaveName)) * -1521134295 + EqualityComparer<SettlementReference>.Default.GetHashCode(SettlementReference);
		}

		[CompilerGenerated]
		public virtual bool Equals(SaveReference? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(SaveName, other!.SaveName))
				{
					return EqualityComparer<SettlementReference>.Default.Equals(SettlementReference, other!.SettlementReference);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SaveReference(SaveReference original)
		{
			SaveName = original.SaveName;
			SettlementReference = original.SettlementReference;
		}
	}
}
