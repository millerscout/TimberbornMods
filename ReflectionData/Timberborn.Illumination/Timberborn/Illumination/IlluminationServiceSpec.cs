using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Illumination
{
	internal record IlluminationServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(IlluminationServiceSpec);
			}
		}

		[Serialize]
		public string DefaultColorId { get; init; }

		[Serialize]
		public float IconExponent { get; init; }

		[Serialize]
		public float IconMultiplier { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("IlluminationServiceSpec");
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
			builder.Append("DefaultColorId = ");
			builder.Append((object)DefaultColorId);
			builder.Append(", IconExponent = ");
			builder.Append(IconExponent.ToString());
			builder.Append(", IconMultiplier = ");
			builder.Append(IconMultiplier.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DefaultColorId)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(IconExponent)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(IconMultiplier);
		}

		[CompilerGenerated]
		public virtual bool Equals(IlluminationServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(DefaultColorId, other!.DefaultColorId) && EqualityComparer<float>.Default.Equals(IconExponent, other!.IconExponent))
				{
					return EqualityComparer<float>.Default.Equals(IconMultiplier, other!.IconMultiplier);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected IlluminationServiceSpec(IlluminationServiceSpec original)
			: base(original)
		{
			DefaultColorId = original.DefaultColorId;
			IconExponent = original.IconExponent;
			IconMultiplier = original.IconMultiplier;
		}

		public IlluminationServiceSpec()
		{
		}
	}
}
