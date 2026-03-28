using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TemplateCollectionSystem
{
	public record TemplateCollectionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TemplateCollectionSpec);
			}
		}

		[Serialize]
		public string CollectionId { get; init; }

		[Serialize]
		public ImmutableArray<AssetRef<BlueprintAsset>> Blueprints { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TemplateCollectionSpec");
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
			builder.Append(", Blueprints = ");
			builder.Append(Blueprints.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CollectionId)) * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<BlueprintAsset>>>.Default.GetHashCode(Blueprints);
		}

		[CompilerGenerated]
		public virtual bool Equals(TemplateCollectionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(CollectionId, other!.CollectionId))
				{
					return EqualityComparer<ImmutableArray<AssetRef<BlueprintAsset>>>.Default.Equals(Blueprints, other!.Blueprints);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TemplateCollectionSpec(TemplateCollectionSpec original)
			: base(original)
		{
			CollectionId = original.CollectionId;
			Blueprints = original.Blueprints;
		}

		public TemplateCollectionSpec()
		{
		}
	}
}
