using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Illumination
{
	internal record DefaultIlluminatorColorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DefaultIlluminatorColorSpec);
			}
		}

		[Serialize]
		public string ColorId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DefaultIlluminatorColorSpec");
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
			builder.Append("ColorId = ");
			builder.Append((object)ColorId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ColorId);
		}

		[CompilerGenerated]
		public virtual bool Equals(DefaultIlluminatorColorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(ColorId, other!.ColorId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DefaultIlluminatorColorSpec(DefaultIlluminatorColorSpec original)
			: base(original)
		{
			ColorId = original.ColorId;
		}

		public DefaultIlluminatorColorSpec()
		{
		}
	}
}
