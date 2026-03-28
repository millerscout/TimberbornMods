using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MechanicalSystem
{
	public record MechanicalNodeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MechanicalNodeSpec);
			}
		}

		[Serialize]
		public int PowerOutput { get; init; }

		[Serialize]
		public int PowerInput { get; init; }

		[Serialize]
		public bool IsShaft { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MechanicalNodeSpec");
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
			builder.Append("PowerOutput = ");
			builder.Append(PowerOutput.ToString());
			builder.Append(", PowerInput = ");
			builder.Append(PowerInput.ToString());
			builder.Append(", IsShaft = ");
			builder.Append(IsShaft.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(PowerOutput)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(PowerInput)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsShaft);
		}

		[CompilerGenerated]
		public virtual bool Equals(MechanicalNodeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(PowerOutput, other!.PowerOutput) && EqualityComparer<int>.Default.Equals(PowerInput, other!.PowerInput))
				{
					return EqualityComparer<bool>.Default.Equals(IsShaft, other!.IsShaft);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MechanicalNodeSpec(MechanicalNodeSpec original)
			: base(original)
		{
			PowerOutput = original.PowerOutput;
			PowerInput = original.PowerInput;
			IsShaft = original.IsShaft;
		}

		public MechanicalNodeSpec()
		{
		}
	}
}
