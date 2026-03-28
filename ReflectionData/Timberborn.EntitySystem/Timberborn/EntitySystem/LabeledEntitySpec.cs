using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.EntitySystem
{
	public record LabeledEntitySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(LabeledEntitySpec);
			}
		}

		[Serialize]
		public string DisplayNameLocKey { get; init; }

		[Serialize]
		public string DescriptionLocKey { get; init; }

		[Serialize]
		public string FlavorDescriptionLocKey { get; init; }

		[Serialize]
		public AssetRef<Sprite> Icon { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LabeledEntitySpec");
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
			builder.Append("DisplayNameLocKey = ");
			builder.Append((object)DisplayNameLocKey);
			builder.Append(", DescriptionLocKey = ");
			builder.Append((object)DescriptionLocKey);
			builder.Append(", FlavorDescriptionLocKey = ");
			builder.Append((object)FlavorDescriptionLocKey);
			builder.Append(", Icon = ");
			builder.Append(Icon);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DescriptionLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FlavorDescriptionLocKey)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Icon);
		}

		[CompilerGenerated]
		public virtual bool Equals(LabeledEntitySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey) && EqualityComparer<string>.Default.Equals(DescriptionLocKey, other!.DescriptionLocKey) && EqualityComparer<string>.Default.Equals(FlavorDescriptionLocKey, other!.FlavorDescriptionLocKey))
				{
					return EqualityComparer<AssetRef<Sprite>>.Default.Equals(Icon, other!.Icon);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected LabeledEntitySpec(LabeledEntitySpec original)
			: base(original)
		{
			DisplayNameLocKey = original.DisplayNameLocKey;
			DescriptionLocKey = original.DescriptionLocKey;
			FlavorDescriptionLocKey = original.FlavorDescriptionLocKey;
			Icon = original.Icon;
		}

		public LabeledEntitySpec()
		{
		}
	}
}
