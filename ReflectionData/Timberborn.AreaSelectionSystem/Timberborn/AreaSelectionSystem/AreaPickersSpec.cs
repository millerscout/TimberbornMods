using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.AreaSelectionSystem
{
	internal record AreaPickersSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AreaPickersSpec);
			}
		}

		[Serialize]
		public int AreaMaxBlocks { get; init; }

		[Serialize]
		public int SculptingMaxBlocks { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AreaPickersSpec");
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
			builder.Append("AreaMaxBlocks = ");
			builder.Append(AreaMaxBlocks.ToString());
			builder.Append(", SculptingMaxBlocks = ");
			builder.Append(SculptingMaxBlocks.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AreaMaxBlocks)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SculptingMaxBlocks);
		}

		[CompilerGenerated]
		public virtual bool Equals(AreaPickersSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(AreaMaxBlocks, other!.AreaMaxBlocks))
				{
					return EqualityComparer<int>.Default.Equals(SculptingMaxBlocks, other!.SculptingMaxBlocks);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AreaPickersSpec(AreaPickersSpec original)
			: base(original)
		{
			AreaMaxBlocks = original.AreaMaxBlocks;
			SculptingMaxBlocks = original.SculptingMaxBlocks;
		}

		public AreaPickersSpec()
		{
		}
	}
}
