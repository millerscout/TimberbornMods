using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.KeyBindingSystem
{
	public record KeyBindingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(KeyBindingSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public string GroupId { get; init; }

		[Serialize]
		public string LocKey { get; init; }

		[Serialize]
		public int Order { get; init; }

		[Serialize]
		public bool AllowOtherModifiers { get; init; }

		[Serialize]
		public bool DevModeOnly { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("KeyBindingSpec");
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
			builder.Append(", GroupId = ");
			builder.Append((object)GroupId);
			builder.Append(", LocKey = ");
			builder.Append((object)LocKey);
			builder.Append(", Order = ");
			builder.Append(Order.ToString());
			builder.Append(", AllowOtherModifiers = ");
			builder.Append(AllowOtherModifiers.ToString());
			builder.Append(", DevModeOnly = ");
			builder.Append(DevModeOnly.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GroupId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LocKey)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(AllowOtherModifiers)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(DevModeOnly);
		}

		[CompilerGenerated]
		public virtual bool Equals(KeyBindingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<string>.Default.Equals(GroupId, other!.GroupId) && EqualityComparer<string>.Default.Equals(LocKey, other!.LocKey) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<bool>.Default.Equals(AllowOtherModifiers, other!.AllowOtherModifiers))
				{
					return EqualityComparer<bool>.Default.Equals(DevModeOnly, other!.DevModeOnly);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected KeyBindingSpec(KeyBindingSpec original)
			: base(original)
		{
			Id = original.Id;
			GroupId = original.GroupId;
			LocKey = original.LocKey;
			Order = original.Order;
			AllowOtherModifiers = original.AllowOtherModifiers;
			DevModeOnly = original.DevModeOnly;
		}

		public KeyBindingSpec()
		{
		}
	}
}
