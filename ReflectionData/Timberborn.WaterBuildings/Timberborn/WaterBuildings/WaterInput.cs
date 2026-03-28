using Timberborn.BaseComponentSystem;
using Timberborn.WaterSystem;

namespace Timberborn.WaterBuildings
{
	public class WaterInput : BaseComponent, IAwakableComponent
	{
		private readonly IWaterService _waterService;

		private readonly IThreadSafeWaterMap _threadSafeWaterMap;

		private WaterInputCoordinates _inputCoordinates;

		public bool IsUnderwater
		{
			get
			{
				if (_inputCoordinates.Depth > 0)
				{
					return _threadSafeWaterMap.CellIsUnderwater(_inputCoordinates.Coordinates);
				}
				return false;
			}
		}

		public float ContaminatedWaterAmount => ContaminationPercentage * AvailableWater;

		public float CleanWaterAmount => AvailableWater - ContaminatedWaterAmount;

		public float ContaminationPercentage => _threadSafeWaterMap.ColumnContamination(_inputCoordinates.Coordinates);

		private float AvailableWater => _threadSafeWaterMap.WaterHeightOrFloor(_inputCoordinates.Coordinates) - (float)_inputCoordinates.Coordinates.z;

		public WaterInput(IWaterService waterService, IThreadSafeWaterMap threadSafeWaterMap)
		{
			_waterService = waterService;
			_threadSafeWaterMap = threadSafeWaterMap;
		}

		public void Awake()
		{
			_inputCoordinates = GetComponent<WaterInputCoordinates>();
		}

		public void RemoveCleanWater(float waterAmount)
		{
			_waterService.RemoveCleanWater(_inputCoordinates.Coordinates, waterAmount);
		}

		public void RemoveContaminatedWater(float waterAmount)
		{
			_waterService.RemoveContaminatedWater(_inputCoordinates.Coordinates, waterAmount);
		}
	}
}
