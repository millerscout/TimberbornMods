using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.FactionSystem
{
	public record UnlockableFactionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UnlockableFactionSpec);
			}
		}

		[Serialize]
		public string PrerequisiteFaction { get; init; }

		[Serialize]
		public int AverageWellbeingToUnlock { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UnlockableFactionSpec");
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
			builder.Append("PrerequisiteFaction = ");
			builder.Append((object)PrerequisiteFaction);
			builder.Append(", AverageWellbeingToUnlock = ");
			builder.Append(AverageWellbeingToUnlock.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PrerequisiteFaction)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AverageWellbeingToUnlock);
		}

		[CompilerGenerated]
		public virtual bool Equals(UnlockableFactionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(PrerequisiteFaction, other!.PrerequisiteFaction))
				{
					return EqualityComparer<int>.Default.Equals(AverageWellbeingToUnlock, other!.AverageWellbeingToUnlock);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UnlockableFactionSpec(UnlockableFactionSpec original)
			: base(original)
		{
			PrerequisiteFaction = original.PrerequisiteFaction;
			AverageWellbeingToUnlock = original.AverageWellbeingToUnlock;
		}

		public UnlockableFactionSpec()
		{
		}
	}
}
