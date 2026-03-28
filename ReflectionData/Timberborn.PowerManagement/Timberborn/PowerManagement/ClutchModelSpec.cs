using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PowerManagement
{
	internal record ClutchModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ClutchModelSpec);
			}
		}

		[Serialize]
		public string EngagedModelName { get; init; }

		[Serialize]
		public string DisengagedModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ClutchModelSpec");
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
			builder.Append("EngagedModelName = ");
			builder.Append((object)EngagedModelName);
			builder.Append(", DisengagedModelName = ");
			builder.Append((object)DisengagedModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EngagedModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisengagedModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(ClutchModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(EngagedModelName, other!.EngagedModelName))
				{
					return EqualityComparer<string>.Default.Equals(DisengagedModelName, other!.DisengagedModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ClutchModelSpec(ClutchModelSpec original)
			: base(original)
		{
			EngagedModelName = original.EngagedModelName;
			DisengagedModelName = original.DisengagedModelName;
		}

		public ClutchModelSpec()
		{
		}
	}
}
