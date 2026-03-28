using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.DecalSystem
{
	internal record FlippableDecalSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FlippableDecalSpec);
			}
		}

		[Serialize]
		public string DecalName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FlippableDecalSpec");
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
			builder.Append("DecalName = ");
			builder.Append((object)DecalName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DecalName);
		}

		[CompilerGenerated]
		public virtual bool Equals(FlippableDecalSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(DecalName, other!.DecalName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FlippableDecalSpec(FlippableDecalSpec original)
			: base(original)
		{
			DecalName = original.DecalName;
		}

		public FlippableDecalSpec()
		{
		}
	}
}
