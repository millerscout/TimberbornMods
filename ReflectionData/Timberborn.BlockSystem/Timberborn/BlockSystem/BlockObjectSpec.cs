using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Coordinates;
using UnityEngine;

namespace Timberborn.BlockSystem
{
	public record BlockObjectSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectSpec);
			}
		}

		[Serialize]
		public Vector3Int Size { get; init; }

		[Serialize]
		public ImmutableArray<BlockSpec> Blocks { get; init; }

		[Serialize]
		public EntranceBlockSpec Entrance { get; init; }

		[Serialize]
		public int BaseZ { get; init; }

		[Serialize]
		public bool Overridable { get; init; }

		[Serialize]
		public bool Flippable { get; init; }

		public Blocks GetBlocks()
		{
			return Timberborn.BlockSystem.Blocks.From(this);
		}

		public IEnumerable<Block> GetBlocks(Placement placement)
		{
			int x = 0;
			while (x < Size.x)
			{
				int num;
				for (int y = 0; y < Size.y; y = num)
				{
					for (int z = 0; z < Size.z; z = num)
					{
						Vector3Int coordinates = new Vector3Int(x, y, z);
						BlockSpec blockSpec = BlockSpecFromCoordinates(coordinates);
						Vector3Int coordinates2 = placement.Orientation.Transform(placement.FlipMode.Transform(coordinates, Size.x)) + placement.Coordinates;
						yield return Block.From(coordinates2, blockSpec);
						num = z + 1;
					}
					num = y + 1;
				}
				num = x + 1;
				x = num;
			}
		}

		public BlockSpec BlockSpecFromCoordinates(Vector3Int coordinates)
		{
			int index = (coordinates.z * Size.y + coordinates.y) * Size.x + coordinates.x;
			return Blocks[index];
		}

		public Vector3 CalculateCenterOffset(Orientation orientation)
		{
			return orientation.Transform(new Vector3(Size.x, Size.y, Size.z) / 2f);
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectSpec");
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
			builder.Append("Size = ");
			builder.Append(Size.ToString());
			builder.Append(", Blocks = ");
			builder.Append(Blocks.ToString());
			builder.Append(", Entrance = ");
			builder.Append(Entrance);
			builder.Append(", BaseZ = ");
			builder.Append(BaseZ.ToString());
			builder.Append(", Overridable = ");
			builder.Append(Overridable.ToString());
			builder.Append(", Flippable = ");
			builder.Append(Flippable.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Size)) * -1521134295 + EqualityComparer<ImmutableArray<BlockSpec>>.Default.GetHashCode(Blocks)) * -1521134295 + EqualityComparer<EntranceBlockSpec>.Default.GetHashCode(Entrance)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BaseZ)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Overridable)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Flippable);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3Int>.Default.Equals(Size, other!.Size) && EqualityComparer<ImmutableArray<BlockSpec>>.Default.Equals(Blocks, other!.Blocks) && EqualityComparer<EntranceBlockSpec>.Default.Equals(Entrance, other!.Entrance) && EqualityComparer<int>.Default.Equals(BaseZ, other!.BaseZ) && EqualityComparer<bool>.Default.Equals(Overridable, other!.Overridable))
				{
					return EqualityComparer<bool>.Default.Equals(Flippable, other!.Flippable);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectSpec(BlockObjectSpec original)
			: base(original)
		{
			Size = original.Size;
			Blocks = original.Blocks;
			Entrance = original.Entrance;
			BaseZ = original.BaseZ;
			Overridable = original.Overridable;
			Flippable = original.Flippable;
		}

		public BlockObjectSpec()
		{
		}
	}
}
