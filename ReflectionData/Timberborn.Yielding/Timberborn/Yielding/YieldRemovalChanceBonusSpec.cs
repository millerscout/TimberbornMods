using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Yielding
{
	public record YieldRemovalChanceBonusSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(YieldRemovalChanceBonusSpec);
			}
		}

		[Serialize]
		public string BonusId { get; init; }

		[Serialize]
		public string GoodId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("YieldRemovalChanceBonusSpec");
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
			builder.Append("BonusId = ");
			builder.Append((object)BonusId);
			builder.Append(", GoodId = ");
			builder.Append((object)GoodId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BonusId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodId);
		}

		[CompilerGenerated]
		public virtual bool Equals(YieldRemovalChanceBonusSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(BonusId, other!.BonusId))
				{
					return EqualityComparer<string>.Default.Equals(GoodId, other!.GoodId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected YieldRemovalChanceBonusSpec(YieldRemovalChanceBonusSpec original)
			: base(original)
		{
			BonusId = original.BonusId;
			GoodId = original.GoodId;
		}

		public YieldRemovalChanceBonusSpec()
		{
		}
	}
}
