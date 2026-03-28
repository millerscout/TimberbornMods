using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.PrefabOptimization
{
	internal record AutoAtlasSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AutoAtlasSpec);
			}
		}

		[Serialize]
		public string Name { get; init; }

		[Serialize]
		public bool IsUnique { get; init; }

		[Serialize]
		public ImmutableArray<AssetRef<Material>> Fragments { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AutoAtlasSpec");
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
			builder.Append("Name = ");
			builder.Append((object)Name);
			builder.Append(", IsUnique = ");
			builder.Append(IsUnique.ToString());
			builder.Append(", Fragments = ");
			builder.Append(Fragments.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsUnique)) * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<Material>>>.Default.GetHashCode(Fragments);
		}

		[CompilerGenerated]
		public virtual bool Equals(AutoAtlasSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Name, other!.Name) && EqualityComparer<bool>.Default.Equals(IsUnique, other!.IsUnique))
				{
					return EqualityComparer<ImmutableArray<AssetRef<Material>>>.Default.Equals(Fragments, other!.Fragments);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AutoAtlasSpec(AutoAtlasSpec original)
		{
			Name = original.Name;
			IsUnique = original.IsUnique;
			Fragments = original.Fragments;
		}

		public AutoAtlasSpec()
		{
		}
	}
}
