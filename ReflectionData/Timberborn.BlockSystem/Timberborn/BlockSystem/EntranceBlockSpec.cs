using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockSystem
{
	public record EntranceBlockSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EntranceBlockSpec);
			}
		}

		[Serialize]
		public bool HasEntrance { get; init; }

		[Serialize]
		public Vector3Int Coordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EntranceBlockSpec");
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
			builder.Append("HasEntrance = ");
			builder.Append(HasEntrance.ToString());
			builder.Append(", Coordinates = ");
			builder.Append(Coordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(HasEntrance)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Coordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(EntranceBlockSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<bool>.Default.Equals(HasEntrance, other!.HasEntrance))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(Coordinates, other!.Coordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected EntranceBlockSpec(EntranceBlockSpec original)
		{
			HasEntrance = original.HasEntrance;
			Coordinates = original.Coordinates;
		}

		public EntranceBlockSpec()
		{
		}
	}
}
