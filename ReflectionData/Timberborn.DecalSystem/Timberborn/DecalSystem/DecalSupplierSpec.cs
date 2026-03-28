using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.DecalSystem
{
	internal record DecalSupplierSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DecalSupplierSpec);
			}
		}

		[Serialize]
		public string Category { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DecalSupplierSpec");
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
			builder.Append("Category = ");
			builder.Append((object)Category);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Category);
		}

		[CompilerGenerated]
		public virtual bool Equals(DecalSupplierSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(Category, other!.Category);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DecalSupplierSpec(DecalSupplierSpec original)
			: base(original)
		{
			Category = original.Category;
		}

		public DecalSupplierSpec()
		{
		}
	}
}
