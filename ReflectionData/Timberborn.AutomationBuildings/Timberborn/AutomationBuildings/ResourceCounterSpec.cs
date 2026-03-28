using System;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.AutomationBuildings
{
	internal record ResourceCounterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ResourceCounterSpec);
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ResourceCounterSpec");
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
		public virtual bool Equals(ResourceCounterSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected ResourceCounterSpec(ResourceCounterSpec original)
			: base(original)
		{
		}

		public ResourceCounterSpec()
		{
		}
	}
}
