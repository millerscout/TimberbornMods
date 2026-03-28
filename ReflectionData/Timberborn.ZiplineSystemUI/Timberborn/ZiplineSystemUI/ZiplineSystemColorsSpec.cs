using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.ZiplineSystemUI
{
	internal record ZiplineSystemColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ZiplineSystemColorsSpec);
			}
		}

		[Serialize]
		public Color OriginColor { get; init; }

		[Serialize]
		public Color ConnectableColor { get; init; }

		[Serialize]
		public Color NotConnectableColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ZiplineSystemColorsSpec");
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
			builder.Append("OriginColor = ");
			builder.Append(OriginColor.ToString());
			builder.Append(", ConnectableColor = ");
			builder.Append(ConnectableColor.ToString());
			builder.Append(", NotConnectableColor = ");
			builder.Append(NotConnectableColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(OriginColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ConnectableColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(NotConnectableColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(ZiplineSystemColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(OriginColor, other!.OriginColor) && EqualityComparer<Color>.Default.Equals(ConnectableColor, other!.ConnectableColor))
				{
					return EqualityComparer<Color>.Default.Equals(NotConnectableColor, other!.NotConnectableColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ZiplineSystemColorsSpec(ZiplineSystemColorsSpec original)
			: base(original)
		{
			OriginColor = original.OriginColor;
			ConnectableColor = original.ConnectableColor;
			NotConnectableColor = original.NotConnectableColor;
		}

		public ZiplineSystemColorsSpec()
		{
		}
	}
}
