using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ActivatorSystem
{
	internal record ActivationWarningStatusSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ActivationWarningStatusSpec);
			}
		}

		[Serialize]
		public string StatusSpriteName { get; init; }

		[Serialize]
		public string StatusLocKey { get; init; }

		[Serialize]
		public bool UseInfiniteWarning { get; init; }

		[Serialize]
		public string WarningSound { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ActivationWarningStatusSpec");
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
			builder.Append("StatusSpriteName = ");
			builder.Append((object)StatusSpriteName);
			builder.Append(", StatusLocKey = ");
			builder.Append((object)StatusLocKey);
			builder.Append(", UseInfiniteWarning = ");
			builder.Append(UseInfiniteWarning.ToString());
			builder.Append(", WarningSound = ");
			builder.Append((object)WarningSound);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StatusSpriteName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StatusLocKey)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(UseInfiniteWarning)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WarningSound);
		}

		[CompilerGenerated]
		public virtual bool Equals(ActivationWarningStatusSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(StatusSpriteName, other!.StatusSpriteName) && EqualityComparer<string>.Default.Equals(StatusLocKey, other!.StatusLocKey) && EqualityComparer<bool>.Default.Equals(UseInfiniteWarning, other!.UseInfiniteWarning))
				{
					return EqualityComparer<string>.Default.Equals(WarningSound, other!.WarningSound);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ActivationWarningStatusSpec(ActivationWarningStatusSpec original)
			: base(original)
		{
			StatusSpriteName = original.StatusSpriteName;
			StatusLocKey = original.StatusLocKey;
			UseInfiniteWarning = original.UseInfiniteWarning;
			WarningSound = original.WarningSound;
		}

		public ActivationWarningStatusSpec()
		{
		}
	}
}
