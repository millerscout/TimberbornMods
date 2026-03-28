using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;
using UnityEngine;

namespace Timberborn.GameWonderCompletion
{
	public record FactionWonderSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FactionWonderSpec);
			}
		}

		[Serialize("WonderCompletionFlavorLocKey")]
		public LocalizedText WonderCompletionFlavor { get; init; }

		[Serialize("WonderCompletionMessageLocKey")]
		public LocalizedText WonderCompletionMessage { get; init; }

		[Serialize]
		public AssetRef<Sprite> WonderCompletionImage { get; init; }

		[Serialize]
		public string WonderLaunchSound { get; init; }

		[Serialize]
		private string WonderCompletionFlavorLocKey { get; init; }

		[Serialize]
		private string WonderCompletionMessageLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FactionWonderSpec");
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
			builder.Append("WonderCompletionFlavor = ");
			builder.Append(WonderCompletionFlavor);
			builder.Append(", WonderCompletionMessage = ");
			builder.Append(WonderCompletionMessage);
			builder.Append(", WonderCompletionImage = ");
			builder.Append(WonderCompletionImage);
			builder.Append(", WonderLaunchSound = ");
			builder.Append((object)WonderLaunchSound);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(WonderCompletionFlavor)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(WonderCompletionMessage)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(WonderCompletionImage)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WonderLaunchSound)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WonderCompletionFlavorLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WonderCompletionMessageLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(FactionWonderSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<LocalizedText>.Default.Equals(WonderCompletionFlavor, other!.WonderCompletionFlavor) && EqualityComparer<LocalizedText>.Default.Equals(WonderCompletionMessage, other!.WonderCompletionMessage) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(WonderCompletionImage, other!.WonderCompletionImage) && EqualityComparer<string>.Default.Equals(WonderLaunchSound, other!.WonderLaunchSound) && EqualityComparer<string>.Default.Equals(WonderCompletionFlavorLocKey, other!.WonderCompletionFlavorLocKey))
				{
					return EqualityComparer<string>.Default.Equals(WonderCompletionMessageLocKey, other!.WonderCompletionMessageLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FactionWonderSpec(FactionWonderSpec original)
			: base(original)
		{
			WonderCompletionFlavor = original.WonderCompletionFlavor;
			WonderCompletionMessage = original.WonderCompletionMessage;
			WonderCompletionImage = original.WonderCompletionImage;
			WonderLaunchSound = original.WonderLaunchSound;
			WonderCompletionFlavorLocKey = original.WonderCompletionFlavorLocKey;
			WonderCompletionMessageLocKey = original.WonderCompletionMessageLocKey;
		}

		public FactionWonderSpec()
		{
		}
	}
}
