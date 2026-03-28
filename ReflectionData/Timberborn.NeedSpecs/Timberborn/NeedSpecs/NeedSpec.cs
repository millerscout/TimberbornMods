using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.NeedSpecs
{
	public record NeedSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public ImmutableArray<string> BackwardCompatibleIds { get; init; }

		[Serialize]
		public int Order { get; init; }

		[Serialize]
		public string NeedGroupId { get; init; }

		[Serialize]
		public string CharacterType { get; init; }

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize]
		public float StartingValue { get; init; }

		[Serialize]
		public float MinimumValue { get; init; }

		[Serialize]
		public float MaximumValue { get; init; }

		[Serialize]
		public float DailyDelta { get; init; }

		[Serialize]
		public float ImportanceMultiplier { get; init; }

		[Serialize]
		public float Effectiveness { get; init; }

		[Serialize]
		public bool Wastable { get; init; }

		[Serialize]
		public float HoursWarningThreshold { get; init; }

		[Serialize]
		public string DisplayNameLocKey { get; init; }

		[Serialize]
		private int FavorableWellbeing { get; init; }

		[Serialize]
		private int UnfavorableWellbeing { get; init; }

		public bool IsNeverNegative => MinimumValue >= 0f;

		public bool IsNeverPositive => MaximumValue <= 0f;

		public bool AffectsWellbeing
		{
			get
			{
				if (FavorableWellbeing == 0)
				{
					return UnfavorableWellbeing != 0;
				}
				return true;
			}
		}

		public int GetFavorableWellbeing()
		{
			return GetWellbeing(isFavourable: true);
		}

		public int GetUnfavorableWellbeing()
		{
			return GetWellbeing(isFavourable: false);
		}

		private int GetWellbeing(bool isFavourable)
		{
			if (!isFavourable)
			{
				return UnfavorableWellbeing;
			}
			return FavorableWellbeing;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedSpec");
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
			builder.Append(", Order = ");
			builder.Append(Order.ToString());
			builder.Append(", NeedGroupId = ");
			builder.Append((object)NeedGroupId);
			builder.Append(", CharacterType = ");
			builder.Append((object)CharacterType);
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", StartingValue = ");
			builder.Append(StartingValue.ToString());
			builder.Append(", MinimumValue = ");
			builder.Append(MinimumValue.ToString());
			builder.Append(", MaximumValue = ");
			builder.Append(MaximumValue.ToString());
			builder.Append(", DailyDelta = ");
			builder.Append(DailyDelta.ToString());
			builder.Append(", ImportanceMultiplier = ");
			builder.Append(ImportanceMultiplier.ToString());
			builder.Append(", Effectiveness = ");
			builder.Append(Effectiveness.ToString());
			builder.Append(", Wastable = ");
			builder.Append(Wastable.ToString());
			builder.Append(", HoursWarningThreshold = ");
			builder.Append(HoursWarningThreshold.ToString());
			builder.Append(", DisplayNameLocKey = ");
			builder.Append((object)DisplayNameLocKey);
			builder.Append(", IsNeverNegative = ");
			builder.Append(IsNeverNegative.ToString());
			builder.Append(", IsNeverPositive = ");
			builder.Append(IsNeverPositive.ToString());
			builder.Append(", AffectsWellbeing = ");
			builder.Append(AffectsWellbeing.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(BackwardCompatibleIds)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NeedGroupId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CharacterType)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(StartingValue)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinimumValue)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaximumValue)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DailyDelta)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ImportanceMultiplier)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Effectiveness)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Wastable)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(HoursWarningThreshold)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(FavorableWellbeing)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(UnfavorableWellbeing);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<ImmutableArray<string>>.Default.Equals(BackwardCompatibleIds, other!.BackwardCompatibleIds) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<string>.Default.Equals(NeedGroupId, other!.NeedGroupId) && EqualityComparer<string>.Default.Equals(CharacterType, other!.CharacterType) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<float>.Default.Equals(StartingValue, other!.StartingValue) && EqualityComparer<float>.Default.Equals(MinimumValue, other!.MinimumValue) && EqualityComparer<float>.Default.Equals(MaximumValue, other!.MaximumValue) && EqualityComparer<float>.Default.Equals(DailyDelta, other!.DailyDelta) && EqualityComparer<float>.Default.Equals(ImportanceMultiplier, other!.ImportanceMultiplier) && EqualityComparer<float>.Default.Equals(Effectiveness, other!.Effectiveness) && EqualityComparer<bool>.Default.Equals(Wastable, other!.Wastable) && EqualityComparer<float>.Default.Equals(HoursWarningThreshold, other!.HoursWarningThreshold) && EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey) && EqualityComparer<int>.Default.Equals(FavorableWellbeing, other!.FavorableWellbeing))
				{
					return EqualityComparer<int>.Default.Equals(UnfavorableWellbeing, other!.UnfavorableWellbeing);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedSpec(NeedSpec original)
			: base(original)
		{
			Id = original.Id;
			BackwardCompatibleIds = original.BackwardCompatibleIds;
			Order = original.Order;
			NeedGroupId = original.NeedGroupId;
			CharacterType = original.CharacterType;
			DisplayName = original.DisplayName;
			StartingValue = original.StartingValue;
			MinimumValue = original.MinimumValue;
			MaximumValue = original.MaximumValue;
			DailyDelta = original.DailyDelta;
			ImportanceMultiplier = original.ImportanceMultiplier;
			Effectiveness = original.Effectiveness;
			Wastable = original.Wastable;
			HoursWarningThreshold = original.HoursWarningThreshold;
			DisplayNameLocKey = original.DisplayNameLocKey;
			FavorableWellbeing = original.FavorableWellbeing;
			UnfavorableWellbeing = original.UnfavorableWellbeing;
		}

		public NeedSpec()
		{
		}
	}
}
