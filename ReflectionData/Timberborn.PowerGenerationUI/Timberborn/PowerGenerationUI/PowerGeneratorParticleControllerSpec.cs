using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PowerGenerationUI
{
	internal record PowerGeneratorParticleControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PowerGeneratorParticleControllerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> AttachmentIds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PowerGeneratorParticleControllerSpec");
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
			builder.Append("AttachmentIds = ");
			builder.Append(AttachmentIds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(AttachmentIds);
		}

		[CompilerGenerated]
		public virtual bool Equals(PowerGeneratorParticleControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(AttachmentIds, other!.AttachmentIds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PowerGeneratorParticleControllerSpec(PowerGeneratorParticleControllerSpec original)
			: base(original)
		{
			AttachmentIds = original.AttachmentIds;
		}

		public PowerGeneratorParticleControllerSpec()
		{
		}
	}
}
