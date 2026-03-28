using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Common;
using Timberborn.Goods;
using Timberborn.SpriteOperations;
using UnityEngine;

namespace Timberborn.Workshops
{
	public record RecipeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(RecipeSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public ImmutableArray<string> BackwardCompatibleIds { get; init; }

		[Serialize]
		public string DisplayLocKey { get; init; }

		[Serialize]
		public float CycleDurationInHours { get; init; }

		[Serialize]
		public ImmutableArray<GoodAmountSpec> Ingredients { get; init; }

		[Serialize]
		public ImmutableArray<GoodAmountSpec> Products { get; init; }

		[Serialize]
		public int ProducedSciencePoints { get; init; }

		[Serialize]
		public string Fuel { get; init; }

		[Serialize]
		public int CyclesFuelLasts { get; init; }

		[Serialize]
		public int FuelCapacity { get; init; }

		[Serialize("Icon")]
		public UISprite UIIcon { get; init; }

		[Serialize]
		private int CyclesCapacity { get; init; }

		[Serialize]
		private AssetRef<Sprite> Icon { get; init; }

		public bool ProducesProducts => !Products.IsEmpty();

		public bool ProducesSciencePoints => ProducedSciencePoints > 0;

		public bool ConsumesIngredients => !Ingredients.IsEmpty();

		public bool ConsumesFuel => FuelCapacity > 0;

		public int GetCapacity(GoodAmount goodAmount)
		{
			return goodAmount.Amount * CyclesCapacity;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("RecipeSpec");
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
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", BackwardCompatibleIds = ");
			builder.Append(BackwardCompatibleIds.ToString());
			builder.Append(", DisplayLocKey = ");
			builder.Append((object)DisplayLocKey);
			builder.Append(", CycleDurationInHours = ");
			builder.Append(CycleDurationInHours.ToString());
			builder.Append(", Ingredients = ");
			builder.Append(Ingredients.ToString());
			builder.Append(", Products = ");
			builder.Append(Products.ToString());
			builder.Append(", ProducedSciencePoints = ");
			builder.Append(ProducedSciencePoints.ToString());
			builder.Append(", Fuel = ");
			builder.Append((object)Fuel);
			builder.Append(", CyclesFuelLasts = ");
			builder.Append(CyclesFuelLasts.ToString());
			builder.Append(", FuelCapacity = ");
			builder.Append(FuelCapacity.ToString());
			builder.Append(", UIIcon = ");
			builder.Append(UIIcon);
			builder.Append(", ProducesProducts = ");
			builder.Append(ProducesProducts.ToString());
			builder.Append(", ProducesSciencePoints = ");
			builder.Append(ProducesSciencePoints.ToString());
			builder.Append(", ConsumesIngredients = ");
			builder.Append(ConsumesIngredients.ToString());
			builder.Append(", ConsumesFuel = ");
			builder.Append(ConsumesFuel.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(BackwardCompatibleIds)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayLocKey)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(CycleDurationInHours)) * -1521134295 + EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.GetHashCode(Ingredients)) * -1521134295 + EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.GetHashCode(Products)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(ProducedSciencePoints)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Fuel)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CyclesFuelLasts)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FuelCapacity)) * -1521134295 + EqualityComparer<UISprite>.Default.GetHashCode(UIIcon)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CyclesCapacity)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Icon);
		}

		[CompilerGenerated]
		public virtual bool Equals(RecipeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<ImmutableArray<string>>.Default.Equals(BackwardCompatibleIds, other!.BackwardCompatibleIds) && EqualityComparer<string>.Default.Equals(DisplayLocKey, other!.DisplayLocKey) && EqualityComparer<float>.Default.Equals(CycleDurationInHours, other!.CycleDurationInHours) && EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.Equals(Ingredients, other!.Ingredients) && EqualityComparer<ImmutableArray<GoodAmountSpec>>.Default.Equals(Products, other!.Products) && EqualityComparer<int>.Default.Equals(ProducedSciencePoints, other!.ProducedSciencePoints) && EqualityComparer<string>.Default.Equals(Fuel, other!.Fuel) && EqualityComparer<int>.Default.Equals(CyclesFuelLasts, other!.CyclesFuelLasts) && EqualityComparer<int>.Default.Equals(FuelCapacity, other!.FuelCapacity) && EqualityComparer<UISprite>.Default.Equals(UIIcon, other!.UIIcon) && EqualityComparer<int>.Default.Equals(CyclesCapacity, other!.CyclesCapacity))
				{
					return EqualityComparer<AssetRef<Sprite>>.Default.Equals(Icon, other!.Icon);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected RecipeSpec(RecipeSpec original)
			: base(original)
		{
			Id = original.Id;
			BackwardCompatibleIds = original.BackwardCompatibleIds;
			DisplayLocKey = original.DisplayLocKey;
			CycleDurationInHours = original.CycleDurationInHours;
			Ingredients = original.Ingredients;
			Products = original.Products;
			ProducedSciencePoints = original.ProducedSciencePoints;
			Fuel = original.Fuel;
			CyclesFuelLasts = original.CyclesFuelLasts;
			FuelCapacity = original.FuelCapacity;
			UIIcon = original.UIIcon;
			CyclesCapacity = original.CyclesCapacity;
			Icon = original.Icon;
		}

		public RecipeSpec()
		{
		}
	}
}
