using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedApplication
{
	internal record ProbabilityGroupsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ProbabilityGroupsSpec);
			}
		}

		[Serialize]
		public ImmutableArray<ProbabilityGroupSpec> Groups { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ProbabilityGroupsSpec");
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
			builder.Append("Groups = ");
			builder.Append(Groups.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<ProbabilityGroupSpec>>.Default.GetHashCode(Groups);
		}

		[CompilerGenerated]
		public virtual bool Equals(ProbabilityGroupsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<ProbabilityGroupSpec>>.Default.Equals(Groups, other!.Groups);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ProbabilityGroupsSpec(ProbabilityGroupsSpec original)
			: base(original)
		{
			Groups = original.Groups;
		}

		public ProbabilityGroupsSpec()
		{
		}
	}
}
