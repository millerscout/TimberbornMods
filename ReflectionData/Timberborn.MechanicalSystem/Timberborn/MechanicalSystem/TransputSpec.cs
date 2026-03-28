using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Coordinates;
using UnityEngine;

namespace Timberborn.MechanicalSystem
{
	public record TransputSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TransputSpec);
			}
		}

		[Serialize]
		public Vector3Int Coordinates { get; init; }

		[Serialize]
		public Directions3D Directions { get; init; }

		[Serialize]
		public bool ReverseRotation { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TransputSpec");
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
			builder.Append("Coordinates = ");
			builder.Append(Coordinates.ToString());
			builder.Append(", Directions = ");
			builder.Append(Directions.ToString());
			builder.Append(", ReverseRotation = ");
			builder.Append(ReverseRotation.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Coordinates)) * -1521134295 + EqualityComparer<Directions3D>.Default.GetHashCode(Directions)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ReverseRotation);
		}

		[CompilerGenerated]
		public virtual bool Equals(TransputSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Vector3Int>.Default.Equals(Coordinates, other!.Coordinates) && EqualityComparer<Directions3D>.Default.Equals(Directions, other!.Directions))
				{
					return EqualityComparer<bool>.Default.Equals(ReverseRotation, other!.ReverseRotation);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TransputSpec(TransputSpec original)
		{
			Coordinates = original.Coordinates;
			Directions = original.Directions;
			ReverseRotation = original.ReverseRotation;
		}

		public TransputSpec()
		{
		}
	}
}
