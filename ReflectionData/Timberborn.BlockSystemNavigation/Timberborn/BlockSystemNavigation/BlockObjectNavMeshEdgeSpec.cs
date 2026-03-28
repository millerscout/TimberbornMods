using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockSystemNavigation
{
	internal record BlockObjectNavMeshEdgeSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectNavMeshEdgeSpec);
			}
		}

		[Serialize]
		public Vector3Int Start { get; init; }

		[Serialize]
		public Vector3Int End { get; init; }

		[Serialize]
		public bool IsTwoWay { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectNavMeshEdgeSpec");
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
			builder.Append("Start = ");
			builder.Append(Start.ToString());
			builder.Append(", End = ");
			builder.Append(End.ToString());
			builder.Append(", IsTwoWay = ");
			builder.Append(IsTwoWay.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Start)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(End)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsTwoWay);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectNavMeshEdgeSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Vector3Int>.Default.Equals(Start, other!.Start) && EqualityComparer<Vector3Int>.Default.Equals(End, other!.End))
				{
					return EqualityComparer<bool>.Default.Equals(IsTwoWay, other!.IsTwoWay);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectNavMeshEdgeSpec(BlockObjectNavMeshEdgeSpec original)
		{
			Start = original.Start;
			End = original.End;
			IsTwoWay = original.IsTwoWay;
		}

		public BlockObjectNavMeshEdgeSpec()
		{
		}
	}
}
