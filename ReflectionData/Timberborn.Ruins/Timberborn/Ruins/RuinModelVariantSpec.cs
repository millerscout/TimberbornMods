using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Ruins
{
	internal record RuinModelVariantSpec
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RuinModelVariantSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public AssetRef<GameObject> Model { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RuinModelVariantSpec");
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
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", Model = ");
			builder.Append(Model);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(Model);
		}

		[CompilerGenerated]
		public virtual bool Equals(RuinModelVariantSpec? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Id, other!.Id))
				{
					return EqualityComparer<AssetRef<GameObject>>.Default.Equals(Model, other!.Model);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RuinModelVariantSpec(RuinModelVariantSpec original)
		{
			Id = original.Id;
			Model = original.Model;
		}

		public RuinModelVariantSpec()
		{
		}
	}
}
