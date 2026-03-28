using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkshopsEffects
{
	internal record RecipeModel
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RecipeModel);
			}
		}

		[Serialize]
		public string RecipeId { get; init; }

		[Serialize]
		public string ModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RecipeModel");
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
			builder.Append("RecipeId = ");
			builder.Append((object)RecipeId);
			builder.Append(", ModelName = ");
			builder.Append((object)ModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RecipeId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(RecipeModel? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(RecipeId, other!.RecipeId))
				{
					return EqualityComparer<string>.Default.Equals(ModelName, other!.ModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RecipeModel(RecipeModel original)
		{
			RecipeId = original.RecipeId;
			ModelName = original.ModelName;
		}

		public RecipeModel()
		{
		}
	}
}
