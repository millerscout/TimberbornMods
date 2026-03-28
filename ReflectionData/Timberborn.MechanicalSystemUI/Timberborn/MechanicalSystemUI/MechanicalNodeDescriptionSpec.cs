using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MechanicalSystemUI
{
	internal record MechanicalNodeDescriptionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MechanicalNodeDescriptionSpec);
			}
		}

		[Serialize]
		public string AlternativePowerUnitLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MechanicalNodeDescriptionSpec");
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
			builder.Append("AlternativePowerUnitLocKey = ");
			builder.Append((object)AlternativePowerUnitLocKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AlternativePowerUnitLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(MechanicalNodeDescriptionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(AlternativePowerUnitLocKey, other!.AlternativePowerUnitLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MechanicalNodeDescriptionSpec(MechanicalNodeDescriptionSpec original)
			: base(original)
		{
			AlternativePowerUnitLocKey = original.AlternativePowerUnitLocKey;
		}

		public MechanicalNodeDescriptionSpec()
		{
		}
	}
}
