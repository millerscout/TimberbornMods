using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Demolishing
{
	internal record DemolishableSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DemolishableSpec);
			}
		}

		[Serialize]
		public float DemolishTimeInHours { get; init; }

		[Serialize]
		public bool ShowDemolishButtonInEntityPanel { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DemolishableSpec");
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
			builder.Append("DemolishTimeInHours = ");
			builder.Append(DemolishTimeInHours.ToString());
			builder.Append(", ShowDemolishButtonInEntityPanel = ");
			builder.Append(ShowDemolishButtonInEntityPanel.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DemolishTimeInHours)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ShowDemolishButtonInEntityPanel);
		}

		[CompilerGenerated]
		public virtual bool Equals(DemolishableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(DemolishTimeInHours, other!.DemolishTimeInHours))
				{
					return EqualityComparer<bool>.Default.Equals(ShowDemolishButtonInEntityPanel, other!.ShowDemolishButtonInEntityPanel);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DemolishableSpec(DemolishableSpec original)
			: base(original)
		{
			DemolishTimeInHours = original.DemolishTimeInHours;
			ShowDemolishButtonInEntityPanel = original.ShowDemolishButtonInEntityPanel;
		}

		public DemolishableSpec()
		{
		}
	}
}
