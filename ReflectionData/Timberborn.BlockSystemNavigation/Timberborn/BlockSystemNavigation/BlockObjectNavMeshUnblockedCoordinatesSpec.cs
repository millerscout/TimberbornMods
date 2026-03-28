using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockSystemNavigation
{
	internal record BlockObjectNavMeshUnblockedCoordinatesSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectNavMeshUnblockedCoordinatesSpec);
			}
		}

		[Serialize]
		public string Group { get; init; }

		[Serialize]
		public Vector3Int Coordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectNavMeshUnblockedCoordinatesSpec");
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
			builder.Append("Group = ");
			builder.Append((object)Group);
			builder.Append(", Coordinates = ");
			builder.Append(Coordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Group)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Coordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectNavMeshUnblockedCoordinatesSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Group, other!.Group))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(Coordinates, other!.Coordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectNavMeshUnblockedCoordinatesSpec(BlockObjectNavMeshUnblockedCoordinatesSpec original)
		{
			Group = original.Group;
			Coordinates = original.Coordinates;
		}

		public BlockObjectNavMeshUnblockedCoordinatesSpec()
		{
		}
	}
}
