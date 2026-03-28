using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.CoreUI
{
	public record GradientPointSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GradientPointSpec);
			}
		}

		[Serialize]
		public Color Color { get; init; }

		[Serialize]
		public float Time { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GradientPointSpec");
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
			builder.Append("Color = ");
			builder.Append(Color.ToString());
			builder.Append(", Time = ");
			builder.Append(Time.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(Color)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Time);
		}

		[CompilerGenerated]
		public virtual bool Equals(GradientPointSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Color>.Default.Equals(Color, other!.Color))
				{
					return EqualityComparer<float>.Default.Equals(Time, other!.Time);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GradientPointSpec(GradientPointSpec original)
		{
			Color = original.Color;
			Time = original.Time;
		}

		public GradientPointSpec()
		{
		}
	}
}
