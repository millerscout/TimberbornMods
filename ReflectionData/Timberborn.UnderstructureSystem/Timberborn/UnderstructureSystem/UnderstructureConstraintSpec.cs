using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.UnderstructureSystem
{
	public record UnderstructureConstraintSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UnderstructureConstraintSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> UnderstructureTemplateNames { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UnderstructureConstraintSpec");
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
			builder.Append("UnderstructureTemplateNames = ");
			builder.Append(UnderstructureTemplateNames.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(UnderstructureTemplateNames);
		}

		[CompilerGenerated]
		public virtual bool Equals(UnderstructureConstraintSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(UnderstructureTemplateNames, other!.UnderstructureTemplateNames);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UnderstructureConstraintSpec(UnderstructureConstraintSpec original)
			: base(original)
		{
			UnderstructureTemplateNames = original.UnderstructureTemplateNames;
		}

		public UnderstructureConstraintSpec()
		{
		}
	}
}
