using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockSystemNavigation
{
	internal record BlockObjectNavMeshSettingsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectNavMeshSettingsSpec);
			}
		}

		[Serialize]
		public bool NoAutoWalls { get; init; }

		[Serialize]
		public bool GenerateFloorsOnStackable { get; init; }

		[Serialize]
		public ImmutableArray<BlockObjectNavMeshEdgeGroupSpec> EdgeGroups { get; init; }

		[Serialize]
		public ImmutableArray<BlockObjectNavMeshUnblockedCoordinatesSpec> UnblockedCoordinates { get; init; }

		[Serialize]
		public ImmutableArray<BlockObjectNavMeshBlockedEdgeSpec> BlockedEdges { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectNavMeshSettingsSpec");
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
			builder.Append("NoAutoWalls = ");
			builder.Append(NoAutoWalls.ToString());
			builder.Append(", GenerateFloorsOnStackable = ");
			builder.Append(GenerateFloorsOnStackable.ToString());
			builder.Append(", EdgeGroups = ");
			builder.Append(EdgeGroups.ToString());
			builder.Append(", UnblockedCoordinates = ");
			builder.Append(UnblockedCoordinates.ToString());
			builder.Append(", BlockedEdges = ");
			builder.Append(BlockedEdges.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(NoAutoWalls)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(GenerateFloorsOnStackable)) * -1521134295 + EqualityComparer<ImmutableArray<BlockObjectNavMeshEdgeGroupSpec>>.Default.GetHashCode(EdgeGroups)) * -1521134295 + EqualityComparer<ImmutableArray<BlockObjectNavMeshUnblockedCoordinatesSpec>>.Default.GetHashCode(UnblockedCoordinates)) * -1521134295 + EqualityComparer<ImmutableArray<BlockObjectNavMeshBlockedEdgeSpec>>.Default.GetHashCode(BlockedEdges);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectNavMeshSettingsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(NoAutoWalls, other!.NoAutoWalls) && EqualityComparer<bool>.Default.Equals(GenerateFloorsOnStackable, other!.GenerateFloorsOnStackable) && EqualityComparer<ImmutableArray<BlockObjectNavMeshEdgeGroupSpec>>.Default.Equals(EdgeGroups, other!.EdgeGroups) && EqualityComparer<ImmutableArray<BlockObjectNavMeshUnblockedCoordinatesSpec>>.Default.Equals(UnblockedCoordinates, other!.UnblockedCoordinates))
				{
					return EqualityComparer<ImmutableArray<BlockObjectNavMeshBlockedEdgeSpec>>.Default.Equals(BlockedEdges, other!.BlockedEdges);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectNavMeshSettingsSpec(BlockObjectNavMeshSettingsSpec original)
			: base(original)
		{
			NoAutoWalls = original.NoAutoWalls;
			GenerateFloorsOnStackable = original.GenerateFloorsOnStackable;
			EdgeGroups = original.EdgeGroups;
			UnblockedCoordinates = original.UnblockedCoordinates;
			BlockedEdges = original.BlockedEdges;
		}

		public BlockObjectNavMeshSettingsSpec()
		{
		}
	}
}
