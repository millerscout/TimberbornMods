using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Goods;

namespace Timberborn.Yielding
{
	public record YielderSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(YielderSpec);
			}
		}

		[Serialize]
		public string YielderComponentName { get; init; }

		[Serialize]
		public GoodAmountSpec Yield { get; init; }

		[Serialize]
		public float RemovalTimeInHours { get; init; }

		[Serialize]
		public string ResourceGroup { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("YielderSpec");
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
			builder.Append("YielderComponentName = ");
			builder.Append((object)YielderComponentName);
			builder.Append(", Yield = ");
			builder.Append(Yield);
			builder.Append(", RemovalTimeInHours = ");
			builder.Append(RemovalTimeInHours.ToString());
			builder.Append(", ResourceGroup = ");
			builder.Append((object)ResourceGroup);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(YielderComponentName)) * -1521134295 + EqualityComparer<GoodAmountSpec>.Default.GetHashCode(Yield)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RemovalTimeInHours)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ResourceGroup);
		}

		[CompilerGenerated]
		public virtual bool Equals(YielderSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(YielderComponentName, other!.YielderComponentName) && EqualityComparer<GoodAmountSpec>.Default.Equals(Yield, other!.Yield) && EqualityComparer<float>.Default.Equals(RemovalTimeInHours, other!.RemovalTimeInHours))
				{
					return EqualityComparer<string>.Default.Equals(ResourceGroup, other!.ResourceGroup);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected YielderSpec(YielderSpec original)
		{
			YielderComponentName = original.YielderComponentName;
			Yield = original.Yield;
			RemovalTimeInHours = original.RemovalTimeInHours;
			ResourceGroup = original.ResourceGroup;
		}

		public YielderSpec()
		{
		}
	}
}
