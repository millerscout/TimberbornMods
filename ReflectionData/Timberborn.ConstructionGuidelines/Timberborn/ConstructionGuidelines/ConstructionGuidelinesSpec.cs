using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ConstructionGuidelines
{
	internal record ConstructionGuidelinesSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ConstructionGuidelinesSpec);
			}
		}

		[Serialize]
		public int Radius { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ConstructionGuidelinesSpec");
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
			builder.Append("Radius = ");
			builder.Append(Radius.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Radius);
		}

		[CompilerGenerated]
		public virtual bool Equals(ConstructionGuidelinesSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(Radius, other!.Radius);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ConstructionGuidelinesSpec(ConstructionGuidelinesSpec original)
			: base(original)
		{
			Radius = original.Radius;
		}

		public ConstructionGuidelinesSpec()
		{
		}
	}
}
