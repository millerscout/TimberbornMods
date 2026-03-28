using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.EntityNaming
{
	internal record NamedEntitySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NamedEntitySpec);
			}
		}

		[Serialize]
		public bool IsEditable { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NamedEntitySpec");
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
			builder.Append("IsEditable = ");
			builder.Append(IsEditable.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsEditable);
		}

		[CompilerGenerated]
		public virtual bool Equals(NamedEntitySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<bool>.Default.Equals(IsEditable, other!.IsEditable);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NamedEntitySpec(NamedEntitySpec original)
			: base(original)
		{
			IsEditable = original.IsEditable;
		}

		public NamedEntitySpec()
		{
		}
	}
}
