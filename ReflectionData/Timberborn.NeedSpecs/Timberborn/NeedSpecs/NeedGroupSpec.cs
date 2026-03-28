using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.NeedSpecs
{
	public record NeedGroupSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedGroupSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public int Order { get; init; }

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		private string DisplayNameLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedGroupSpec");
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
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedGroupSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName))
				{
					return EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedGroupSpec(NeedGroupSpec original)
			: base(original)
		{
			Id = original.Id;
			Order = original.Order;
			DisplayName = original.DisplayName;
			DisplayNameLocKey = original.DisplayNameLocKey;
		}

		public NeedGroupSpec()
		{
		}
	}
}
