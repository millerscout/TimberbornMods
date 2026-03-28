using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;
using UnityEngine;

namespace Timberborn.Goods
{
	public record GoodGroupSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodGroupSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public int Order { get; init; }

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		public AssetRef<Sprite> Icon { get; init; }

		[Serialize]
		public bool SingleResourceGroup { get; init; }

		[Serialize]
		private string DisplayNameLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodGroupSpec");
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
			builder.Append(", Order = ");
			builder.Append(Order.ToString());
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", Icon = ");
			builder.Append(Icon);
			builder.Append(", SingleResourceGroup = ");
			builder.Append(SingleResourceGroup.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Icon)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(SingleResourceGroup)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodGroupSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(Icon, other!.Icon) && EqualityComparer<bool>.Default.Equals(SingleResourceGroup, other!.SingleResourceGroup))
				{
					return EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodGroupSpec(GoodGroupSpec original)
			: base(original)
		{
			Id = original.Id;
			Order = original.Order;
			DisplayName = original.DisplayName;
			Icon = original.Icon;
			SingleResourceGroup = original.SingleResourceGroup;
			DisplayNameLocKey = original.DisplayNameLocKey;
		}

		public GoodGroupSpec()
		{
		}
	}
}
