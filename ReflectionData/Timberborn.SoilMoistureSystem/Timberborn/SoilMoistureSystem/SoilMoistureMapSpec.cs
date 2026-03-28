using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SoilMoistureSystem
{
	internal record SoilMoistureMapSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SoilMoistureMapSpec);
			}
		}

		[Serialize]
		public float MaxDesertIntensity { get; init; }

		[Serialize]
		public int DesertMoistureThreshold { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SoilMoistureMapSpec");
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
			builder.Append("MaxDesertIntensity = ");
			builder.Append(MaxDesertIntensity.ToString());
			builder.Append(", DesertMoistureThreshold = ");
			builder.Append(DesertMoistureThreshold.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxDesertIntensity)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(DesertMoistureThreshold);
		}

		[CompilerGenerated]
		public virtual bool Equals(SoilMoistureMapSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(MaxDesertIntensity, other!.MaxDesertIntensity))
				{
					return EqualityComparer<int>.Default.Equals(DesertMoistureThreshold, other!.DesertMoistureThreshold);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SoilMoistureMapSpec(SoilMoistureMapSpec original)
			: base(original)
		{
			MaxDesertIntensity = original.MaxDesertIntensity;
			DesertMoistureThreshold = original.DesertMoistureThreshold;
		}

		public SoilMoistureMapSpec()
		{
		}
	}
}
