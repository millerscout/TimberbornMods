using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.NeedSpecs
{
	public record CriticalNeedSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CriticalNeedSpec);
			}
		}

		[Serialize]
		public CriticalNeedType CriticalNeedType { get; init; }

		[Serialize]
		public string SpriteName { get; init; }

		[Serialize("DescriptionLocKey")]
		public LocalizedText Description { get; init; }

		[Serialize("DescriptionShortLocKey")]
		public LocalizedText DescriptionShort { get; init; }

		[Serialize]
		private string DescriptionLocKey { get; init; }

		[Serialize]
		private string DescriptionShortLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CriticalNeedSpec");
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
			builder.Append("CriticalNeedType = ");
			builder.Append(CriticalNeedType.ToString());
			builder.Append(", SpriteName = ");
			builder.Append((object)SpriteName);
			builder.Append(", Description = ");
			builder.Append(Description);
			builder.Append(", DescriptionShort = ");
			builder.Append(DescriptionShort);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<CriticalNeedType>.Default.GetHashCode(CriticalNeedType)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SpriteName)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(Description)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DescriptionShort)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DescriptionLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DescriptionShortLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(CriticalNeedSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<CriticalNeedType>.Default.Equals(CriticalNeedType, other!.CriticalNeedType) && EqualityComparer<string>.Default.Equals(SpriteName, other!.SpriteName) && EqualityComparer<LocalizedText>.Default.Equals(Description, other!.Description) && EqualityComparer<LocalizedText>.Default.Equals(DescriptionShort, other!.DescriptionShort) && EqualityComparer<string>.Default.Equals(DescriptionLocKey, other!.DescriptionLocKey))
				{
					return EqualityComparer<string>.Default.Equals(DescriptionShortLocKey, other!.DescriptionShortLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CriticalNeedSpec(CriticalNeedSpec original)
			: base(original)
		{
			CriticalNeedType = original.CriticalNeedType;
			SpriteName = original.SpriteName;
			Description = original.Description;
			DescriptionShort = original.DescriptionShort;
			DescriptionLocKey = original.DescriptionLocKey;
			DescriptionShortLocKey = original.DescriptionShortLocKey;
		}

		public CriticalNeedSpec()
		{
		}
	}
}
