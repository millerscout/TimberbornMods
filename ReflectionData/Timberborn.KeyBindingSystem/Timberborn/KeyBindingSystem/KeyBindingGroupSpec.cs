using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.KeyBindingSystem
{
	public record KeyBindingGroupSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(KeyBindingGroupSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public int Order { get; init; }

		[Serialize("LocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		private string LocKey { get; init; }

		public bool IsHiddenGroup => HasSpec<HiddenKeyBindingGroupSpec>();

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("KeyBindingGroupSpec");
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
			builder.Append(", IsHiddenGroup = ");
			builder.Append(IsHiddenGroup.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(KeyBindingGroupSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName))
				{
					return EqualityComparer<string>.Default.Equals(LocKey, other!.LocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected KeyBindingGroupSpec(KeyBindingGroupSpec original)
			: base(original)
		{
			Id = original.Id;
			Order = original.Order;
			DisplayName = original.DisplayName;
			LocKey = original.LocKey;
		}

		public KeyBindingGroupSpec()
		{
		}
	}
}
