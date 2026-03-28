using System;
using System.Runtime.CompilerServices;
using System.Text;
using JetBrains.Annotations;
using Timberborn.BlueprintSystem;

namespace Timberborn.BuilderPrioritySystemUI
{
	[UsedImplicitly]
	internal record BuilderPriorityToolGroupSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuilderPriorityToolGroupSpec);
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuilderPriorityToolGroupSpec");
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
		public virtual bool Equals(BuilderPriorityToolGroupSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected BuilderPriorityToolGroupSpec(BuilderPriorityToolGroupSpec original)
			: base(original)
		{
		}

		public BuilderPriorityToolGroupSpec()
		{
		}
	}
}
