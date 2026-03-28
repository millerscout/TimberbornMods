using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Particles
{
	internal record AnimationParticlesTriggerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AnimationParticlesTriggerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<AnimationParticle> AnimationParticles { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AnimationParticlesTriggerSpec");
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
			builder.Append("AnimationParticles = ");
			builder.Append(AnimationParticles.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<AnimationParticle>>.Default.GetHashCode(AnimationParticles);
		}

		[CompilerGenerated]
		public virtual bool Equals(AnimationParticlesTriggerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<AnimationParticle>>.Default.Equals(AnimationParticles, other!.AnimationParticles);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AnimationParticlesTriggerSpec(AnimationParticlesTriggerSpec original)
			: base(original)
		{
			AnimationParticles = original.AnimationParticles;
		}

		public AnimationParticlesTriggerSpec()
		{
		}
	}
}
