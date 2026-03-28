using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ModularShafts
{
	internal record ModularShaftCoverSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ModularShaftCoverSpec);
			}
		}

		[Serialize]
		public string CoverModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ModularShaftCoverSpec");
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
			builder.Append("CoverModelName = ");
			builder.Append((object)CoverModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CoverModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(ModularShaftCoverSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(CoverModelName, other!.CoverModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ModularShaftCoverSpec(ModularShaftCoverSpec original)
			: base(original)
		{
			CoverModelName = original.CoverModelName;
		}

		public ModularShaftCoverSpec()
		{
		}
	}
}
