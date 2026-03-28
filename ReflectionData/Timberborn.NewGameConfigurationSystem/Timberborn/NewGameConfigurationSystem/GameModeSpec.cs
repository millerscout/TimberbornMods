using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NewGameConfigurationSystem
{
	public record GameModeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GameModeSpec);
			}
		}

		[Serialize]
		public int Order { get; init; }

		[Serialize]
		public bool IsDefault { get; init; }

		[Serialize]
		public string DisplayNameLocKey { get; init; }

		[Serialize]
		public string DescriptionLocKey { get; init; }

		[Serialize]
		public int StartingAdults { get; init; }

		[Serialize]
		public MinMaxSpec<float> AdultAgeProgress { get; init; }

		[Serialize]
		public int StartingChildren { get; init; }

		[Serialize]
		public MinMaxSpec<float> ChildAgeProgress { get; init; }

		[Serialize]
		public float FoodConsumption { get; init; }

		[Serialize]
		public float WaterConsumption { get; init; }

		[Serialize]
		public int StartingFood { get; init; }

		[Serialize]
		public int StartingWater { get; init; }

		[Serialize]
		public MinMaxSpec<int> TemperateWeatherDuration { get; init; }

		[Serialize]
		public MinMaxSpec<int> DroughtDuration { get; init; }

		[Serialize]
		public float DroughtDurationHandicapMultiplier { get; init; }

		[Serialize]
		public int DroughtDurationHandicapCycles { get; init; }

		[Serialize]
		public int CyclesBeforeRandomizingBadtide { get; init; }

		[Serialize]
		public float ChanceForBadtide { get; init; }

		[Serialize]
		public MinMaxSpec<int> BadtideDuration { get; init; }

		[Serialize]
		public float BadtideDurationHandicapMultiplier { get; init; }

		[Serialize]
		public int BadtideDurationHandicapCycles { get; init; }

		[Serialize]
		public float InjuryChance { get; init; }

		[Serialize]
		public float DemolishableRecoveryRate { get; init; }

		public override string ToString()
		{
			return string.Format("{0}: {1}\n", "Order", Order) + "DisplayNameLocKey: " + DisplayNameLocKey + "\nDescriptionLocKey: " + DescriptionLocKey + "\n" + string.Format("{0}: {1}\n", "StartingAdults", StartingAdults) + string.Format("{0}: {1}\n", "AdultAgeProgress", AdultAgeProgress) + string.Format("{0}: {1}\n", "StartingChildren", StartingChildren) + string.Format("{0}: {1}\n", "ChildAgeProgress", ChildAgeProgress) + string.Format("{0}: {1}\n", "FoodConsumption", FoodConsumption) + string.Format("{0}: {1}\n", "WaterConsumption", WaterConsumption) + string.Format("{0}: {1}\n", "StartingFood", StartingFood) + string.Format("{0}: {1}\n", "StartingWater", StartingWater) + string.Format("{0}: {1}\n", "TemperateWeatherDuration", TemperateWeatherDuration) + string.Format("{0}: {1}\n", "DroughtDuration", DroughtDuration) + string.Format("{0}: {1}\n", "DroughtDurationHandicapMultiplier", DroughtDurationHandicapMultiplier) + string.Format("{0}: {1}\n", "DroughtDurationHandicapCycles", DroughtDurationHandicapCycles) + string.Format("{0}: {1}\n", "CyclesBeforeRandomizingBadtide", CyclesBeforeRandomizingBadtide) + string.Format("{0}: {1}\n", "ChanceForBadtide", ChanceForBadtide) + string.Format("{0}: {1}\n", "BadtideDuration", BadtideDuration) + string.Format("{0}: {1}\n", "BadtideDurationHandicapMultiplier", BadtideDurationHandicapMultiplier) + string.Format("{0}: {1}\n", "BadtideDurationHandicapCycles", BadtideDurationHandicapCycles) + string.Format("{0}: {1}\n", "InjuryChance", InjuryChance) + string.Format("{0}: {1}", "DemolishableRecoveryRate", DemolishableRecoveryRate);
		}

		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder)
		{
			if (base.PrintMembers(builder))
			{
				builder.Append(", ");
			}
			builder.Append("Order = ");
			builder.Append(Order.ToString());
			builder.Append(", IsDefault = ");
			builder.Append(IsDefault.ToString());
			builder.Append(", DisplayNameLocKey = ");
			builder.Append((object)DisplayNameLocKey);
			builder.Append(", DescriptionLocKey = ");
			builder.Append((object)DescriptionLocKey);
			builder.Append(", StartingAdults = ");
			builder.Append(StartingAdults.ToString());
			builder.Append(", AdultAgeProgress = ");
			builder.Append(AdultAgeProgress);
			builder.Append(", StartingChildren = ");
			builder.Append(StartingChildren.ToString());
			builder.Append(", ChildAgeProgress = ");
			builder.Append(ChildAgeProgress);
			builder.Append(", FoodConsumption = ");
			builder.Append(FoodConsumption.ToString());
			builder.Append(", WaterConsumption = ");
			builder.Append(WaterConsumption.ToString());
			builder.Append(", StartingFood = ");
			builder.Append(StartingFood.ToString());
			builder.Append(", StartingWater = ");
			builder.Append(StartingWater.ToString());
			builder.Append(", TemperateWeatherDuration = ");
			builder.Append(TemperateWeatherDuration);
			builder.Append(", DroughtDuration = ");
			builder.Append(DroughtDuration);
			builder.Append(", DroughtDurationHandicapMultiplier = ");
			builder.Append(DroughtDurationHandicapMultiplier.ToString());
			builder.Append(", DroughtDurationHandicapCycles = ");
			builder.Append(DroughtDurationHandicapCycles.ToString());
			builder.Append(", CyclesBeforeRandomizingBadtide = ");
			builder.Append(CyclesBeforeRandomizingBadtide.ToString());
			builder.Append(", ChanceForBadtide = ");
			builder.Append(ChanceForBadtide.ToString());
			builder.Append(", BadtideDuration = ");
			builder.Append(BadtideDuration);
			builder.Append(", BadtideDurationHandicapMultiplier = ");
			builder.Append(BadtideDurationHandicapMultiplier.ToString());
			builder.Append(", BadtideDurationHandicapCycles = ");
			builder.Append(BadtideDurationHandicapCycles.ToString());
			builder.Append(", InjuryChance = ");
			builder.Append(InjuryChance.ToString());
			builder.Append(", DemolishableRecoveryRate = ");
			builder.Append(DemolishableRecoveryRate.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Order)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IsDefault)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DescriptionLocKey)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(StartingAdults)) * -1521134295 + EqualityComparer<MinMaxSpec<float>>.Default.GetHashCode(AdultAgeProgress)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(StartingChildren)) * -1521134295 + EqualityComparer<MinMaxSpec<float>>.Default.GetHashCode(ChildAgeProgress)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(FoodConsumption)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(WaterConsumption)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(StartingFood)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(StartingWater)) * -1521134295 + EqualityComparer<MinMaxSpec<int>>.Default.GetHashCode(TemperateWeatherDuration)) * -1521134295 + EqualityComparer<MinMaxSpec<int>>.Default.GetHashCode(DroughtDuration)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DroughtDurationHandicapMultiplier)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(DroughtDurationHandicapCycles)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CyclesBeforeRandomizingBadtide)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(ChanceForBadtide)) * -1521134295 + EqualityComparer<MinMaxSpec<int>>.Default.GetHashCode(BadtideDuration)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(BadtideDurationHandicapMultiplier)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(BadtideDurationHandicapCycles)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(InjuryChance)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DemolishableRecoveryRate);
		}

		[CompilerGenerated]
		public virtual bool Equals(GameModeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(Order, other!.Order) && EqualityComparer<bool>.Default.Equals(IsDefault, other!.IsDefault) && EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey) && EqualityComparer<string>.Default.Equals(DescriptionLocKey, other!.DescriptionLocKey) && EqualityComparer<int>.Default.Equals(StartingAdults, other!.StartingAdults) && EqualityComparer<MinMaxSpec<float>>.Default.Equals(AdultAgeProgress, other!.AdultAgeProgress) && EqualityComparer<int>.Default.Equals(StartingChildren, other!.StartingChildren) && EqualityComparer<MinMaxSpec<float>>.Default.Equals(ChildAgeProgress, other!.ChildAgeProgress) && EqualityComparer<float>.Default.Equals(FoodConsumption, other!.FoodConsumption) && EqualityComparer<float>.Default.Equals(WaterConsumption, other!.WaterConsumption) && EqualityComparer<int>.Default.Equals(StartingFood, other!.StartingFood) && EqualityComparer<int>.Default.Equals(StartingWater, other!.StartingWater) && EqualityComparer<MinMaxSpec<int>>.Default.Equals(TemperateWeatherDuration, other!.TemperateWeatherDuration) && EqualityComparer<MinMaxSpec<int>>.Default.Equals(DroughtDuration, other!.DroughtDuration) && EqualityComparer<float>.Default.Equals(DroughtDurationHandicapMultiplier, other!.DroughtDurationHandicapMultiplier) && EqualityComparer<int>.Default.Equals(DroughtDurationHandicapCycles, other!.DroughtDurationHandicapCycles) && EqualityComparer<int>.Default.Equals(CyclesBeforeRandomizingBadtide, other!.CyclesBeforeRandomizingBadtide) && EqualityComparer<float>.Default.Equals(ChanceForBadtide, other!.ChanceForBadtide) && EqualityComparer<MinMaxSpec<int>>.Default.Equals(BadtideDuration, other!.BadtideDuration) && EqualityComparer<float>.Default.Equals(BadtideDurationHandicapMultiplier, other!.BadtideDurationHandicapMultiplier) && EqualityComparer<int>.Default.Equals(BadtideDurationHandicapCycles, other!.BadtideDurationHandicapCycles) && EqualityComparer<float>.Default.Equals(InjuryChance, other!.InjuryChance))
				{
					return EqualityComparer<float>.Default.Equals(DemolishableRecoveryRate, other!.DemolishableRecoveryRate);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GameModeSpec(GameModeSpec original)
			: base(original)
		{
			Order = original.Order;
			IsDefault = original.IsDefault;
			DisplayNameLocKey = original.DisplayNameLocKey;
			DescriptionLocKey = original.DescriptionLocKey;
			StartingAdults = original.StartingAdults;
			AdultAgeProgress = original.AdultAgeProgress;
			StartingChildren = original.StartingChildren;
			ChildAgeProgress = original.ChildAgeProgress;
			FoodConsumption = original.FoodConsumption;
			WaterConsumption = original.WaterConsumption;
			StartingFood = original.StartingFood;
			StartingWater = original.StartingWater;
			TemperateWeatherDuration = original.TemperateWeatherDuration;
			DroughtDuration = original.DroughtDuration;
			DroughtDurationHandicapMultiplier = original.DroughtDurationHandicapMultiplier;
			DroughtDurationHandicapCycles = original.DroughtDurationHandicapCycles;
			CyclesBeforeRandomizingBadtide = original.CyclesBeforeRandomizingBadtide;
			ChanceForBadtide = original.ChanceForBadtide;
			BadtideDuration = original.BadtideDuration;
			BadtideDurationHandicapMultiplier = original.BadtideDurationHandicapMultiplier;
			BadtideDurationHandicapCycles = original.BadtideDurationHandicapCycles;
			InjuryChance = original.InjuryChance;
			DemolishableRecoveryRate = original.DemolishableRecoveryRate;
		}

		public GameModeSpec()
		{
		}
	}
}
