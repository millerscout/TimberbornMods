using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.BlueprintSystem
{
	public abstract record ComponentSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ComponentSpec);
			}
		}

		public Blueprint Blueprint { get; init; }

		internal bool DisableBlueprintCopying { get; set; }

		protected ComponentSpec()
		{
			Blueprint = new Blueprint(null, null, this);
		}

		protected ComponentSpec(ComponentSpec original)
		{
			if (original.DisableBlueprintCopying)
			{
				Blueprint = null;
			}
			else
			{
				Blueprint = new Blueprint(original.Blueprint, original, this);
			}
		}

		public bool HasSpec<T>()
		{
			return Blueprint.HasSpec<T>();
		}

		public T GetSpec<T>()
		{
			return Blueprint.GetSpec<T>();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ComponentSpec");
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
			builder.Append("Blueprint = ");
			builder.Append(Blueprint);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Blueprint>.Default.GetHashCode(Blueprint)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DisableBlueprintCopying);
		}

		[CompilerGenerated]
		public virtual bool Equals(ComponentSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Blueprint>.Default.Equals(Blueprint, other!.Blueprint))
				{
					return EqualityComparer<bool>.Default.Equals(DisableBlueprintCopying, other!.DisableBlueprintCopying);
				}
				return false;
			}
			return true;
		}
	}
}
