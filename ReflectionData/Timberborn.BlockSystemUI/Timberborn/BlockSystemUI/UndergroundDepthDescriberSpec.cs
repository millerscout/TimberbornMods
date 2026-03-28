using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockSystemUI
{
	internal record UndergroundDepthDescriberSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UndergroundDepthDescriberSpec);
			}
		}

		[Serialize]
		public int Depth { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UndergroundDepthDescriberSpec");
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
			builder.Append("Depth = ");
			builder.Append(Depth.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Depth);
		}

		[CompilerGenerated]
		public virtual bool Equals(UndergroundDepthDescriberSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(Depth, other!.Depth);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UndergroundDepthDescriberSpec(UndergroundDepthDescriberSpec original)
			: base(original)
		{
			Depth = original.Depth;
		}

		public UndergroundDepthDescriberSpec()
		{
		}
	}
}
