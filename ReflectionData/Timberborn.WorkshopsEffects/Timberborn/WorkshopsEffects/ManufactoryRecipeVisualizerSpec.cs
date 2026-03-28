using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkshopsEffects
{
	internal record ManufactoryRecipeVisualizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ManufactoryRecipeVisualizerSpec);
			}
		}

		[Serialize]
		public string InitialModelName { get; init; }

		[Serialize]
		public ImmutableArray<RecipeModel> RecipeModels { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ManufactoryRecipeVisualizerSpec");
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
			builder.Append("InitialModelName = ");
			builder.Append((object)InitialModelName);
			builder.Append(", RecipeModels = ");
			builder.Append(RecipeModels.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InitialModelName)) * -1521134295 + EqualityComparer<ImmutableArray<RecipeModel>>.Default.GetHashCode(RecipeModels);
		}

		[CompilerGenerated]
		public virtual bool Equals(ManufactoryRecipeVisualizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(InitialModelName, other!.InitialModelName))
				{
					return EqualityComparer<ImmutableArray<RecipeModel>>.Default.Equals(RecipeModels, other!.RecipeModels);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ManufactoryRecipeVisualizerSpec(ManufactoryRecipeVisualizerSpec original)
			: base(original)
		{
			InitialModelName = original.InitialModelName;
			RecipeModels = original.RecipeModels;
		}

		public ManufactoryRecipeVisualizerSpec()
		{
		}
	}
}
