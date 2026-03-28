using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GoodConsumingBuildingSystem
{
	public record ConsumedGoodSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ConsumedGoodSpec);
			}
		}

		[Serialize]
		public string GoodId { get; init; }

		[Serialize]
		public float GoodPerHour { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ConsumedGoodSpec");
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
			builder.Append("GoodId = ");
			builder.Append((object)GoodId);
			builder.Append(", GoodPerHour = ");
			builder.Append(GoodPerHour.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodId)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(GoodPerHour);
		}

		[CompilerGenerated]
		public virtual bool Equals(ConsumedGoodSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(GoodId, other!.GoodId))
				{
					return EqualityComparer<float>.Default.Equals(GoodPerHour, other!.GoodPerHour);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ConsumedGoodSpec(ConsumedGoodSpec original)
			: base(original)
		{
			GoodId = original.GoodId;
			GoodPerHour = original.GoodPerHour;
		}

		public ConsumedGoodSpec()
		{
		}
	}
}
