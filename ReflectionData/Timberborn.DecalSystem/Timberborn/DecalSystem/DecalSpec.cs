using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.DecalSystem
{
	internal record DecalSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DecalSpec);
			}
		}

		[Serialize]
		public string FactionId { get; init; }

		[Serialize]
		public string Category { get; init; }

		[Serialize]
		public AssetRef<Texture2D> Texture { get; init; }

		public string Id => Texture.Asset.name;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DecalSpec");
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
			builder.Append("FactionId = ");
			builder.Append((object)FactionId);
			builder.Append(", Category = ");
			builder.Append((object)Category);
			builder.Append(", Texture = ");
			builder.Append(Texture);
			builder.Append(", Id = ");
			builder.Append((object)Id);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FactionId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Category)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(Texture);
		}

		[CompilerGenerated]
		public virtual bool Equals(DecalSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(FactionId, other!.FactionId) && EqualityComparer<string>.Default.Equals(Category, other!.Category))
				{
					return EqualityComparer<AssetRef<Texture2D>>.Default.Equals(Texture, other!.Texture);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DecalSpec(DecalSpec original)
			: base(original)
		{
			FactionId = original.FactionId;
			Category = original.Category;
			Texture = original.Texture;
		}

		public DecalSpec()
		{
		}
	}
}
