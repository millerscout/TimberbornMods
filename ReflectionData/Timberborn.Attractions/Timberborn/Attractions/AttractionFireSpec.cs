using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Attractions
{
	internal record AttractionFireSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AttractionFireSpec);
			}
		}

		[Serialize]
		public string WoodstackName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AttractionFireSpec");
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
			builder.Append("WoodstackName = ");
			builder.Append((object)WoodstackName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WoodstackName);
		}

		[CompilerGenerated]
		public virtual bool Equals(AttractionFireSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(WoodstackName, other!.WoodstackName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AttractionFireSpec(AttractionFireSpec original)
			: base(original)
		{
			WoodstackName = original.WoodstackName;
		}

		public AttractionFireSpec()
		{
		}
	}
}
