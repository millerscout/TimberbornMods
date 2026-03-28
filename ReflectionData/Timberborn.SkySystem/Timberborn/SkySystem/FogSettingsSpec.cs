using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.SkySystem
{
	internal record FogSettingsSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FogSettingsSpec);
			}
		}

		[Serialize]
		public Color FogColor { get; init; }

		[Serialize]
		public float FogDensity { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FogSettingsSpec");
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
			builder.Append("FogColor = ");
			builder.Append(FogColor.ToString());
			builder.Append(", FogDensity = ");
			builder.Append(FogDensity.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(FogColor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FogDensity);
		}

		[CompilerGenerated]
		public virtual bool Equals(FogSettingsSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Color>.Default.Equals(FogColor, other!.FogColor))
				{
					return EqualityComparer<float>.Default.Equals(FogDensity, other!.FogDensity);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FogSettingsSpec(FogSettingsSpec original)
		{
			FogColor = original.FogColor;
			FogDensity = original.FogDensity;
		}

		public FogSettingsSpec()
		{
		}
	}
}
