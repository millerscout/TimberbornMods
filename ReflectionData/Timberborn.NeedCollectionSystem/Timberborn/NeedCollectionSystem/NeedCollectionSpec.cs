using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedCollectionSystem
{
	public record NeedCollectionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedCollectionSpec);
			}
		}

		[Serialize]
		public string CollectionId { get; init; }

		[Serialize]
		public ImmutableArray<string> Needs { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedCollectionSpec");
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
			builder.Append(", Needs = ");
			builder.Append(Needs.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CollectionId)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Needs);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedCollectionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(CollectionId, other!.CollectionId))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Needs, other!.Needs);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedCollectionSpec(NeedCollectionSpec original)
			: base(original)
		{
			CollectionId = original.CollectionId;
			Needs = original.Needs;
		}

		public NeedCollectionSpec()
		{
		}
	}
}
