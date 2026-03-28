using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WindSystem
{
	internal record WindRotatorSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WindRotatorSpec);
			}
		}

		[Serialize]
		public string TransformName { get; init; }

		[Serialize]
		public Vector3 RotationAxis { get; init; }

		[Serialize]
		public float RotationSpeed { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WindRotatorSpec");
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
			builder.Append("TransformName = ");
			builder.Append((object)TransformName);
			builder.Append(", RotationAxis = ");
			builder.Append(RotationAxis.ToString());
			builder.Append(", RotationSpeed = ");
			builder.Append(RotationSpeed.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TransformName)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(RotationAxis)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RotationSpeed);
		}

		[CompilerGenerated]
		public virtual bool Equals(WindRotatorSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(TransformName, other!.TransformName) && EqualityComparer<Vector3>.Default.Equals(RotationAxis, other!.RotationAxis))
				{
					return EqualityComparer<float>.Default.Equals(RotationSpeed, other!.RotationSpeed);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WindRotatorSpec(WindRotatorSpec original)
		{
			TransformName = original.TransformName;
			RotationAxis = original.RotationAxis;
			RotationSpeed = original.RotationSpeed;
		}

		public WindRotatorSpec()
		{
		}
	}
}
