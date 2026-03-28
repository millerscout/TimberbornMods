using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TubeSystem
{
	internal record TubePlatformSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TubePlatformSpec);
			}
		}

		[Serialize]
		public string PlatformModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TubePlatformSpec");
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
			builder.Append("PlatformModelName = ");
			builder.Append((object)PlatformModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PlatformModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(TubePlatformSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(PlatformModelName, other!.PlatformModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TubePlatformSpec(TubePlatformSpec original)
			: base(original)
		{
			PlatformModelName = original.PlatformModelName;
		}

		public TubePlatformSpec()
		{
		}
	}
}
