using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.RecoveredGoodSystem
{
	internal record RecoveredGoodStackModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RecoveredGoodStackModelSpec);
			}
		}

		[Serialize]
		public string ModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RecoveredGoodStackModelSpec");
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
			builder.Append("ModelName = ");
			builder.Append((object)ModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(RecoveredGoodStackModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(ModelName, other!.ModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RecoveredGoodStackModelSpec(RecoveredGoodStackModelSpec original)
			: base(original)
		{
			ModelName = original.ModelName;
		}

		public RecoveredGoodStackModelSpec()
		{
		}
	}
}
