using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MechanicalSystem
{
	internal record MechanicalNodeTransformHeightSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MechanicalNodeTransformHeightSpec);
			}
		}

		[Serialize]
		public string TransformName { get; init; }

		[Serialize]
		public float Range { get; init; }

		[Serialize]
		public float ChangeSpeed { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MechanicalNodeTransformHeightSpec");
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
			builder.Append(", Range = ");
			builder.Append(Range.ToString());
			builder.Append(", ChangeSpeed = ");
			builder.Append(ChangeSpeed.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TransformName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Range)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ChangeSpeed);
		}

		[CompilerGenerated]
		public virtual bool Equals(MechanicalNodeTransformHeightSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(TransformName, other!.TransformName) && EqualityComparer<float>.Default.Equals(Range, other!.Range))
				{
					return EqualityComparer<float>.Default.Equals(ChangeSpeed, other!.ChangeSpeed);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MechanicalNodeTransformHeightSpec(MechanicalNodeTransformHeightSpec original)
			: base(original)
		{
			TransformName = original.TransformName;
			Range = original.Range;
			ChangeSpeed = original.ChangeSpeed;
		}

		public MechanicalNodeTransformHeightSpec()
		{
		}
	}
}
