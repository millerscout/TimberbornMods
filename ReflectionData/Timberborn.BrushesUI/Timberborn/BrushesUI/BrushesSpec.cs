using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BrushesUI
{
	internal record BrushesSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BrushesSpec);
			}
		}

		[Serialize]
		public int MaxBrushSize { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BrushesSpec");
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
			builder.Append("MaxBrushSize = ");
			builder.Append(MaxBrushSize.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxBrushSize);
		}

		[CompilerGenerated]
		public virtual bool Equals(BrushesSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(MaxBrushSize, other!.MaxBrushSize);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BrushesSpec(BrushesSpec original)
			: base(original)
		{
			MaxBrushSize = original.MaxBrushSize;
		}

		public BrushesSpec()
		{
		}
	}
}
