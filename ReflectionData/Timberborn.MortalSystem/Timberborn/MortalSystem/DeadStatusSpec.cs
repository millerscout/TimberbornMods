using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MortalSystem
{
	internal record DeadStatusSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DeadStatusSpec);
			}
		}

		[Serialize]
		public string DeadStatusLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DeadStatusSpec");
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
			builder.Append("DeadStatusLocKey = ");
			builder.Append((object)DeadStatusLocKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DeadStatusLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(DeadStatusSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(DeadStatusLocKey, other!.DeadStatusLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DeadStatusSpec(DeadStatusSpec original)
			: base(original)
		{
			DeadStatusLocKey = original.DeadStatusLocKey;
		}

		public DeadStatusSpec()
		{
		}
	}
}
