using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.LocalizationSerialization
{
	public record LocalizedText(string Value)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(LocalizedText);
			}
		}

		public LocalizedText(string Value)
		{
			this.Value = ;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LocalizedText");
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
			builder.Append("Value = ");
			builder.Append((object)Value);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Value);
		}

		[CompilerGenerated]
		public virtual bool Equals(LocalizedText? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract)
				{
					return EqualityComparer<string>.Default.Equals(Value, other!.Value);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected LocalizedText(LocalizedText original)
		{
			Value = original.Value;
		}
	}
}
