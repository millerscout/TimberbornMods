using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.UnityEngineSpecs
{
	public record BoxColliderSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BoxColliderSpec);
			}
		}

		[Serialize]
		public Vector3 Center { get; init; }

		[Serialize]
		public Vector3 Size { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BoxColliderSpec");
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
			builder.Append("Center = ");
			builder.Append(Center.ToString());
			builder.Append(", Size = ");
			builder.Append(Size.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Center)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Size);
		}

		[CompilerGenerated]
		public virtual bool Equals(BoxColliderSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Vector3>.Default.Equals(Center, other!.Center))
				{
					return EqualityComparer<Vector3>.Default.Equals(Size, other!.Size);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BoxColliderSpec(BoxColliderSpec original)
		{
			Center = original.Center;
			Size = original.Size;
		}

		public BoxColliderSpec()
		{
		}
	}
}
