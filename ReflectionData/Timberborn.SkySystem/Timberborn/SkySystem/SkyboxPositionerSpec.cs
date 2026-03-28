using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.SkySystem
{
	internal record SkyboxPositionerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SkyboxPositionerSpec);
			}
		}

		[Serialize]
		public AssetRef<Material> Skybox { get; init; }

		[Serialize]
		public float DayProgressSunrise { get; init; }

		[Serialize]
		public float DayProgressDay { get; init; }

		[Serialize]
		public float DayProgressSunset { get; init; }

		[Serialize]
		public float DayProgressNight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SkyboxPositionerSpec");
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
			builder.Append("Skybox = ");
			builder.Append(Skybox);
			builder.Append(", DayProgressSunrise = ");
			builder.Append(DayProgressSunrise.ToString());
			builder.Append(", DayProgressDay = ");
			builder.Append(DayProgressDay.ToString());
			builder.Append(", DayProgressSunset = ");
			builder.Append(DayProgressSunset.ToString());
			builder.Append(", DayProgressNight = ");
			builder.Append(DayProgressNight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(Skybox)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DayProgressSunrise)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DayProgressDay)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DayProgressSunset)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DayProgressNight);
		}

		[CompilerGenerated]
		public virtual bool Equals(SkyboxPositionerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<Material>>.Default.Equals(Skybox, other!.Skybox) && EqualityComparer<float>.Default.Equals(DayProgressSunrise, other!.DayProgressSunrise) && EqualityComparer<float>.Default.Equals(DayProgressDay, other!.DayProgressDay) && EqualityComparer<float>.Default.Equals(DayProgressSunset, other!.DayProgressSunset))
				{
					return EqualityComparer<float>.Default.Equals(DayProgressNight, other!.DayProgressNight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SkyboxPositionerSpec(SkyboxPositionerSpec original)
			: base(original)
		{
			Skybox = original.Skybox;
			DayProgressSunrise = original.DayProgressSunrise;
			DayProgressDay = original.DayProgressDay;
			DayProgressSunset = original.DayProgressSunset;
			DayProgressNight = original.DayProgressNight;
		}

		public SkyboxPositionerSpec()
		{
		}
	}
}
