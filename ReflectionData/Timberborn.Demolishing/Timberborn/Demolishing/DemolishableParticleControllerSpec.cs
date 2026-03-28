using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Demolishing
{
	internal record DemolishableParticleControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DemolishableParticleControllerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<DemolishableParticle> DemolishableParticles { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DemolishableParticleControllerSpec");
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
			builder.Append("DemolishableParticles = ");
			builder.Append(DemolishableParticles.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<DemolishableParticle>>.Default.GetHashCode(DemolishableParticles);
		}

		[CompilerGenerated]
		public virtual bool Equals(DemolishableParticleControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<DemolishableParticle>>.Default.Equals(DemolishableParticles, other!.DemolishableParticles);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DemolishableParticleControllerSpec(DemolishableParticleControllerSpec original)
			: base(original)
		{
			DemolishableParticles = original.DemolishableParticles;
		}

		public DemolishableParticleControllerSpec()
		{
		}
	}
}
