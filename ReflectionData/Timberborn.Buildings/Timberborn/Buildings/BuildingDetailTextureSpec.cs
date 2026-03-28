using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Buildings
{
	internal record BuildingDetailTextureSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildingDetailTextureSpec);
			}
		}

		[Serialize]
		public AssetRef<Texture> Texture { get; init; }

		[Serialize]
		public Color Color { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildingDetailTextureSpec");
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
			builder.Append("Texture = ");
			builder.Append(Texture);
			builder.Append(", Color = ");
			builder.Append(Color.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<UnityEngine.Texture>>.Default.GetHashCode(Texture)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(Color);
		}

		[CompilerGenerated]
		public virtual bool Equals(BuildingDetailTextureSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<UnityEngine.Texture>>.Default.Equals(Texture, other!.Texture))
				{
					return EqualityComparer<Color>.Default.Equals(Color, other!.Color);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BuildingDetailTextureSpec(BuildingDetailTextureSpec original)
			: base(original)
		{
			Texture = original.Texture;
			Color = original.Color;
		}

		public BuildingDetailTextureSpec()
		{
		}
	}
}
