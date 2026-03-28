using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Workshops
{
	internal record ProductionResetterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ProductionResetterSpec);
			}
		}

		[Serialize]
		public float HoursToResetProgress { get; init; }

		[Serialize]
		public string StatusLocKey { get; init; }

		[Serialize]
		public string AlertLocKey { get; init; }

		[Serialize]
		public string StatusIcon { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ProductionResetterSpec");
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
			builder.Append("HoursToResetProgress = ");
			builder.Append(HoursToResetProgress.ToString());
			builder.Append(", StatusLocKey = ");
			builder.Append((object)StatusLocKey);
			builder.Append(", AlertLocKey = ");
			builder.Append((object)AlertLocKey);
			builder.Append(", StatusIcon = ");
			builder.Append((object)StatusIcon);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(HoursToResetProgress)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StatusLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AlertLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StatusIcon);
		}

		[CompilerGenerated]
		public virtual bool Equals(ProductionResetterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(HoursToResetProgress, other!.HoursToResetProgress) && EqualityComparer<string>.Default.Equals(StatusLocKey, other!.StatusLocKey) && EqualityComparer<string>.Default.Equals(AlertLocKey, other!.AlertLocKey))
				{
					return EqualityComparer<string>.Default.Equals(StatusIcon, other!.StatusIcon);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ProductionResetterSpec(ProductionResetterSpec original)
			: base(original)
		{
			HoursToResetProgress = original.HoursToResetProgress;
			StatusLocKey = original.StatusLocKey;
			AlertLocKey = original.AlertLocKey;
			StatusIcon = original.StatusIcon;
		}

		public ProductionResetterSpec()
		{
		}
	}
}
