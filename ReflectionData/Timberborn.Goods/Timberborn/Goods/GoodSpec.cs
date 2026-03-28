using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Common;
using Timberborn.LocalizationSerialization;
using Timberborn.NeedSpecs;
using Timberborn.SpriteOperations;
using UnityEngine;

namespace Timberborn.Goods
{
	public record GoodSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public ImmutableArray<string> BackwardCompatibleIds { get; init; }

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize("PluralDisplayNameLocKey")]
		public LocalizedText PluralDisplayName { get; init; }

		[Serialize]
		public ImmutableArray<InstantEffectSpec> ConsumptionEffects { get; init; }

		[Serialize]
		public string GoodType { get; init; }

		[Serialize]
		public string StockpileVisualization { get; init; }

		[Serialize]
		public VisibleContainer VisibleContainer { get; init; }

		[Serialize]
		public Color ContainerColor { get; init; }

		[Serialize]
		public AssetRef<Material> ContainerMaterial { get; init; }

		[Serialize]
		public string CarryingAnimation { get; init; }

		[Serialize]
		public int Weight { get; init; }

		[Serialize]
		public string GoodGroupId { get; init; }

		[Serialize]
		public int GoodOrder { get; init; }

		[Serialize]
		public AssetRef<Sprite> Icon { get; init; }

		[Serialize("Icon")]
		public FlippedSprite IconFlipped { get; init; }

		[Serialize("Icon")]
		public UISprite IconSmall { get; init; }

		[Serialize]
		public bool ForceImport { get; init; }

		[Serialize]
		private string DisplayNameLocKey { get; init; }

		[Serialize]
		private string PluralDisplayNameLocKey { get; init; }

		public bool HasConsumptionEffects => !ConsumptionEffects.IsEmpty();

		public override string ToString()
		{
			return Id;
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
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", PluralDisplayName = ");
			builder.Append(PluralDisplayName);
			builder.Append(", ConsumptionEffects = ");
			builder.Append(ConsumptionEffects.ToString());
			builder.Append(", GoodType = ");
			builder.Append((object)GoodType);
			builder.Append(", StockpileVisualization = ");
			builder.Append((object)StockpileVisualization);
			builder.Append(", VisibleContainer = ");
			builder.Append(VisibleContainer.ToString());
			builder.Append(", ContainerColor = ");
			builder.Append(ContainerColor.ToString());
			builder.Append(", ContainerMaterial = ");
			builder.Append(ContainerMaterial);
			builder.Append(", CarryingAnimation = ");
			builder.Append((object)CarryingAnimation);
			builder.Append(", Weight = ");
			builder.Append(Weight.ToString());
			builder.Append(", GoodGroupId = ");
			builder.Append((object)GoodGroupId);
			builder.Append(", GoodOrder = ");
			builder.Append(GoodOrder.ToString());
			builder.Append(", Icon = ");
			builder.Append(Icon);
			builder.Append(", IconFlipped = ");
			builder.Append(IconFlipped);
			builder.Append(", IconSmall = ");
			builder.Append(IconSmall);
			builder.Append(", ForceImport = ");
			builder.Append(ForceImport.ToString());
			builder.Append(", HasConsumptionEffects = ");
			builder.Append(HasConsumptionEffects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(BackwardCompatibleIds)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(PluralDisplayName)) * -1521134295 + EqualityComparer<ImmutableArray<InstantEffectSpec>>.Default.GetHashCode(ConsumptionEffects)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodType)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StockpileVisualization)) * -1521134295 + EqualityComparer<VisibleContainer>.Default.GetHashCode(VisibleContainer)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ContainerColor)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(ContainerMaterial)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CarryingAnimation)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Weight)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodGroupId)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(GoodOrder)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Icon)) * -1521134295 + EqualityComparer<FlippedSprite>.Default.GetHashCode(IconFlipped)) * -1521134295 + EqualityComparer<UISprite>.Default.GetHashCode(IconSmall)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ForceImport)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PluralDisplayNameLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<ImmutableArray<string>>.Default.Equals(BackwardCompatibleIds, other!.BackwardCompatibleIds) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<LocalizedText>.Default.Equals(PluralDisplayName, other!.PluralDisplayName) && EqualityComparer<ImmutableArray<InstantEffectSpec>>.Default.Equals(ConsumptionEffects, other!.ConsumptionEffects) && EqualityComparer<string>.Default.Equals(GoodType, other!.GoodType) && EqualityComparer<string>.Default.Equals(StockpileVisualization, other!.StockpileVisualization) && EqualityComparer<VisibleContainer>.Default.Equals(VisibleContainer, other!.VisibleContainer) && EqualityComparer<Color>.Default.Equals(ContainerColor, other!.ContainerColor) && EqualityComparer<AssetRef<Material>>.Default.Equals(ContainerMaterial, other!.ContainerMaterial) && EqualityComparer<string>.Default.Equals(CarryingAnimation, other!.CarryingAnimation) && EqualityComparer<int>.Default.Equals(Weight, other!.Weight) && EqualityComparer<string>.Default.Equals(GoodGroupId, other!.GoodGroupId) && EqualityComparer<int>.Default.Equals(GoodOrder, other!.GoodOrder) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(Icon, other!.Icon) && EqualityComparer<FlippedSprite>.Default.Equals(IconFlipped, other!.IconFlipped) && EqualityComparer<UISprite>.Default.Equals(IconSmall, other!.IconSmall) && EqualityComparer<bool>.Default.Equals(ForceImport, other!.ForceImport) && EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey))
				{
					return EqualityComparer<string>.Default.Equals(PluralDisplayNameLocKey, other!.PluralDisplayNameLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodSpec(GoodSpec original)
			: base(original)
		{
			Id = original.Id;
			BackwardCompatibleIds = original.BackwardCompatibleIds;
			DisplayName = original.DisplayName;
			PluralDisplayName = original.PluralDisplayName;
			ConsumptionEffects = original.ConsumptionEffects;
			GoodType = original.GoodType;
			StockpileVisualization = original.StockpileVisualization;
			VisibleContainer = original.VisibleContainer;
			ContainerColor = original.ContainerColor;
			ContainerMaterial = original.ContainerMaterial;
			CarryingAnimation = original.CarryingAnimation;
			Weight = original.Weight;
			GoodGroupId = original.GoodGroupId;
			GoodOrder = original.GoodOrder;
			Icon = original.Icon;
			IconFlipped = original.IconFlipped;
			IconSmall = original.IconSmall;
			ForceImport = original.ForceImport;
			DisplayNameLocKey = original.DisplayNameLocKey;
			PluralDisplayNameLocKey = original.PluralDisplayNameLocKey;
		}

		public GoodSpec()
		{
		}
	}
}
