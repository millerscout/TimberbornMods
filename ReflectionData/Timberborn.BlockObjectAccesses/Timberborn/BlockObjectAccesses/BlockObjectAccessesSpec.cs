using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockObjectAccesses
{
	public record BlockObjectAccessesSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectAccessesSpec);
			}
		}

		[Serialize]
		public ImmutableArray<Vector3Int> BlockingCoordinates { get; init; }

		[Serialize]
		public ImmutableArray<Vector3Int> AllowedCoordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectAccessesSpec");
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
			builder.Append("BlockingCoordinates = ");
			builder.Append(BlockingCoordinates.ToString());
			builder.Append(", AllowedCoordinates = ");
			builder.Append(AllowedCoordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<Vector3Int>>.Default.GetHashCode(BlockingCoordinates)) * -1521134295 + EqualityComparer<ImmutableArray<Vector3Int>>.Default.GetHashCode(AllowedCoordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectAccessesSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<Vector3Int>>.Default.Equals(BlockingCoordinates, other!.BlockingCoordinates))
				{
					return EqualityComparer<ImmutableArray<Vector3Int>>.Default.Equals(AllowedCoordinates, other!.AllowedCoordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectAccessesSpec(BlockObjectAccessesSpec original)
			: base(original)
		{
			BlockingCoordinates = original.BlockingCoordinates;
			AllowedCoordinates = original.AllowedCoordinates;
		}

		public BlockObjectAccessesSpec()
		{
		}
	}
}
