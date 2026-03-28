using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterSourceSystem
{
	internal record WaterSourceRegulatorAnimationControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterSourceRegulatorAnimationControllerSpec);
			}
		}

		[Serialize]
		public ImmutableArray<RegulatorTransformSpec> RegulatorTransforms { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterSourceRegulatorAnimationControllerSpec");
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
			builder.Append("RegulatorTransforms = ");
			builder.Append(RegulatorTransforms.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<RegulatorTransformSpec>>.Default.GetHashCode(RegulatorTransforms);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterSourceRegulatorAnimationControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<RegulatorTransformSpec>>.Default.Equals(RegulatorTransforms, other!.RegulatorTransforms);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterSourceRegulatorAnimationControllerSpec(WaterSourceRegulatorAnimationControllerSpec original)
			: base(original)
		{
			RegulatorTransforms = original.RegulatorTransforms;
		}

		public WaterSourceRegulatorAnimationControllerSpec()
		{
		}
	}
}
