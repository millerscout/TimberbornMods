using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.TimbermeshMaterials
{
	public record MaterialCollectionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MaterialCollectionSpec);
			}
		}

		[Serialize]
		public string CollectionId { get; init; }

		[Serialize]
		public ImmutableArray<AssetRef<Material>> Materials { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MaterialCollectionSpec");
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
			builder.Append(", Materials = ");
			builder.Append(Materials.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CollectionId)) * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<Material>>>.Default.GetHashCode(Materials);
		}

		[CompilerGenerated]
		public virtual bool Equals(MaterialCollectionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(CollectionId, other!.CollectionId))
				{
					return EqualityComparer<ImmutableArray<AssetRef<Material>>>.Default.Equals(Materials, other!.Materials);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MaterialCollectionSpec(MaterialCollectionSpec original)
			: base(original)
		{
			CollectionId = original.CollectionId;
			Materials = original.Materials;
		}

		public MaterialCollectionSpec()
		{
		}
	}
}
