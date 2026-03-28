using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Rendering
{
	internal record FinishedStateLightingEnforcerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FinishedStateLightingEnforcerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> ChildrenNames { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FinishedStateLightingEnforcerSpec");
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
			builder.Append("ChildrenNames = ");
			builder.Append(ChildrenNames.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(ChildrenNames);
		}

		[CompilerGenerated]
		public virtual bool Equals(FinishedStateLightingEnforcerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(ChildrenNames, other!.ChildrenNames);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FinishedStateLightingEnforcerSpec(FinishedStateLightingEnforcerSpec original)
			: base(original)
		{
			ChildrenNames = original.ChildrenNames;
		}

		public FinishedStateLightingEnforcerSpec()
		{
		}
	}
}
