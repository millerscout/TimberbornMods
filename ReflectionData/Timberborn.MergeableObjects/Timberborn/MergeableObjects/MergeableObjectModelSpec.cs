using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MergeableObjects
{
	internal record MergeableObjectModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MergeableObjectModelSpec);
			}
		}

		[Serialize]
		public string ModelNamePrefix { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MergeableObjectModelSpec");
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
			builder.Append("ModelNamePrefix = ");
			builder.Append((object)ModelNamePrefix);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ModelNamePrefix);
		}

		[CompilerGenerated]
		public virtual bool Equals(MergeableObjectModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(ModelNamePrefix, other!.ModelNamePrefix);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MergeableObjectModelSpec(MergeableObjectModelSpec original)
			: base(original)
		{
			ModelNamePrefix = original.ModelNamePrefix;
		}

		public MergeableObjectModelSpec()
		{
		}
	}
}
