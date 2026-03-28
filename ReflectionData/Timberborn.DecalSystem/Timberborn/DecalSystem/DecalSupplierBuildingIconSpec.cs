using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.DecalSystem
{
	internal record DecalSupplierBuildingIconSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DecalSupplierBuildingIconSpec);
			}
		}

		[Serialize]
		public string IconRendererName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DecalSupplierBuildingIconSpec");
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
			builder.Append("IconRendererName = ");
			builder.Append((object)IconRendererName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IconRendererName);
		}

		[CompilerGenerated]
		public virtual bool Equals(DecalSupplierBuildingIconSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(IconRendererName, other!.IconRendererName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DecalSupplierBuildingIconSpec(DecalSupplierBuildingIconSpec original)
			: base(original)
		{
			IconRendererName = original.IconRendererName;
		}

		public DecalSupplierBuildingIconSpec()
		{
		}
	}
}
