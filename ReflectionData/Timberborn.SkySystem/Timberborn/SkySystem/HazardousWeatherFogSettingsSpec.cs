using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SkySystem
{
	internal record HazardousWeatherFogSettingsSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(HazardousWeatherFogSettingsSpec);
			}
		}

		[Serialize]
		public string HazardousWeatherId { get; init; }

		[Serialize]
		public FogSettingsSpec FogSettings { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("HazardousWeatherFogSettingsSpec");
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
			builder.Append("HazardousWeatherId = ");
			builder.Append((object)HazardousWeatherId);
			builder.Append(", FogSettings = ");
			builder.Append(FogSettings);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HazardousWeatherId)) * -1521134295 + EqualityComparer<FogSettingsSpec>.Default.GetHashCode(FogSettings);
		}

		[CompilerGenerated]
		public virtual bool Equals(HazardousWeatherFogSettingsSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(HazardousWeatherId, other!.HazardousWeatherId))
				{
					return EqualityComparer<FogSettingsSpec>.Default.Equals(FogSettings, other!.FogSettings);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected HazardousWeatherFogSettingsSpec(HazardousWeatherFogSettingsSpec original)
		{
			HazardousWeatherId = original.HazardousWeatherId;
			FogSettings = original.FogSettings;
		}

		public HazardousWeatherFogSettingsSpec()
		{
		}
	}
}
