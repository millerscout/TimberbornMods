using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Healthcare
{
	internal record BeaverNeedShaderPropertySet
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BeaverNeedShaderPropertySet);
			}
		}

		[Serialize]
		public string NeedId { get; init; }

		[Serialize]
		public string PropertyName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BeaverNeedShaderPropertySet");
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
			builder.Append("NeedId = ");
			builder.Append((object)NeedId);
			builder.Append(", PropertyName = ");
			builder.Append((object)PropertyName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NeedId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PropertyName);
		}

		[CompilerGenerated]
		public virtual bool Equals(BeaverNeedShaderPropertySet? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(NeedId, other!.NeedId))
				{
					return EqualityComparer<string>.Default.Equals(PropertyName, other!.PropertyName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BeaverNeedShaderPropertySet(BeaverNeedShaderPropertySet original)
		{
			NeedId = original.NeedId;
			PropertyName = original.PropertyName;
		}

		public BeaverNeedShaderPropertySet()
		{
		}
	}
}
