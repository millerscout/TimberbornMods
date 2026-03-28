using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.WorkSystem
{
	public record NeedPreventingWorkSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedPreventingWorkSpec);
			}
		}

		[Serialize("WorkRefusalWarningLocKey")]
		public LocalizedText WorkRefusalWarning { get; init; }

		[Serialize]
		private string WorkRefusalWarningLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedPreventingWorkSpec");
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
			builder.Append("WorkRefusalWarning = ");
			builder.Append(WorkRefusalWarning);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(WorkRefusalWarning)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WorkRefusalWarningLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedPreventingWorkSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<LocalizedText>.Default.Equals(WorkRefusalWarning, other!.WorkRefusalWarning))
				{
					return EqualityComparer<string>.Default.Equals(WorkRefusalWarningLocKey, other!.WorkRefusalWarningLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedPreventingWorkSpec(NeedPreventingWorkSpec original)
			: base(original)
		{
			WorkRefusalWarning = original.WorkRefusalWarning;
			WorkRefusalWarningLocKey = original.WorkRefusalWarningLocKey;
		}

		public NeedPreventingWorkSpec()
		{
		}
	}
}
