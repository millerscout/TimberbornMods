using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.BlueprintSystem
{
	public record BlueprintModifierSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlueprintModifierSpec);
			}
		}

		[Serialize]
		public AssetRef<BlueprintAsset> Original { get; init; }

		[Serialize]
		public AssetRef<BlueprintAsset> Modifier { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlueprintModifierSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Original = ");
			builder.Append(Original);
			builder.Append(", Modifier = ");
			builder.Append(Modifier);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<AssetRef<BlueprintAsset>>.Default.GetHashCode(Original)) * -1521134295 + EqualityComparer<AssetRef<BlueprintAsset>>.Default.GetHashCode(Modifier);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlueprintModifierSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<AssetRef<BlueprintAsset>>.Default.Equals(Original, other!.Original))
				{
					return EqualityComparer<AssetRef<BlueprintAsset>>.Default.Equals(Modifier, other!.Modifier);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlueprintModifierSpec(BlueprintModifierSpec original)
		{
			Original = original.Original;
			Modifier = original.Modifier;
		}

		public BlueprintModifierSpec()
		{
		}
	}
}
