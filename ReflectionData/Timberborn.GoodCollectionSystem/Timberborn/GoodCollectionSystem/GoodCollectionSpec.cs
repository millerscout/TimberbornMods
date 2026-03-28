using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GoodCollectionSystem
{
	public record GoodCollectionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodCollectionSpec);
			}
		}

		[Serialize]
		public string CollectionId { get; init; }

		[Serialize]
		public ImmutableArray<string> Goods { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodCollectionSpec");
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
			builder.Append("CollectionId = ");
			builder.Append((object)CollectionId);
			builder.Append(", Goods = ");
			builder.Append(Goods.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CollectionId)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Goods);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodCollectionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(CollectionId, other!.CollectionId))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Goods, other!.Goods);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodCollectionSpec(GoodCollectionSpec original)
			: base(original)
		{
			CollectionId = original.CollectionId;
			Goods = original.Goods;
		}

		public GoodCollectionSpec()
		{
		}
	}
}
