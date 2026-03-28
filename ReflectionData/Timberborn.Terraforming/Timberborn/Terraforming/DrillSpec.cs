using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Terraforming
{
	internal record DrillSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DrillSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector3Int> DrillableCoordinates { get; init; }

		[Serialize]
		public string RemovalEffectPath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DrillSpec");
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
			builder.Append("DrillableCoordinates = ");
			builder.Append(DrillableCoordinates.ToString());
			builder.Append(", RemovalEffectPath = ");
			builder.Append((object)RemovalEffectPath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<Vector3Int>>.Default.GetHashCode(DrillableCoordinates)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RemovalEffectPath);
		}

		[CompilerGenerated]
		public virtual bool Equals(DrillSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<Vector3Int>>.Default.Equals(DrillableCoordinates, other!.DrillableCoordinates))
				{
					return EqualityComparer<string>.Default.Equals(RemovalEffectPath, other!.RemovalEffectPath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DrillSpec(DrillSpec original)
			: base(original)
		{
			DrillableCoordinates = original.DrillableCoordinates;
			RemovalEffectPath = original.RemovalEffectPath;
		}

		public DrillSpec()
		{
		}
	}
}
