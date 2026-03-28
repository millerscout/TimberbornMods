using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.BlueprintSystem
{
	public record NonExistingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NonExistingSpec);
			}
		}

		[Serialize]
		public string SpecName { get; init; }

		[Serialize]
		public string Content { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NonExistingSpec");
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
			builder.Append("SpecName = ");
			builder.Append((object)SpecName);
			builder.Append(", Content = ");
			builder.Append((object)Content);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SpecName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Content);
		}

		[CompilerGenerated]
		public virtual bool Equals(NonExistingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(SpecName, other!.SpecName))
				{
					return EqualityComparer<string>.Default.Equals(Content, other!.Content);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NonExistingSpec(NonExistingSpec original)
			: base(original)
		{
			SpecName = original.SpecName;
			Content = original.Content;
		}

		public NonExistingSpec()
		{
		}
	}
}
