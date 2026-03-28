using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GameSound
{
	internal record AmbientSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AmbientSpec);
			}
		}

		[Serialize]
		public string DayAmbient { get; init; }

		[Serialize]
		public string NightAmbient { get; init; }

		[Serialize]
		public string WaterAmbient { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AmbientSpec");
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
			builder.Append("DayAmbient = ");
			builder.Append((object)DayAmbient);
			builder.Append(", NightAmbient = ");
			builder.Append((object)NightAmbient);
			builder.Append(", WaterAmbient = ");
			builder.Append((object)WaterAmbient);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DayAmbient)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NightAmbient)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WaterAmbient);
		}

		[CompilerGenerated]
		public virtual bool Equals(AmbientSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(DayAmbient, other!.DayAmbient) && EqualityComparer<string>.Default.Equals(NightAmbient, other!.NightAmbient))
				{
					return EqualityComparer<string>.Default.Equals(WaterAmbient, other!.WaterAmbient);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AmbientSpec(AmbientSpec original)
			: base(original)
		{
			DayAmbient = original.DayAmbient;
			NightAmbient = original.NightAmbient;
			WaterAmbient = original.WaterAmbient;
		}

		public AmbientSpec()
		{
		}
	}
}
