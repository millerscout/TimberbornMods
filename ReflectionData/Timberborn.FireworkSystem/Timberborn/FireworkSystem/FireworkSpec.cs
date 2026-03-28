using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;
using Timberborn.TemplateSystem;

namespace Timberborn.FireworkSystem
{
	public record FireworkSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FireworkSpec);
			}
		}

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		public bool HasBurst { get; init; }

		[Serialize]
		public string TrailSound { get; init; }

		[Serialize]
		public string BurstSound { get; init; }

		[Serialize]
		private string DisplayNameLocKey { get; init; }

		public string FireworkId => base.Blueprint.GetSpec<TemplateSpec>().TemplateName;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FireworkSpec");
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
			builder.Append("DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", HasBurst = ");
			builder.Append(HasBurst.ToString());
			builder.Append(", TrailSound = ");
			builder.Append((object)TrailSound);
			builder.Append(", BurstSound = ");
			builder.Append((object)BurstSound);
			builder.Append(", FireworkId = ");
			builder.Append((object)FireworkId);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(HasBurst)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TrailSound)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BurstSound)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(FireworkSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<bool>.Default.Equals(HasBurst, other!.HasBurst) && EqualityComparer<string>.Default.Equals(TrailSound, other!.TrailSound) && EqualityComparer<string>.Default.Equals(BurstSound, other!.BurstSound))
				{
					return EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FireworkSpec(FireworkSpec original)
			: base(original)
		{
			DisplayName = original.DisplayName;
			HasBurst = original.HasBurst;
			TrailSound = original.TrailSound;
			BurstSound = original.BurstSound;
			DisplayNameLocKey = original.DisplayNameLocKey;
		}

		public FireworkSpec()
		{
		}
	}
}
