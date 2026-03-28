using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.ToolSystem
{
	public record ToolGroupSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ToolGroupSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public string DisplayNameLocKey { get; init; }

		[Serialize]
		public AssetRef<Sprite> Icon { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ToolGroupSpec");
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
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", DisplayNameLocKey = ");
			builder.Append((object)DisplayNameLocKey);
			builder.Append(", Icon = ");
			builder.Append(Icon);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Icon);
		}

		[CompilerGenerated]
		public virtual bool Equals(ToolGroupSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey))
				{
					return EqualityComparer<AssetRef<Sprite>>.Default.Equals(Icon, other!.Icon);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ToolGroupSpec(ToolGroupSpec original)
			: base(original)
		{
			Id = original.Id;
			DisplayNameLocKey = original.DisplayNameLocKey;
			Icon = original.Icon;
		}

		public ToolGroupSpec()
		{
		}
	}
}
