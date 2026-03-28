using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.AutomationBuildings
{
	internal record GateModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GateModelSpec);
			}
		}

		[Serialize]
		public string OpenModelName { get; init; }

		[Serialize]
		public string ClosedModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GateModelSpec");
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
			builder.Append("OpenModelName = ");
			builder.Append((object)OpenModelName);
			builder.Append(", ClosedModelName = ");
			builder.Append((object)ClosedModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OpenModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClosedModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(GateModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(OpenModelName, other!.OpenModelName))
				{
					return EqualityComparer<string>.Default.Equals(ClosedModelName, other!.ClosedModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GateModelSpec(GateModelSpec original)
			: base(original)
		{
			OpenModelName = original.OpenModelName;
			ClosedModelName = original.ClosedModelName;
		}

		public GateModelSpec()
		{
		}
	}
}
