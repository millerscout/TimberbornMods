using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Yielding
{
	internal record RemoveYieldStrategySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RemoveYieldStrategySpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public ImmutableArray<string> CompatibleResourceGroups { get; init; }

		[Serialize]
		public string Animation { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RemoveYieldStrategySpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder)
		{
			if (base.PrintMembers(builder))
			{
				builder.Append(", ");
			}
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", CompatibleResourceGroups = ");
			builder.Append(CompatibleResourceGroups.ToString());
			builder.Append(", Animation = ");
			builder.Append((object)Animation);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(CompatibleResourceGroups)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Animation);
		}

		[CompilerGenerated]
		public virtual bool Equals(RemoveYieldStrategySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<ImmutableArray<string>>.Default.Equals(CompatibleResourceGroups, other!.CompatibleResourceGroups))
				{
					return EqualityComparer<string>.Default.Equals(Animation, other!.Animation);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RemoveYieldStrategySpec(RemoveYieldStrategySpec original)
			: base(original)
		{
			Id = original.Id;
			CompatibleResourceGroups = original.CompatibleResourceGroups;
			Animation = original.Animation;
		}

		public RemoveYieldStrategySpec()
		{
		}
	}
}
