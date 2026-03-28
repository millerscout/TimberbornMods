using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Yielding;

namespace Timberborn.Cutting
{
	public record CuttableSpec : ComponentSpec, IYielderDecorable
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CuttableSpec);
			}
		}

		[Serialize]
		public bool RemoveOnCut { get; init; }

		[Serialize]
		public string LeftoverModelName { get; init; }

		[Serialize]
		public YielderSpec Yielder { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CuttableSpec");
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
			builder.Append("RemoveOnCut = ");
			builder.Append(RemoveOnCut.ToString());
			builder.Append(", LeftoverModelName = ");
			builder.Append((object)LeftoverModelName);
			builder.Append(", Yielder = ");
			builder.Append(Yielder);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(RemoveOnCut)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LeftoverModelName)) * -1521134295 + EqualityComparer<YielderSpec>.Default.GetHashCode(Yielder);
		}

		[CompilerGenerated]
		public virtual bool Equals(CuttableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(RemoveOnCut, other!.RemoveOnCut) && EqualityComparer<string>.Default.Equals(LeftoverModelName, other!.LeftoverModelName))
				{
					return EqualityComparer<YielderSpec>.Default.Equals(Yielder, other!.Yielder);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CuttableSpec(CuttableSpec original)
			: base(original)
		{
			RemoveOnCut = original.RemoveOnCut;
			LeftoverModelName = original.LeftoverModelName;
			Yielder = original.Yielder;
		}

		public CuttableSpec()
		{
		}
	}
}
