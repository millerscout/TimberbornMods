using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Autosaving
{
	internal record AutosaverSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AutosaverSpec);
			}
		}

		[Serialize]
		public int AutosavesPerSettlement { get; init; }

		[Serialize]
		public float FrequencyInMinutes { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AutosaverSpec");
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
			builder.Append("AutosavesPerSettlement = ");
			builder.Append(AutosavesPerSettlement.ToString());
			builder.Append(", FrequencyInMinutes = ");
			builder.Append(FrequencyInMinutes.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(AutosavesPerSettlement)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FrequencyInMinutes);
		}

		[CompilerGenerated]
		public virtual bool Equals(AutosaverSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(AutosavesPerSettlement, other!.AutosavesPerSettlement))
				{
					return EqualityComparer<float>.Default.Equals(FrequencyInMinutes, other!.FrequencyInMinutes);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AutosaverSpec(AutosaverSpec original)
			: base(original)
		{
			AutosavesPerSettlement = original.AutosavesPerSettlement;
			FrequencyInMinutes = original.FrequencyInMinutes;
		}

		public AutosaverSpec()
		{
		}
	}
}
