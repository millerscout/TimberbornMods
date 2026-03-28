using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CharacterModelSystem
{
	internal record CharacterTextureSetterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CharacterTextureSetterSpec);
			}
		}

		[Serialize]
		public ImmutableArray<CharacterTexturePack> TexturePacks { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CharacterTextureSetterSpec");
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
			builder.Append("TexturePacks = ");
			builder.Append(TexturePacks.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<CharacterTexturePack>>.Default.GetHashCode(TexturePacks);
		}

		[CompilerGenerated]
		public virtual bool Equals(CharacterTextureSetterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<CharacterTexturePack>>.Default.Equals(TexturePacks, other!.TexturePacks);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CharacterTextureSetterSpec(CharacterTextureSetterSpec original)
			: base(original)
		{
			TexturePacks = original.TexturePacks;
		}

		public CharacterTextureSetterSpec()
		{
		}
	}
}
