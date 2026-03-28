using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockSystemNavigation
{
	internal record BlockObjectNavMeshBlockedEdgeSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectNavMeshBlockedEdgeSpec);
			}
		}

		[Serialize]
		public string Group { get; init; }

		[Serialize]
		public Vector3Int Start { get; init; }

		[Serialize]
		public Vector3Int End { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectNavMeshBlockedEdgeSpec");
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
			builder.Append(", Start = ");
			builder.Append(Start.ToString());
			builder.Append(", End = ");
			builder.Append(End.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Group)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Start)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(End);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectNavMeshBlockedEdgeSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Group, other!.Group) && EqualityComparer<Vector3Int>.Default.Equals(Start, other!.Start))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(End, other!.End);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectNavMeshBlockedEdgeSpec(BlockObjectNavMeshBlockedEdgeSpec original)
		{
			Group = original.Group;
			Start = original.Start;
			End = original.End;
		}

		public BlockObjectNavMeshBlockedEdgeSpec()
		{
		}
	}
}
