using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Buildings
{
	internal record BuildingModelGroundCutoffSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildingModelGroundCutoffSpec);
			}
		}

		[Serialize]
		public ImmutableArray<string> Targets { get; init; }

		[Serialize]
		public float Offset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildingModelGroundCutoffSpec");
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
			builder.Append(", Offset = ");
			builder.Append(Offset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Targets)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Offset);
		}

		[CompilerGenerated]
		public virtual bool Equals(BuildingModelGroundCutoffSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<string>>.Default.Equals(Targets, other!.Targets))
				{
					return EqualityComparer<float>.Default.Equals(Offset, other!.Offset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BuildingModelGroundCutoffSpec(BuildingModelGroundCutoffSpec original)
			: base(original)
		{
			Targets = original.Targets;
			Offset = original.Offset;
		}

		public BuildingModelGroundCutoffSpec()
		{
		}
	}
}
