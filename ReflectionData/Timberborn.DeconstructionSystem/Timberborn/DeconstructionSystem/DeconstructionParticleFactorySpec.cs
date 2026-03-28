using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.DeconstructionSystem
{
	internal record DeconstructionParticleFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DeconstructionParticleFactorySpec);
			}
		}

		[Serialize]
		public float MinParticleSpawnThreshold { get; init; }

		[Serialize]
		public float MaxParticleSpawnThreshold { get; init; }

		[Serialize]
		public int MinParticlesForThreshold { get; init; }

		[Serialize]
		public int MaxParticlesForThreshold { get; init; }

		[Serialize]
		public string ParticlePrefabPath { get; init; }

		[Serialize]
		public float MaxNeighboursCount { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DeconstructionParticleFactorySpec");
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
			builder.Append("MinParticleSpawnThreshold = ");
			builder.Append(MinParticleSpawnThreshold.ToString());
			builder.Append(", MaxParticleSpawnThreshold = ");
			builder.Append(MaxParticleSpawnThreshold.ToString());
			builder.Append(", MinParticlesForThreshold = ");
			builder.Append(MinParticlesForThreshold.ToString());
			builder.Append(", MaxParticlesForThreshold = ");
			builder.Append(MaxParticlesForThreshold.ToString());
			builder.Append(", ParticlePrefabPath = ");
			builder.Append((object)ParticlePrefabPath);
			builder.Append(", MaxNeighboursCount = ");
			builder.Append(MaxNeighboursCount.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinParticleSpawnThreshold)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxParticleSpawnThreshold)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MinParticlesForThreshold)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxParticlesForThreshold)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParticlePrefabPath)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxNeighboursCount);
		}

		[CompilerGenerated]
		public virtual bool Equals(DeconstructionParticleFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MinParticleSpawnThreshold, other!.MinParticleSpawnThreshold) && EqualityComparer<float>.Default.Equals(MaxParticleSpawnThreshold, other!.MaxParticleSpawnThreshold) && EqualityComparer<int>.Default.Equals(MinParticlesForThreshold, other!.MinParticlesForThreshold) && EqualityComparer<int>.Default.Equals(MaxParticlesForThreshold, other!.MaxParticlesForThreshold) && EqualityComparer<string>.Default.Equals(ParticlePrefabPath, other!.ParticlePrefabPath))
				{
					return EqualityComparer<float>.Default.Equals(MaxNeighboursCount, other!.MaxNeighboursCount);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DeconstructionParticleFactorySpec(DeconstructionParticleFactorySpec original)
			: base(original)
		{
			MinParticleSpawnThreshold = original.MinParticleSpawnThreshold;
			MaxParticleSpawnThreshold = original.MaxParticleSpawnThreshold;
			MinParticlesForThreshold = original.MinParticlesForThreshold;
			MaxParticlesForThreshold = original.MaxParticlesForThreshold;
			ParticlePrefabPath = original.ParticlePrefabPath;
			MaxNeighboursCount = original.MaxNeighboursCount;
		}

		public DeconstructionParticleFactorySpec()
		{
		}
	}
}
