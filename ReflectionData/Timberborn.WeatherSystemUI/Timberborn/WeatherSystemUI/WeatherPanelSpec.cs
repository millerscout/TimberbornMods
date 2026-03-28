using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WeatherSystemUI
{
	internal record WeatherPanelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WeatherPanelSpec);
			}
		}

		[Serialize]
		public int NumberOfBlinks { get; init; }

		[Serialize]
		public float SecondsBetweenBlinks { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WeatherPanelSpec");
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
			builder.Append("NumberOfBlinks = ");
			builder.Append(NumberOfBlinks.ToString());
			builder.Append(", SecondsBetweenBlinks = ");
			builder.Append(SecondsBetweenBlinks.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(NumberOfBlinks)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(SecondsBetweenBlinks);
		}

		[CompilerGenerated]
		public virtual bool Equals(WeatherPanelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(NumberOfBlinks, other!.NumberOfBlinks))
				{
					return EqualityComparer<float>.Default.Equals(SecondsBetweenBlinks, other!.SecondsBetweenBlinks);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WeatherPanelSpec(WeatherPanelSpec original)
			: base(original)
		{
			NumberOfBlinks = original.NumberOfBlinks;
			SecondsBetweenBlinks = original.SecondsBetweenBlinks;
		}

		public WeatherPanelSpec()
		{
		}
	}
}
