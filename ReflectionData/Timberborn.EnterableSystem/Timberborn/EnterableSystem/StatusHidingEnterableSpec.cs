using System;
using System.Runtime.CompilerServices;
using System.Text;
using JetBrains.Annotations;
using Timberborn.BlueprintSystem;

namespace Timberborn.EnterableSystem
{
	[UsedImplicitly]
	internal record StatusHidingEnterableSpec : ComponentSpec, IStatusHider
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(StatusHidingEnterableSpec);
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StatusHidingEnterableSpec");
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
			return base.PrintMembers(builder);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[CompilerGenerated]
		public virtual bool Equals(StatusHidingEnterableSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected StatusHidingEnterableSpec(StatusHidingEnterableSpec original)
			: base(original)
		{
		}

		public StatusHidingEnterableSpec()
		{
		}
	}
}
