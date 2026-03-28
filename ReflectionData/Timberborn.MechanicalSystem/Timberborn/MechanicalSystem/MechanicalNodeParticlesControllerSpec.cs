using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MechanicalSystem
{
	internal record MechanicalNodeParticlesControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MechanicalNodeParticlesControllerSpec);
			}
		}

		[Serialize]
		public float MinEfficiency { get; init; }

		[Serialize]
		public ImmutableArray<string> AttachmentIds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MechanicalNodeParticlesControllerSpec");
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
			builder.Append("MinEfficiency = ");
			builder.Append(MinEfficiency.ToString());
			builder.Append(", AttachmentIds = ");
			builder.Append(AttachmentIds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinEfficiency)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(AttachmentIds);
		}

		[CompilerGenerated]
		public virtual bool Equals(MechanicalNodeParticlesControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MinEfficiency, other!.MinEfficiency))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(AttachmentIds, other!.AttachmentIds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MechanicalNodeParticlesControllerSpec(MechanicalNodeParticlesControllerSpec original)
			: base(original)
		{
			MinEfficiency = original.MinEfficiency;
			AttachmentIds = original.AttachmentIds;
		}

		public MechanicalNodeParticlesControllerSpec()
		{
		}
	}
}
