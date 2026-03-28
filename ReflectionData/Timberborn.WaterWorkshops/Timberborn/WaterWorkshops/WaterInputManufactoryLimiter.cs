using Timberborn.BaseComponentSystem;
using Timberborn.WaterBuildings;
using Timberborn.Workshops;

namespace Timberborn.WaterWorkshops
{
	internal class WaterInputManufactoryLimiter : BaseComponent, IAwakableComponent, IManufactoryLimiter
	{
		private static readonly float EfficiencyThreshold = 0.0001f;

		private WaterInput _waterInput;

		private ManufactoryWaterConsumer _manufactoryWaterConsumer;

		public void Awake()
		{
			_waterInput = GetComponent<WaterInput>();
			_manufactoryWaterConsumer = GetComponent<ManufactoryWaterConsumer>();
		}

		public float ProductionEfficiency()
		{
			if (!_waterInput.IsUnderwater)
			{
				return 0f;
			}
			float num = 1f - _waterInput.ContaminationPercentage;
			if (num < EfficiencyThreshold)
			{
				return 0f;
			}
			return num;
		}

		public float MaxProductionProgressChange()
		{
			float consumedWater = _manufactoryWaterConsumer.ConsumedWater;
			if (consumedWater > 0f)
			{
				return _waterInput.CleanWaterAmount / consumedWater;
			}
			return 0f;
		}
	}
}
