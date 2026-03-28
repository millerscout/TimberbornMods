using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MechanicalSystem
{
	public record TransputProviderSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TransputProviderSpec);
			}
		}

		[Serialize]
		public ImmutableArray<TransputSpec> Transputs { get; init; }

		[Serialize]
		public bool IgnoreRotation { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TransputProviderSpec");
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
			builder.Append("Transputs = ");
			builder.Append(Transputs.ToString());
			builder.Append(", IgnoreRotation = ");
			builder.Append(IgnoreRotation.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<TransputSpec>>.Default.GetHashCode(Transputs)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IgnoreRotation);
		}

		[CompilerGenerated]
		public virtual bool Equals(TransputProviderSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<TransputSpec>>.Default.Equals(Transputs, other!.Transputs))
				{
					return EqualityComparer<bool>.Default.Equals(IgnoreRotation, other!.IgnoreRotation);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TransputProviderSpec(TransputProviderSpec original)
			: base(original)
		{
			Transputs = original.Transputs;
			IgnoreRotation = original.IgnoreRotation;
		}

		public TransputProviderSpec()
		{
		}
	}
}
