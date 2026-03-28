using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SoilMoistureSystem
{
	internal record DryObjectModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DryObjectModelSpec);
			}
		}

		[Serialize]
		public string WetModelName { get; init; }

		[Serialize]
		public string DryModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DryObjectModelSpec");
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
			builder.Append("WetModelName = ");
			builder.Append((object)WetModelName);
			builder.Append(", DryModelName = ");
			builder.Append((object)DryModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WetModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DryModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(DryObjectModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(WetModelName, other!.WetModelName))
				{
					return EqualityComparer<string>.Default.Equals(DryModelName, other!.DryModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DryObjectModelSpec(DryObjectModelSpec original)
			: base(original)
		{
			WetModelName = original.WetModelName;
			DryModelName = original.DryModelName;
		}

		public DryObjectModelSpec()
		{
		}
	}
}
