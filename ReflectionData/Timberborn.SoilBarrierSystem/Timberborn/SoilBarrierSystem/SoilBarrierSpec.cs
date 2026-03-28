using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SoilBarrierSystem
{
	internal record SoilBarrierSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SoilBarrierSpec);
			}
		}

		[Serialize]
		public bool BlockAboveMoisture { get; init; }

		[Serialize]
		public bool BlockFullMoisture { get; init; }

		[Serialize]
		public bool BlockContamination { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SoilBarrierSpec");
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
			builder.Append("BlockAboveMoisture = ");
			builder.Append(BlockAboveMoisture.ToString());
			builder.Append(", BlockFullMoisture = ");
			builder.Append(BlockFullMoisture.ToString());
			builder.Append(", BlockContamination = ");
			builder.Append(BlockContamination.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(BlockAboveMoisture)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(BlockFullMoisture)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(BlockContamination);
		}

		[CompilerGenerated]
		public virtual bool Equals(SoilBarrierSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(BlockAboveMoisture, other!.BlockAboveMoisture) && EqualityComparer<bool>.Default.Equals(BlockFullMoisture, other!.BlockFullMoisture))
				{
					return EqualityComparer<bool>.Default.Equals(BlockContamination, other!.BlockContamination);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SoilBarrierSpec(SoilBarrierSpec original)
			: base(original)
		{
			BlockAboveMoisture = original.BlockAboveMoisture;
			BlockFullMoisture = original.BlockFullMoisture;
			BlockContamination = original.BlockContamination;
		}

		public SoilBarrierSpec()
		{
		}
	}
}
