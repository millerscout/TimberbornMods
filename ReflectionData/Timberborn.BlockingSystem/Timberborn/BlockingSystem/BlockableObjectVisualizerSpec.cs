using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockingSystem
{
	internal record BlockableObjectVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockableObjectVisualizerSpec);
			}
		}

		[Serialize]
		public string HideableObjectName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockableObjectVisualizerSpec");
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
			builder.Append("HideableObjectName = ");
			builder.Append((object)HideableObjectName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(HideableObjectName);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockableObjectVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(HideableObjectName, other!.HideableObjectName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockableObjectVisualizerSpec(BlockableObjectVisualizerSpec original)
			: base(original)
		{
			HideableObjectName = original.HideableObjectName;
		}

		public BlockableObjectVisualizerSpec()
		{
		}
	}
}
