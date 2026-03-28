using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Ruins
{
	internal record RuinModelFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RuinModelFactorySpec);
			}
		}

		[Serialize]
		public AssetRef<GameObject> IvyDryModel { get; init; }

		[Serialize]
		public AssetRef<GameObject> IvyWetModel { get; init; }

		[Serialize]
		public ImmutableArray<RuinModelVariantSpec> RuinModelVariants { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RuinModelFactorySpec");
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
			builder.Append("IvyDryModel = ");
			builder.Append(IvyDryModel);
			builder.Append(", IvyWetModel = ");
			builder.Append(IvyWetModel);
			builder.Append(", RuinModelVariants = ");
			builder.Append(RuinModelVariants.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(IvyDryModel)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(IvyWetModel)) * -1521134295 + EqualityComparer<ImmutableArray<RuinModelVariantSpec>>.Default.GetHashCode(RuinModelVariants);
		}

		[CompilerGenerated]
		public virtual bool Equals(RuinModelFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(IvyDryModel, other!.IvyDryModel) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(IvyWetModel, other!.IvyWetModel))
				{
					return EqualityComparer<ImmutableArray<RuinModelVariantSpec>>.Default.Equals(RuinModelVariants, other!.RuinModelVariants);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RuinModelFactorySpec(RuinModelFactorySpec original)
			: base(original)
		{
			IvyDryModel = original.IvyDryModel;
			IvyWetModel = original.IvyWetModel;
			RuinModelVariants = original.RuinModelVariants;
		}

		public RuinModelFactorySpec()
		{
		}
	}
}
