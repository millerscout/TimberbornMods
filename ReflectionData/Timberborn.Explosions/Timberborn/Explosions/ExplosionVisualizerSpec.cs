using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Explosions
{
	internal record ExplosionVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ExplosionVisualizerSpec);
			}
		}

		[Serialize]
		public Color ObjectHighlightColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ExplosionVisualizerSpec");
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
			builder.Append("ObjectHighlightColor = ");
			builder.Append(ObjectHighlightColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ObjectHighlightColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(ExplosionVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Color>.Default.Equals(ObjectHighlightColor, other!.ObjectHighlightColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ExplosionVisualizerSpec(ExplosionVisualizerSpec original)
			: base(original)
		{
			ObjectHighlightColor = original.ObjectHighlightColor;
		}

		public ExplosionVisualizerSpec()
		{
		}
	}
}
