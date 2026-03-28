using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Explosions
{
	public record UnstableCoreLightingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UnstableCoreLightingSpec);
			}
		}

		[Serialize]
		public float MinInterval { get; init; }

		[Serialize]
		public float MaxInterval { get; init; }

		[Serialize]
		public float LightStrength { get; init; }

		[Serialize]
		public string AttachmentId { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UnstableCoreLightingSpec");
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
			builder.Append("MinInterval = ");
			builder.Append(MinInterval.ToString());
			builder.Append(", MaxInterval = ");
			builder.Append(MaxInterval.ToString());
			builder.Append(", LightStrength = ");
			builder.Append(LightStrength.ToString());
			builder.Append(", AttachmentId = ");
			builder.Append((object)AttachmentId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinInterval)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxInterval)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(LightStrength)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AttachmentId);
		}

		[CompilerGenerated]
		public virtual bool Equals(UnstableCoreLightingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MinInterval, other!.MinInterval) && EqualityComparer<float>.Default.Equals(MaxInterval, other!.MaxInterval) && EqualityComparer<float>.Default.Equals(LightStrength, other!.LightStrength))
				{
					return EqualityComparer<string>.Default.Equals(AttachmentId, other!.AttachmentId);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UnstableCoreLightingSpec(UnstableCoreLightingSpec original)
			: base(original)
		{
			MinInterval = original.MinInterval;
			MaxInterval = original.MaxInterval;
			LightStrength = original.LightStrength;
			AttachmentId = original.AttachmentId;
		}

		public UnstableCoreLightingSpec()
		{
		}
	}
}
