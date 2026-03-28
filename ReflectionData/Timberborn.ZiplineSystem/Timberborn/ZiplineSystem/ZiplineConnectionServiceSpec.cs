using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ZiplineSystem
{
	internal record ZiplineConnectionServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ZiplineConnectionServiceSpec);
			}
		}

		[Serialize]
		public int MaxCableInclination { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ZiplineConnectionServiceSpec");
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
			builder.Append("MaxCableInclination = ");
			builder.Append(MaxCableInclination.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxCableInclination);
		}

		[CompilerGenerated]
		public virtual bool Equals(ZiplineConnectionServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(MaxCableInclination, other!.MaxCableInclination);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ZiplineConnectionServiceSpec(ZiplineConnectionServiceSpec original)
			: base(original)
		{
			MaxCableInclination = original.MaxCableInclination;
		}

		public ZiplineConnectionServiceSpec()
		{
		}
	}
}
