using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ActivatorSystem
{
	public record TimedComponentActivatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TimedComponentActivatorSpec);
			}
		}

		[Serialize]
		public bool IsOptionallyActivable { get; init; }

		[Serialize]
		public int CyclesUntilCountdownActivation { get; init; }

		[Serialize]
		public float DaysUntilActivation { get; init; }

		[Serialize]
		public string ProgressBarActiveLabelLocKey { get; init; }

		[Serialize]
		public string ProgressBarNotActiveLabelLocKey { get; init; }

		[Serialize]
		public bool IsHazardousActivator { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TimedComponentActivatorSpec");
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
			builder.Append("IsOptionallyActivable = ");
			builder.Append(IsOptionallyActivable.ToString());
			builder.Append(", CyclesUntilCountdownActivation = ");
			builder.Append(CyclesUntilCountdownActivation.ToString());
			builder.Append(", DaysUntilActivation = ");
			builder.Append(DaysUntilActivation.ToString());
			builder.Append(", ProgressBarActiveLabelLocKey = ");
			builder.Append((object)ProgressBarActiveLabelLocKey);
			builder.Append(", ProgressBarNotActiveLabelLocKey = ");
			builder.Append((object)ProgressBarNotActiveLabelLocKey);
			builder.Append(", IsHazardousActivator = ");
			builder.Append(IsHazardousActivator.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsOptionallyActivable)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CyclesUntilCountdownActivation)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DaysUntilActivation)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProgressBarActiveLabelLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProgressBarNotActiveLabelLocKey)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsHazardousActivator);
		}

		[CompilerGenerated]
		public virtual bool Equals(TimedComponentActivatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(IsOptionallyActivable, other!.IsOptionallyActivable) && EqualityComparer<int>.Default.Equals(CyclesUntilCountdownActivation, other!.CyclesUntilCountdownActivation) && EqualityComparer<float>.Default.Equals(DaysUntilActivation, other!.DaysUntilActivation) && EqualityComparer<string>.Default.Equals(ProgressBarActiveLabelLocKey, other!.ProgressBarActiveLabelLocKey) && EqualityComparer<string>.Default.Equals(ProgressBarNotActiveLabelLocKey, other!.ProgressBarNotActiveLabelLocKey))
				{
					return EqualityComparer<bool>.Default.Equals(IsHazardousActivator, other!.IsHazardousActivator);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TimedComponentActivatorSpec(TimedComponentActivatorSpec original)
			: base(original)
		{
			IsOptionallyActivable = original.IsOptionallyActivable;
			CyclesUntilCountdownActivation = original.CyclesUntilCountdownActivation;
			DaysUntilActivation = original.DaysUntilActivation;
			ProgressBarActiveLabelLocKey = original.ProgressBarActiveLabelLocKey;
			ProgressBarNotActiveLabelLocKey = original.ProgressBarNotActiveLabelLocKey;
			IsHazardousActivator = original.IsHazardousActivator;
		}

		public TimedComponentActivatorSpec()
		{
		}
	}
}
