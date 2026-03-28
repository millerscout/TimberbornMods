using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Workshops
{
	public record ManufactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ManufactorySpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> ProductionRecipeIds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ManufactorySpec");
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
			builder.Append("ProductionRecipeIds = ");
			builder.Append(ProductionRecipeIds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(ProductionRecipeIds);
		}

		[CompilerGenerated]
		public virtual bool Equals(ManufactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(ProductionRecipeIds, other!.ProductionRecipeIds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ManufactorySpec(ManufactorySpec original)
			: base(original)
		{
			ProductionRecipeIds = original.ProductionRecipeIds;
		}

		public ManufactorySpec()
		{
		}
	}
}
