using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PowerGeneration
{
	internal record WindPoweredGeneratorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WindPoweredGeneratorSpec);
			}
		}

		[Serialize]
		public float MinRequiredWindStrength { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WindPoweredGeneratorSpec");
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
			builder.Append("MinRequiredWindStrength = ");
			builder.Append(MinRequiredWindStrength.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinRequiredWindStrength);
		}

		[CompilerGenerated]
		public virtual bool Equals(WindPoweredGeneratorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(MinRequiredWindStrength, other!.MinRequiredWindStrength);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WindPoweredGeneratorSpec(WindPoweredGeneratorSpec original)
			: base(original)
		{
			MinRequiredWindStrength = original.MinRequiredWindStrength;
		}

		public WindPoweredGeneratorSpec()
		{
		}
	}
}
