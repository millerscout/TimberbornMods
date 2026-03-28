using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.MortalSystem
{
	public record LethalNeedSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(LethalNeedSpec);
			}
		}

		[Serialize("DeathWarningLocKey")]
		public LocalizedText DeathWarning { get; init; }

		[Serialize("DeathMessageLocKey")]
		public LocalizedText DeathMessage { get; init; }

		[Serialize]
		private string DeathWarningLocKey { get; init; }

		[Serialize]
		private string DeathMessageLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LethalNeedSpec");
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
			builder.Append("DeathWarning = ");
			builder.Append(DeathWarning);
			builder.Append(", DeathMessage = ");
			builder.Append(DeathMessage);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DeathWarning)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DeathMessage)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DeathWarningLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DeathMessageLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(LethalNeedSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<LocalizedText>.Default.Equals(DeathWarning, other!.DeathWarning) && EqualityComparer<LocalizedText>.Default.Equals(DeathMessage, other!.DeathMessage) && EqualityComparer<string>.Default.Equals(DeathWarningLocKey, other!.DeathWarningLocKey))
				{
					return EqualityComparer<string>.Default.Equals(DeathMessageLocKey, other!.DeathMessageLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected LethalNeedSpec(LethalNeedSpec original)
			: base(original)
		{
			DeathWarning = original.DeathWarning;
			DeathMessage = original.DeathMessage;
			DeathWarningLocKey = original.DeathWarningLocKey;
			DeathMessageLocKey = original.DeathMessageLocKey;
		}

		public LethalNeedSpec()
		{
		}
	}
}
