using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CoreSound
{
	internal record CoreSoundSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CoreSoundSpec);
			}
		}

		[Serialize]
		public int MaxVerticalListenerPositionAboveGround { get; init; }

		[Serialize]
		public float MinBuildingFadeDistance { get; init; }

		[Serialize]
		public float MaxBuildingFadeDistance { get; init; }

		[Serialize]
		public string WindAmbientKey { get; init; }

		[Serialize]
		public float MinAmbientFade { get; init; }

		[Serialize]
		public float MaxAmbientFade { get; init; }

		[Serialize]
		public float MinWindFade { get; init; }

		[Serialize]
		public float MaxWindFade { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CoreSoundSpec");
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
			builder.Append("MaxVerticalListenerPositionAboveGround = ");
			builder.Append(MaxVerticalListenerPositionAboveGround.ToString());
			builder.Append(", MinBuildingFadeDistance = ");
			builder.Append(MinBuildingFadeDistance.ToString());
			builder.Append(", MaxBuildingFadeDistance = ");
			builder.Append(MaxBuildingFadeDistance.ToString());
			builder.Append(", WindAmbientKey = ");
			builder.Append((object)WindAmbientKey);
			builder.Append(", MinAmbientFade = ");
			builder.Append(MinAmbientFade.ToString());
			builder.Append(", MaxAmbientFade = ");
			builder.Append(MaxAmbientFade.ToString());
			builder.Append(", MinWindFade = ");
			builder.Append(MinWindFade.ToString());
			builder.Append(", MaxWindFade = ");
			builder.Append(MaxWindFade.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxVerticalListenerPositionAboveGround)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinBuildingFadeDistance)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxBuildingFadeDistance)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WindAmbientKey)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinAmbientFade)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxAmbientFade)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinWindFade)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWindFade);
		}

		[CompilerGenerated]
		public virtual bool Equals(CoreSoundSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MaxVerticalListenerPositionAboveGround, other!.MaxVerticalListenerPositionAboveGround) && EqualityComparer<float>.Default.Equals(MinBuildingFadeDistance, other!.MinBuildingFadeDistance) && EqualityComparer<float>.Default.Equals(MaxBuildingFadeDistance, other!.MaxBuildingFadeDistance) && EqualityComparer<string>.Default.Equals(WindAmbientKey, other!.WindAmbientKey) && EqualityComparer<float>.Default.Equals(MinAmbientFade, other!.MinAmbientFade) && EqualityComparer<float>.Default.Equals(MaxAmbientFade, other!.MaxAmbientFade) && EqualityComparer<float>.Default.Equals(MinWindFade, other!.MinWindFade))
				{
					return EqualityComparer<float>.Default.Equals(MaxWindFade, other!.MaxWindFade);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CoreSoundSpec(CoreSoundSpec original)
			: base(original)
		{
			MaxVerticalListenerPositionAboveGround = original.MaxVerticalListenerPositionAboveGround;
			MinBuildingFadeDistance = original.MinBuildingFadeDistance;
			MaxBuildingFadeDistance = original.MaxBuildingFadeDistance;
			WindAmbientKey = original.WindAmbientKey;
			MinAmbientFade = original.MinAmbientFade;
			MaxAmbientFade = original.MaxAmbientFade;
			MinWindFade = original.MinWindFade;
			MaxWindFade = original.MaxWindFade;
		}

		public CoreSoundSpec()
		{
		}
	}
}
