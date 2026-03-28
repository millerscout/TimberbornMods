using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockSystemNavigation
{
	internal record BlockObjectNavMeshEdgeGroupSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectNavMeshEdgeGroupSpec);
			}
		}

		[Serialize]
		public float Cost { get; init; }

		[Serialize]
		public BlockObjectNavMeshGroup Group { get; init; }

		[Serialize]
		public bool IsPath { get; init; }

		[Serialize]
		public ImmutableArray<BlockObjectNavMeshEdgeSpec> AddedEdges { get; init; }

		public bool UseGroup => Group.UseGroup;

		public string GroupName => Group.GroupName;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectNavMeshEdgeGroupSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Cost = ");
			builder.Append(Cost.ToString());
			builder.Append(", Group = ");
			builder.Append(Group);
			builder.Append(", IsPath = ");
			builder.Append(IsPath.ToString());
			builder.Append(", AddedEdges = ");
			builder.Append(AddedEdges.ToString());
			builder.Append(", UseGroup = ");
			builder.Append(UseGroup.ToString());
			builder.Append(", GroupName = ");
			builder.Append((object)GroupName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Cost)) * -1521134295 + EqualityComparer<BlockObjectNavMeshGroup>.Default.GetHashCode(Group)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsPath)) * -1521134295 + EqualityComparer<ImmutableArray<BlockObjectNavMeshEdgeSpec>>.Default.GetHashCode(AddedEdges);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectNavMeshEdgeGroupSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<float>.Default.Equals(Cost, other!.Cost) && EqualityComparer<BlockObjectNavMeshGroup>.Default.Equals(Group, other!.Group) && EqualityComparer<bool>.Default.Equals(IsPath, other!.IsPath))
				{
					return EqualityComparer<ImmutableArray<BlockObjectNavMeshEdgeSpec>>.Default.Equals(AddedEdges, other!.AddedEdges);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectNavMeshEdgeGroupSpec(BlockObjectNavMeshEdgeGroupSpec original)
		{
			Cost = original.Cost;
			Group = original.Group;
			IsPath = original.IsPath;
			AddedEdges = original.AddedEdges;
		}

		public BlockObjectNavMeshEdgeGroupSpec()
		{
		}
	}
}
