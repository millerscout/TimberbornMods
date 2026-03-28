using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WaterSourceSystem
{
	internal record WaterSourceContaminationSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WaterSourceContaminationSpec);
			}
		}

		[Serialize]
		public float DefaultContamination { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WaterSourceContaminationSpec");
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
			builder.Append("DefaultContamination = ");
			builder.Append(DefaultContamination.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DefaultContamination);
		}

		[CompilerGenerated]
		public virtual bool Equals(WaterSourceContaminationSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(DefaultContamination, other!.DefaultContamination);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WaterSourceContaminationSpec(WaterSourceContaminationSpec original)
			: base(original)
		{
			DefaultContamination = original.DefaultContamination;
		}

		public WaterSourceContaminationSpec()
		{
		}
	}
}
