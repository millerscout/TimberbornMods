using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.EntityNaming
{
	internal record NumberedEntityNamerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NumberedEntityNamerSpec);
			}
		}

		[Serialize]
		public string FormatLocKey { get; init; }

		[Serialize]
		public string NumberingGroup { get; init; }

		[Serialize]
		public bool IsPersistent { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NumberedEntityNamerSpec");
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
			builder.Append("FormatLocKey = ");
			builder.Append((object)FormatLocKey);
			builder.Append(", NumberingGroup = ");
			builder.Append((object)NumberingGroup);
			builder.Append(", IsPersistent = ");
			builder.Append(IsPersistent.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FormatLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NumberingGroup)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsPersistent);
		}

		[CompilerGenerated]
		public virtual bool Equals(NumberedEntityNamerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(FormatLocKey, other!.FormatLocKey) && EqualityComparer<string>.Default.Equals(NumberingGroup, other!.NumberingGroup))
				{
					return EqualityComparer<bool>.Default.Equals(IsPersistent, other!.IsPersistent);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NumberedEntityNamerSpec(NumberedEntityNamerSpec original)
			: base(original)
		{
			FormatLocKey = original.FormatLocKey;
			NumberingGroup = original.NumberingGroup;
			IsPersistent = original.IsPersistent;
		}

		public NumberedEntityNamerSpec()
		{
		}
	}
}
