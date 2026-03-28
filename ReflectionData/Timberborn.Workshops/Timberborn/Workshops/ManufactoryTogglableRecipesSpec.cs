using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Workshops
{
	internal record ManufactoryTogglableRecipesSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ManufactoryTogglableRecipesSpec);
			}
		}

		[Serialize]
		public string LabelLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ManufactoryTogglableRecipesSpec");
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
			builder.Append("LabelLocKey = ");
			builder.Append((object)LabelLocKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LabelLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(ManufactoryTogglableRecipesSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(LabelLocKey, other!.LabelLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ManufactoryTogglableRecipesSpec(ManufactoryTogglableRecipesSpec original)
			: base(original)
		{
			LabelLocKey = original.LabelLocKey;
		}

		public ManufactoryTogglableRecipesSpec()
		{
		}
	}
}
