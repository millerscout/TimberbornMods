using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Particles
{
	internal record AnimationParticle
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AnimationParticle);
			}
		}

		[Serialize]
		public string AnimationName { get; init; }

		[Serialize]
		public string ParticlesAttachmentId { get; init; }

		[Serialize]
		public ImmutableArray<float> TriggerTimes { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AnimationParticle");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("AnimationName = ");
			builder.Append((object)AnimationName);
			builder.Append(", ParticlesAttachmentId = ");
			builder.Append((object)ParticlesAttachmentId);
			builder.Append(", TriggerTimes = ");
			builder.Append(TriggerTimes.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AnimationName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParticlesAttachmentId)) * -1521134295 + EqualityComparer<ImmutableArray<float>>.Default.GetHashCode(TriggerTimes);
		}

		[CompilerGenerated]
		public virtual bool Equals(AnimationParticle? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(AnimationName, other!.AnimationName) && EqualityComparer<string>.Default.Equals(ParticlesAttachmentId, other!.ParticlesAttachmentId))
				{
					return EqualityComparer<ImmutableArray<float>>.Default.Equals(TriggerTimes, other!.TriggerTimes);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AnimationParticle(AnimationParticle original)
		{
			AnimationName = original.AnimationName;
			ParticlesAttachmentId = original.ParticlesAttachmentId;
			TriggerTimes = original.TriggerTimes;
		}

		public AnimationParticle()
		{
		}
	}
}
