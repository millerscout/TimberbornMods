using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;
using UnityEngine;

namespace Timberborn.BonusSystem
{
	public record BonusTypeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BonusTypeSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize("LocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		public float MinimumValue { get; init; }

		[Serialize]
		public float MaximumValue { get; init; }

		[Serialize]
		public AssetRef<Sprite> Icon { get; init; }

		[Serialize]
		private string LocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BonusTypeSpec");
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
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", MinimumValue = ");
			builder.Append(MinimumValue.ToString());
			builder.Append(", MaximumValue = ");
			builder.Append(MaximumValue.ToString());
			builder.Append(", Icon = ");
			builder.Append(Icon);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinimumValue)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaximumValue)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Icon)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(BonusTypeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<float>.Default.Equals(MinimumValue, other!.MinimumValue) && EqualityComparer<float>.Default.Equals(MaximumValue, other!.MaximumValue) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(Icon, other!.Icon))
				{
					return EqualityComparer<string>.Default.Equals(LocKey, other!.LocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BonusTypeSpec(BonusTypeSpec original)
			: base(original)
		{
			Id = original.Id;
			DisplayName = original.DisplayName;
			MinimumValue = original.MinimumValue;
			MaximumValue = original.MaximumValue;
			Icon = original.Icon;
			LocKey = original.LocKey;
		}

		public BonusTypeSpec()
		{
		}
	}
}
