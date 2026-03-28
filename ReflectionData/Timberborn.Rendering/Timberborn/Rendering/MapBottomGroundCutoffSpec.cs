using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Rendering
{
	internal record MapBottomGroundCutoffSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MapBottomGroundCutoffSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> Targets { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MapBottomGroundCutoffSpec");
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
			builder.Append("Targets = ");
			builder.Append(Targets.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Targets);
		}

		[CompilerGenerated]
		public virtual bool Equals(MapBottomGroundCutoffSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Targets, other!.Targets);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MapBottomGroundCutoffSpec(MapBottomGroundCutoffSpec original)
			: base(original)
		{
			Targets = original.Targets;
		}

		public MapBottomGroundCutoffSpec()
		{
		}
	}
}
