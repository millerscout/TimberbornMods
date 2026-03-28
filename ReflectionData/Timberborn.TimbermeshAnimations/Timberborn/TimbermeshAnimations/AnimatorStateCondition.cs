using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TimbermeshAnimations
{
	internal record AnimatorStateCondition
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AnimatorStateCondition);
			}
		}

		[Serialize]
		public string ParameterName { get; init; }

		[Serialize]
		public bool MustBeTrue { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AnimatorStateCondition");
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
			builder.Append("ParameterName = ");
			builder.Append((object)ParameterName);
			builder.Append(", MustBeTrue = ");
			builder.Append(MustBeTrue.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParameterName)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(MustBeTrue);
		}

		[CompilerGenerated]
		public virtual bool Equals(AnimatorStateCondition? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(ParameterName, other!.ParameterName))
				{
					return EqualityComparer<bool>.Default.Equals(MustBeTrue, other!.MustBeTrue);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AnimatorStateCondition(AnimatorStateCondition original)
		{
			ParameterName = original.ParameterName;
			MustBeTrue = original.MustBeTrue;
		}

		public AnimatorStateCondition()
		{
		}
	}
}
