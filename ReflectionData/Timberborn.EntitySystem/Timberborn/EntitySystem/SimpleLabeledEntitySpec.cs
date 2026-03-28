using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.EntitySystem
{
	public record SimpleLabeledEntitySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SimpleLabeledEntitySpec);
			}
		}

		[Serialize]
		public string EntityNameLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SimpleLabeledEntitySpec");
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
			builder.Append("EntityNameLocKey = ");
			builder.Append((object)EntityNameLocKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EntityNameLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(SimpleLabeledEntitySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(EntityNameLocKey, other!.EntityNameLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SimpleLabeledEntitySpec(SimpleLabeledEntitySpec original)
			: base(original)
		{
			EntityNameLocKey = original.EntityNameLocKey;
		}

		public SimpleLabeledEntitySpec()
		{
		}
	}
}
