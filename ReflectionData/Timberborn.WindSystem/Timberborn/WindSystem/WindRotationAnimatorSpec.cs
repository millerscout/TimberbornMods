using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WindSystem
{
	internal record WindRotationAnimatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WindRotationAnimatorSpec);
			}
		}

		[Serialize]
		public ImmutableArray<WindRotatorSpec> WindRotators { get; init; }

		[Serialize]
		public WindRotatorSpec Tower { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WindRotationAnimatorSpec");
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
			builder.Append("WindRotators = ");
			builder.Append(WindRotators.ToString());
			builder.Append(", Tower = ");
			builder.Append(Tower);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<WindRotatorSpec>>.Default.GetHashCode(WindRotators)) * -1521134295 + EqualityComparer<WindRotatorSpec>.Default.GetHashCode(Tower);
		}

		[CompilerGenerated]
		public virtual bool Equals(WindRotationAnimatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<WindRotatorSpec>>.Default.Equals(WindRotators, other!.WindRotators))
				{
					return EqualityComparer<WindRotatorSpec>.Default.Equals(Tower, other!.Tower);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WindRotationAnimatorSpec(WindRotationAnimatorSpec original)
			: base(original)
		{
			WindRotators = original.WindRotators;
			Tower = original.Tower;
		}

		public WindRotationAnimatorSpec()
		{
		}
	}
}
