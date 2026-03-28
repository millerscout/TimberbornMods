using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PlantingEffects
{
	internal record PlantingParticleControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlantingParticleControllerSpec);
			}
		}

		[Serialize]
		public string ParticlesAttachmentId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlantingParticleControllerSpec");
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
			builder.Append("ParticlesAttachmentId = ");
			builder.Append((object)ParticlesAttachmentId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParticlesAttachmentId);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlantingParticleControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(ParticlesAttachmentId, other!.ParticlesAttachmentId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlantingParticleControllerSpec(PlantingParticleControllerSpec original)
			: base(original)
		{
			ParticlesAttachmentId = original.ParticlesAttachmentId;
		}

		public PlantingParticleControllerSpec()
		{
		}
	}
}
