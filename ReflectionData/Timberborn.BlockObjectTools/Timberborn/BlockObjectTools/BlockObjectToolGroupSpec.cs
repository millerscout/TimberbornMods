using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockObjectTools
{
	public record BlockObjectToolGroupSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectToolGroupSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public int Order { get; init; }

		[Serialize]
		public string NameLocKey { get; init; }

		[Serialize]
		public AssetRef<Sprite> Icon { get; init; }

		[Serialize]
		public bool FallbackGroup { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectToolGroupSpec");
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
			builder.Append(", NameLocKey = ");
			builder.Append((object)NameLocKey);
			builder.Append(", Icon = ");
			builder.Append(Icon);
			builder.Append(", FallbackGroup = ");
			builder.Append(FallbackGroup.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NameLocKey)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Icon)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(FallbackGroup);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectToolGroupSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<string>.Default.Equals(NameLocKey, other!.NameLocKey) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(Icon, other!.Icon))
				{
					return EqualityComparer<bool>.Default.Equals(FallbackGroup, other!.FallbackGroup);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectToolGroupSpec(BlockObjectToolGroupSpec original)
			: base(original)
		{
			Id = original.Id;
			Order = original.Order;
			NameLocKey = original.NameLocKey;
			Icon = original.Icon;
			FallbackGroup = original.FallbackGroup;
		}

		public BlockObjectToolGroupSpec()
		{
		}
	}
}
