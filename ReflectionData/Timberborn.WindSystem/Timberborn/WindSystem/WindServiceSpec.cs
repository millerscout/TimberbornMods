using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WindSystem
{
	internal record WindServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WindServiceSpec);
			}
		}

		[Serialize]
		public float MinWindTimeInHours { get; init; }

		[Serialize]
		public float MaxWindTimeInHours { get; init; }

		[Serialize]
		public float MinWindStrength { get; init; }

		[Serialize]
		public float MaxWindStrength { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WindServiceSpec");
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
			builder.Append("MinWindTimeInHours = ");
			builder.Append(MinWindTimeInHours.ToString());
			builder.Append(", MaxWindTimeInHours = ");
			builder.Append(MaxWindTimeInHours.ToString());
			builder.Append(", MinWindStrength = ");
			builder.Append(MinWindStrength.ToString());
			builder.Append(", MaxWindStrength = ");
			builder.Append(MaxWindStrength.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinWindTimeInHours)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWindTimeInHours)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinWindStrength)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWindStrength);
		}

		[CompilerGenerated]
		public virtual bool Equals(WindServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MinWindTimeInHours, other!.MinWindTimeInHours) && EqualityComparer<float>.Default.Equals(MaxWindTimeInHours, other!.MaxWindTimeInHours) && EqualityComparer<float>.Default.Equals(MinWindStrength, other!.MinWindStrength))
				{
					return EqualityComparer<float>.Default.Equals(MaxWindStrength, other!.MaxWindStrength);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WindServiceSpec(WindServiceSpec original)
			: base(original)
		{
			MinWindTimeInHours = original.MinWindTimeInHours;
			MaxWindTimeInHours = original.MaxWindTimeInHours;
			MinWindStrength = original.MinWindStrength;
			MaxWindStrength = original.MaxWindStrength;
		}

		public WindServiceSpec()
		{
		}
	}
}
