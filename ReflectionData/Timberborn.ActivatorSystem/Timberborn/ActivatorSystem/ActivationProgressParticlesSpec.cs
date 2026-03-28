using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ActivatorSystem
{
	internal record ActivationProgressParticlesSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ActivationProgressParticlesSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> AttachmentIds { get; init; }

		[Serialize]
		public int MinEmission { get; init; }

		[Serialize]
		public int MaxEmission { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ActivationProgressParticlesSpec");
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
			builder.Append(", MinEmission = ");
			builder.Append(MinEmission.ToString());
			builder.Append(", MaxEmission = ");
			builder.Append(MaxEmission.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(AttachmentIds)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MinEmission)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxEmission);
		}

		[CompilerGenerated]
		public virtual bool Equals(ActivationProgressParticlesSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<string>>.Default.Equals(AttachmentIds, other!.AttachmentIds) && EqualityComparer<int>.Default.Equals(MinEmission, other!.MinEmission))
				{
					return EqualityComparer<int>.Default.Equals(MaxEmission, other!.MaxEmission);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ActivationProgressParticlesSpec(ActivationProgressParticlesSpec original)
			: base(original)
		{
			AttachmentIds = original.AttachmentIds;
			MinEmission = original.MinEmission;
			MaxEmission = original.MaxEmission;
		}

		public ActivationProgressParticlesSpec()
		{
		}
	}
}
