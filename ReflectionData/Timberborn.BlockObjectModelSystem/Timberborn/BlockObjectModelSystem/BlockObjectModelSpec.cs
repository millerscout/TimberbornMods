using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockObjectModelSystem
{
	internal record BlockObjectModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectModelSpec);
			}
		}

		[Serialize]
		public string FullModelName { get; init; }

		[Serialize]
		public string UncoveredModelName { get; init; }

		[Serialize]
		public string UndergroundModelName { get; init; }

		[Serialize]
		public int UndergroundModelDepth { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectModelSpec");
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
			builder.Append("FullModelName = ");
			builder.Append((object)FullModelName);
			builder.Append(", UncoveredModelName = ");
			builder.Append((object)UncoveredModelName);
			builder.Append(", UndergroundModelName = ");
			builder.Append((object)UndergroundModelName);
			builder.Append(", UndergroundModelDepth = ");
			builder.Append(UndergroundModelDepth.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FullModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UncoveredModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UndergroundModelName)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(UndergroundModelDepth);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(FullModelName, other!.FullModelName) && EqualityComparer<string>.Default.Equals(UncoveredModelName, other!.UncoveredModelName) && EqualityComparer<string>.Default.Equals(UndergroundModelName, other!.UndergroundModelName))
				{
					return EqualityComparer<int>.Default.Equals(UndergroundModelDepth, other!.UndergroundModelDepth);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectModelSpec(BlockObjectModelSpec original)
			: base(original)
		{
			FullModelName = original.FullModelName;
			UncoveredModelName = original.UncoveredModelName;
			UndergroundModelName = original.UndergroundModelName;
			UndergroundModelDepth = original.UndergroundModelDepth;
		}

		public BlockObjectModelSpec()
		{
		}
	}
}
