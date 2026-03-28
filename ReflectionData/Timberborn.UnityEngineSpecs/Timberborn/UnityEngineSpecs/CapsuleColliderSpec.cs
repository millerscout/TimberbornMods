using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Coordinates;
using UnityEngine;

namespace Timberborn.UnityEngineSpecs
{
	public record CapsuleColliderSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CapsuleColliderSpec);
			}
		}

		[Serialize]
		public Vector3 Center { get; init; }

		[Serialize]
		public float Radius { get; init; }

		[Serialize]
		public float Height { get; init; }

		[Serialize]
		public Axis Axis { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CapsuleColliderSpec");
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
			builder.Append(", Height = ");
			builder.Append(Height.ToString());
			builder.Append(", Axis = ");
			builder.Append(Axis.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Center)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Radius)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Height)) * -1521134295 + EqualityComparer<Axis>.Default.GetHashCode(Axis);
		}

		[CompilerGenerated]
		public virtual bool Equals(CapsuleColliderSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<Vector3>.Default.Equals(Center, other!.Center) && EqualityComparer<float>.Default.Equals(Radius, other!.Radius) && EqualityComparer<float>.Default.Equals(Height, other!.Height))
				{
					return EqualityComparer<Axis>.Default.Equals(Axis, other!.Axis);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CapsuleColliderSpec(CapsuleColliderSpec original)
		{
			Center = original.Center;
			Radius = original.Radius;
			Height = original.Height;
			Axis = original.Axis;
		}

		public CapsuleColliderSpec()
		{
			Axis = Axis.Y;
			base._002Ector();
		}
	}
}
