using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NeedSuspending
{
	internal record EntererNeedSuspendingBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EntererNeedSuspendingBuildingSpec);
			}
		}

		[Serialize]
		public NeedSuspender NeedSuspender { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EntererNeedSuspendingBuildingSpec");
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
			builder.Append("NeedSuspender = ");
			builder.Append(NeedSuspender);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<NeedSuspender>.Default.GetHashCode(NeedSuspender);
		}

		[CompilerGenerated]
		public virtual bool Equals(EntererNeedSuspendingBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<NeedSuspender>.Default.Equals(NeedSuspender, other!.NeedSuspender);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected EntererNeedSuspendingBuildingSpec(EntererNeedSuspendingBuildingSpec original)
			: base(original)
		{
			NeedSuspender = original.NeedSuspender;
		}

		public EntererNeedSuspendingBuildingSpec()
		{
		}
	}
}
