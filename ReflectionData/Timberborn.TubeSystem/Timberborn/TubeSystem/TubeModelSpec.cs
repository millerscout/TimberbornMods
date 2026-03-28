using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TubeSystem
{
	internal record TubeModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TubeModelSpec);
			}
		}

		[Serialize]
		public string ModelPrefix { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TubeModelSpec");
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
			builder.Append("ModelPrefix = ");
			builder.Append((object)ModelPrefix);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ModelPrefix);
		}

		[CompilerGenerated]
		public virtual bool Equals(TubeModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(ModelPrefix, other!.ModelPrefix);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TubeModelSpec(TubeModelSpec original)
			: base(original)
		{
			ModelPrefix = original.ModelPrefix;
		}

		public TubeModelSpec()
		{
		}
	}
}
