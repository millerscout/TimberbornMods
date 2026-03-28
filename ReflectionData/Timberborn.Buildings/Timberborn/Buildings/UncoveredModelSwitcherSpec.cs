using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Buildings
{
	internal record UncoveredModelSwitcherSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UncoveredModelSwitcherSpec);
			}
		}

		[Serialize]
		public string FullModelName { get; init; }

		[Serialize]
		public string UncoveredModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UncoveredModelSwitcherSpec");
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
			builder.Append("FullModelName = ");
			builder.Append((object)FullModelName);
			builder.Append(", UncoveredModelName = ");
			builder.Append((object)UncoveredModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FullModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UncoveredModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(UncoveredModelSwitcherSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(FullModelName, other!.FullModelName))
				{
					return EqualityComparer<string>.Default.Equals(UncoveredModelName, other!.UncoveredModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UncoveredModelSwitcherSpec(UncoveredModelSwitcherSpec original)
			: base(original)
		{
			FullModelName = original.FullModelName;
			UncoveredModelName = original.UncoveredModelName;
		}

		public UncoveredModelSwitcherSpec()
		{
		}
	}
}
