using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NaturalResourcesReproduction
{
	internal record ReproducibleSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ReproducibleSpec);
			}
		}

		[Serialize]
		public float ReproductionChance { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ReproducibleSpec");
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
			builder.Append("ReproductionChance = ");
			builder.Append(ReproductionChance.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ReproductionChance);
		}

		[CompilerGenerated]
		public virtual bool Equals(ReproducibleSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(ReproductionChance, other!.ReproductionChance);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ReproducibleSpec(ReproducibleSpec original)
			: base(original)
		{
			ReproductionChance = original.ReproductionChance;
		}

		public ReproducibleSpec()
		{
		}
	}
}
