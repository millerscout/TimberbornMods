using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.ZiplineSystem
{
	internal record ZiplineTowerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ZiplineTowerSpec);
			}
		}

		[Serialize]
		public Vector3 CableAnchorPoint { get; init; }

		[Serialize]
		public int MaxConnections { get; init; }

		[Serialize]
		public int MaxDistance { get; init; }

		[Serialize]
		public ImmutableArray<Vector3Int> UnobstructedCoordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ZiplineTowerSpec");
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
			builder.Append("CableAnchorPoint = ");
			builder.Append(CableAnchorPoint.ToString());
			builder.Append(", MaxConnections = ");
			builder.Append(MaxConnections.ToString());
			builder.Append(", MaxDistance = ");
			builder.Append(MaxDistance.ToString());
			builder.Append(", UnobstructedCoordinates = ");
			builder.Append(UnobstructedCoordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(CableAnchorPoint)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxConnections)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxDistance)) * -1521134295 + EqualityComparer<ImmutableArray<Vector3Int>>.Default.GetHashCode(UnobstructedCoordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(ZiplineTowerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3>.Default.Equals(CableAnchorPoint, other!.CableAnchorPoint) && EqualityComparer<int>.Default.Equals(MaxConnections, other!.MaxConnections) && EqualityComparer<int>.Default.Equals(MaxDistance, other!.MaxDistance))
				{
					return EqualityComparer<ImmutableArray<Vector3Int>>.Default.Equals(UnobstructedCoordinates, other!.UnobstructedCoordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ZiplineTowerSpec(ZiplineTowerSpec original)
			: base(original)
		{
			CableAnchorPoint = original.CableAnchorPoint;
			MaxConnections = original.MaxConnections;
			MaxDistance = original.MaxDistance;
			UnobstructedCoordinates = original.UnobstructedCoordinates;
		}

		public ZiplineTowerSpec()
		{
		}
	}
}
