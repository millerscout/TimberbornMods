using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PrefabOptimization
{
	internal record AutoAtlaserSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AutoAtlaserSpec);
			}
		}

		[Serialize]
		public ImmutableArray<AutoAtlasSpec> AutoAtlases { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AutoAtlaserSpec");
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
			builder.Append("AutoAtlases = ");
			builder.Append(AutoAtlases.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<AutoAtlasSpec>>.Default.GetHashCode(AutoAtlases);
		}

		[CompilerGenerated]
		public virtual bool Equals(AutoAtlaserSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<AutoAtlasSpec>>.Default.Equals(AutoAtlases, other!.AutoAtlases);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AutoAtlaserSpec(AutoAtlaserSpec original)
			: base(original)
		{
			AutoAtlases = original.AutoAtlases;
		}

		public AutoAtlaserSpec()
		{
		}
	}
}
