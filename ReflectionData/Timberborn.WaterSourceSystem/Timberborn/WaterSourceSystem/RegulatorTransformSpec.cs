using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WaterSourceSystem
{
	internal record RegulatorTransformSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RegulatorTransformSpec);
			}
		}

		[Serialize]
		public string TransformName { get; init; }

		[Serialize]
		public Vector3 TargetOffset { get; init; }

		[Serialize]
		public Vector3 TargetRotation { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RegulatorTransformSpec");
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
			builder.Append("TransformName = ");
			builder.Append((object)TransformName);
			builder.Append(", TargetOffset = ");
			builder.Append(TargetOffset.ToString());
			builder.Append(", TargetRotation = ");
			builder.Append(TargetRotation.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TransformName)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(TargetOffset)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(TargetRotation);
		}

		[CompilerGenerated]
		public virtual bool Equals(RegulatorTransformSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(TransformName, other!.TransformName) && EqualityComparer<Vector3>.Default.Equals(TargetOffset, other!.TargetOffset))
				{
					return EqualityComparer<Vector3>.Default.Equals(TargetRotation, other!.TargetRotation);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RegulatorTransformSpec(RegulatorTransformSpec original)
			: base(original)
		{
			TransformName = original.TransformName;
			TargetOffset = original.TargetOffset;
			TargetRotation = original.TargetRotation;
		}

		public RegulatorTransformSpec()
		{
		}
	}
}
