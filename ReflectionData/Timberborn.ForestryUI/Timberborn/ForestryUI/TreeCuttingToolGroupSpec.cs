using System;
using System.Runtime.CompilerServices;
using System.Text;
using JetBrains.Annotations;
using Timberborn.BlueprintSystem;

namespace Timberborn.ForestryUI
{
	[UsedImplicitly]
	internal record TreeCuttingToolGroupSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TreeCuttingToolGroupSpec);
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TreeCuttingToolGroupSpec");
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
		public virtual bool Equals(TreeCuttingToolGroupSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected TreeCuttingToolGroupSpec(TreeCuttingToolGroupSpec original)
			: base(original)
		{
		}

		public TreeCuttingToolGroupSpec()
		{
		}
	}
}
