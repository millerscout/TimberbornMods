using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.AutomationUI
{
	internal record TransmitterPickerColorsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TransmitterPickerColorsSpec);
			}
		}

		[Serialize]
		public Color TransmitterColor { get; init; }

		[Serialize]
		public Color UnfinishedTransmitterColor { get; init; }

		[Serialize]
		public Color HoveredTransmitterColor { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TransmitterPickerColorsSpec");
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
			builder.Append("TransmitterColor = ");
			builder.Append(TransmitterColor.ToString());
			builder.Append(", UnfinishedTransmitterColor = ");
			builder.Append(UnfinishedTransmitterColor.ToString());
			builder.Append(", HoveredTransmitterColor = ");
			builder.Append(HoveredTransmitterColor.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(TransmitterColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(UnfinishedTransmitterColor)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(HoveredTransmitterColor);
		}

		[CompilerGenerated]
		public virtual bool Equals(TransmitterPickerColorsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(TransmitterColor, other!.TransmitterColor) && EqualityComparer<Color>.Default.Equals(UnfinishedTransmitterColor, other!.UnfinishedTransmitterColor))
				{
					return EqualityComparer<Color>.Default.Equals(HoveredTransmitterColor, other!.HoveredTransmitterColor);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TransmitterPickerColorsSpec(TransmitterPickerColorsSpec original)
			: base(original)
		{
			TransmitterColor = original.TransmitterColor;
			UnfinishedTransmitterColor = original.UnfinishedTransmitterColor;
			HoveredTransmitterColor = original.HoveredTransmitterColor;
		}

		public TransmitterPickerColorsSpec()
		{
		}
	}
}
