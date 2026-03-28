using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Demolishing
{
	public record DemolishableScienceRewardSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DemolishableScienceRewardSpec);
			}
		}

		[Serialize]
		public int SciencePoints { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DemolishableScienceRewardSpec");
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
			builder.Append("SciencePoints = ");
			builder.Append(SciencePoints.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(SciencePoints);
		}

		[CompilerGenerated]
		public virtual bool Equals(DemolishableScienceRewardSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(SciencePoints, other!.SciencePoints);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DemolishableScienceRewardSpec(DemolishableScienceRewardSpec original)
			: base(original)
		{
			SciencePoints = original.SciencePoints;
		}

		public DemolishableScienceRewardSpec()
		{
		}
	}
}
