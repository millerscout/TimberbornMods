using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockSystem
{
	public record CustomPivotSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CustomPivotSpec);
			}
		}

		[Serialize]
		public bool HasCustomPivot { get; init; }

		[Serialize]
		public Vector3 Coordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CustomPivotSpec");
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
			builder.Append("HasCustomPivot = ");
			builder.Append(HasCustomPivot.ToString());
			builder.Append(", Coordinates = ");
			builder.Append(Coordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(HasCustomPivot)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Coordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(CustomPivotSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<bool>.Default.Equals(HasCustomPivot, other!.HasCustomPivot))
				{
					return EqualityComparer<Vector3>.Default.Equals(Coordinates, other!.Coordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CustomPivotSpec(CustomPivotSpec original)
		{
			HasCustomPivot = original.HasCustomPivot;
			Coordinates = original.Coordinates;
		}

		public CustomPivotSpec()
		{
		}
	}
}
