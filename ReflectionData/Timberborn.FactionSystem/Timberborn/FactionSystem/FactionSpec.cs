using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;
using UnityEngine;

namespace Timberborn.FactionSystem
{
	public record FactionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FactionSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public int Order { get; init; }

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize("DescriptionLocKey")]
		public LocalizedText Description { get; init; }

		[Serialize]
		public AssetRef<Sprite> Avatar { get; init; }

		[Serialize]
		public AssetRef<Sprite> ChildAvatar { get; init; }

		[Serialize]
		public AssetRef<Sprite> BotAvatar { get; init; }

		[Serialize]
		public AssetRef<Sprite> ContaminatedAdultAvatar { get; init; }

		[Serialize]
		public AssetRef<Sprite> ContaminatedChildAvatar { get; init; }

		[Serialize]
		public AssetRef<Sprite> Logo { get; init; }

		[Serialize]
		public AssetRef<Sprite> NewGameFullAvatar { get; init; }

		[Serialize]
		public ImmutableArray<AssetRef<Texture2D>> Textures { get; init; }

		[Serialize]
		public ImmutableArray<AssetRef<Texture2D>> ChildTextures { get; init; }

		[Serialize]
		public ImmutableArray<string> MaterialCollectionIds { get; init; }

		[Serialize]
		public ImmutableArray<string> TemplateCollectionIds { get; init; }

		[Serialize]
		public AssetRef<Material> PathMaterial { get; init; }

		[Serialize]
		public AssetRef<Material> BaseWoodMaterial { get; init; }

		[Serialize]
		public ImmutableArray<string> NeedCollectionIds { get; init; }

		[Serialize]
		public ImmutableArray<string> GoodCollectionIds { get; init; }

		[Serialize]
		public ImmutableArray<BlueprintModifierSpec> BlueprintModifiers { get; init; }

		[Serialize]
		public string StartingBuildingId { get; init; }

		[Serialize]
		public string SoundId { get; init; }

		[Serialize("GameOverMessageLocKey")]
		public LocalizedText GameOverMessage { get; init; }

		[Serialize("GameOverFlavorLocKey")]
		public LocalizedText GameOverFlavor { get; init; }

		[Serialize]
		private string DisplayNameLocKey { get; init; }

		[Serialize]
		private string DescriptionLocKey { get; init; }

		[Serialize]
		private string GameOverMessageLocKey { get; init; }

		[Serialize]
		private string GameOverFlavorLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FactionSpec");
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
			builder.Append(", Order = ");
			builder.Append(Order.ToString());
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", Description = ");
			builder.Append(Description);
			builder.Append(", Avatar = ");
			builder.Append(Avatar);
			builder.Append(", ChildAvatar = ");
			builder.Append(ChildAvatar);
			builder.Append(", BotAvatar = ");
			builder.Append(BotAvatar);
			builder.Append(", ContaminatedAdultAvatar = ");
			builder.Append(ContaminatedAdultAvatar);
			builder.Append(", ContaminatedChildAvatar = ");
			builder.Append(ContaminatedChildAvatar);
			builder.Append(", Logo = ");
			builder.Append(Logo);
			builder.Append(", NewGameFullAvatar = ");
			builder.Append(NewGameFullAvatar);
			builder.Append(", Textures = ");
			builder.Append(Textures.ToString());
			builder.Append(", ChildTextures = ");
			builder.Append(ChildTextures.ToString());
			builder.Append(", MaterialCollectionIds = ");
			builder.Append(MaterialCollectionIds.ToString());
			builder.Append(", TemplateCollectionIds = ");
			builder.Append(TemplateCollectionIds.ToString());
			builder.Append(", PathMaterial = ");
			builder.Append(PathMaterial);
			builder.Append(", BaseWoodMaterial = ");
			builder.Append(BaseWoodMaterial);
			builder.Append(", NeedCollectionIds = ");
			builder.Append(NeedCollectionIds.ToString());
			builder.Append(", GoodCollectionIds = ");
			builder.Append(GoodCollectionIds.ToString());
			builder.Append(", BlueprintModifiers = ");
			builder.Append(BlueprintModifiers.ToString());
			builder.Append(", StartingBuildingId = ");
			builder.Append((object)StartingBuildingId);
			builder.Append(", SoundId = ");
			builder.Append((object)SoundId);
			builder.Append(", GameOverMessage = ");
			builder.Append(GameOverMessage);
			builder.Append(", GameOverFlavor = ");
			builder.Append(GameOverFlavor);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((((((((((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(Description)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Avatar)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(ChildAvatar)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(BotAvatar)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(ContaminatedAdultAvatar)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(ContaminatedChildAvatar)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(Logo)) * -1521134295 + EqualityComparer<AssetRef<Sprite>>.Default.GetHashCode(NewGameFullAvatar)) * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<Texture2D>>>.Default.GetHashCode(Textures)) * -1521134295 + EqualityComparer<ImmutableArray<AssetRef<Texture2D>>>.Default.GetHashCode(ChildTextures)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(MaterialCollectionIds)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(TemplateCollectionIds)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(PathMaterial)) * -1521134295 + EqualityComparer<AssetRef<Material>>.Default.GetHashCode(BaseWoodMaterial)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(NeedCollectionIds)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(GoodCollectionIds)) * -1521134295 + EqualityComparer<ImmutableArray<BlueprintModifierSpec>>.Default.GetHashCode(BlueprintModifiers)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StartingBuildingId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SoundId)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(GameOverMessage)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(GameOverFlavor)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DescriptionLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameOverMessageLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameOverFlavorLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(FactionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<LocalizedText>.Default.Equals(Description, other!.Description) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(Avatar, other!.Avatar) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(ChildAvatar, other!.ChildAvatar) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(BotAvatar, other!.BotAvatar) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(ContaminatedAdultAvatar, other!.ContaminatedAdultAvatar) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(ContaminatedChildAvatar, other!.ContaminatedChildAvatar) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(Logo, other!.Logo) && EqualityComparer<AssetRef<Sprite>>.Default.Equals(NewGameFullAvatar, other!.NewGameFullAvatar) && EqualityComparer<ImmutableArray<AssetRef<Texture2D>>>.Default.Equals(Textures, other!.Textures) && EqualityComparer<ImmutableArray<AssetRef<Texture2D>>>.Default.Equals(ChildTextures, other!.ChildTextures) && EqualityComparer<ImmutableArray<string>>.Default.Equals(MaterialCollectionIds, other!.MaterialCollectionIds) && EqualityComparer<ImmutableArray<string>>.Default.Equals(TemplateCollectionIds, other!.TemplateCollectionIds) && EqualityComparer<AssetRef<Material>>.Default.Equals(PathMaterial, other!.PathMaterial) && EqualityComparer<AssetRef<Material>>.Default.Equals(BaseWoodMaterial, other!.BaseWoodMaterial) && EqualityComparer<ImmutableArray<string>>.Default.Equals(NeedCollectionIds, other!.NeedCollectionIds) && EqualityComparer<ImmutableArray<string>>.Default.Equals(GoodCollectionIds, other!.GoodCollectionIds) && EqualityComparer<ImmutableArray<BlueprintModifierSpec>>.Default.Equals(BlueprintModifiers, other!.BlueprintModifiers) && EqualityComparer<string>.Default.Equals(StartingBuildingId, other!.StartingBuildingId) && EqualityComparer<string>.Default.Equals(SoundId, other!.SoundId) && EqualityComparer<LocalizedText>.Default.Equals(GameOverMessage, other!.GameOverMessage) && EqualityComparer<LocalizedText>.Default.Equals(GameOverFlavor, other!.GameOverFlavor) && EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey) && EqualityComparer<string>.Default.Equals(DescriptionLocKey, other!.DescriptionLocKey) && EqualityComparer<string>.Default.Equals(GameOverMessageLocKey, other!.GameOverMessageLocKey))
				{
					return EqualityComparer<string>.Default.Equals(GameOverFlavorLocKey, other!.GameOverFlavorLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FactionSpec(FactionSpec original)
			: base(original)
		{
			Id = original.Id;
			Order = original.Order;
			DisplayName = original.DisplayName;
			Description = original.Description;
			Avatar = original.Avatar;
			ChildAvatar = original.ChildAvatar;
			BotAvatar = original.BotAvatar;
			ContaminatedAdultAvatar = original.ContaminatedAdultAvatar;
			ContaminatedChildAvatar = original.ContaminatedChildAvatar;
			Logo = original.Logo;
			NewGameFullAvatar = original.NewGameFullAvatar;
			Textures = original.Textures;
			ChildTextures = original.ChildTextures;
			MaterialCollectionIds = original.MaterialCollectionIds;
			TemplateCollectionIds = original.TemplateCollectionIds;
			PathMaterial = original.PathMaterial;
			BaseWoodMaterial = original.BaseWoodMaterial;
			NeedCollectionIds = original.NeedCollectionIds;
			GoodCollectionIds = original.GoodCollectionIds;
			BlueprintModifiers = original.BlueprintModifiers;
			StartingBuildingId = original.StartingBuildingId;
			SoundId = original.SoundId;
			GameOverMessage = original.GameOverMessage;
			GameOverFlavor = original.GameOverFlavor;
			DisplayNameLocKey = original.DisplayNameLocKey;
			DescriptionLocKey = original.DescriptionLocKey;
			GameOverMessageLocKey = original.GameOverMessageLocKey;
			GameOverFlavorLocKey = original.GameOverFlavorLocKey;
		}

		public FactionSpec()
		{
		}
	}
}
