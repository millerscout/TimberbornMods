using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.UnityEngineSpecs
{
	public record SphereColliderSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SphereColliderSpec);
			}
		}

		[Serialize]
		public Vector3 Center { get; init; }

		[Serialize]
		public float Radius { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SphereColliderSpec");
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
			builder.Append(", Radius = ");
			builder.Append(Radius.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Center)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Radius);
		}

		[CompilerGenerated]
		public virtual bool Equals(SphereColliderSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Vector3>.Default.Equals(Center, other!.Center))
				{
					return EqualityComparer<float>.Default.Equals(Radius, other!.Radius);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SphereColliderSpec(SphereColliderSpec original)
		{
			Center = original.Center;
			Radius = original.Radius;
		}

		public SphereColliderSpec()
		{
		}
	}
}
