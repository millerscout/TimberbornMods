using Timberborn.BaseComponentSystem;
using Timberborn.DuplicationSystem;
using Timberborn.MechanicalSystem;
using Timberborn.Persistence;
using Timberborn.TickSystem;
using Timberborn.WorldPersistence;
using UnityEngine;

namespace Timberborn.WaterBuildings
{
	public class WaterMover : TickableComponent, IAwakableComponent, IPersistentEntity, IDuplicable<WaterMover>, IDuplicable
	{
		private static readonly float WaterMovementThreshold = 0.0001f;

		private static readonly ComponentKey WaterMoverKey = new ComponentKey("WaterMover");

		private static readonly PropertyKey<bool> CleanWaterMovementKey = new PropertyKey<bool>("CleanWaterMovement");

		private static readonly PropertyKey<bool> ContaminatedWaterMovementKey = new PropertyKey<bool>("ContaminatedWaterMovement");

		private readonly ITickService _tickService;

		private MechanicalBuilding _mechanicalBuilding;

		private MechanicalNode _mechanicalNode;

		private WaterInput _waterInput;

		private WaterOutput _waterOutput;

		private WaterMoverSpec _waterMoverSpec;

		public bool CleanWaterMovement { get; set; } = true;


		public bool ContaminatedWaterMovement { get; set; } = true;


		public bool CanMoveWater
		{
			get
			{
				if (_mechanicalBuilding.ActiveAndPowered)
				{
					return IsWaterFlowPossible();
				}
				return false;
			}
		}

		public WaterMover(ITickService tickService)
		{
			_tickService = tickService;
		}

		public void Awake()
		{
			_mechanicalBuilding = GetComponent<MechanicalBuilding>();
			_mechanicalNode = GetComponent<MechanicalNode>();
			_waterInput = GetComponent<WaterInput>();
			_waterOutput = GetComponent<WaterOutput>();
			_waterMoverSpec = GetComponent<WaterMoverSpec>();
		}

		public override void Tick()
		{
			if (CanMoveWater)
			{
				float waterAmount = _tickService.TickIntervalInSeconds * _waterMoverSpec.WaterPerSecond * _mechanicalNode.PowerEfficiency;
				MoveWater(waterAmount);
			}
		}

		public bool IsWaterFlowPossible()
		{
			if (_waterOutput.HasSpaceForWater)
			{
				if (!CleanWaterMovement)
				{
					return _waterInput.ContaminatedWaterAmount > WaterMovementThreshold;
				}
				if (!ContaminatedWaterMovement)
				{
					return _waterInput.CleanWaterAmount > WaterMovementThreshold;
				}
				return _waterInput.IsUnderwater;
			}
			return false;
		}

		public void Save(IEntitySaver entitySaver)
		{
			IObjectSaver component = entitySaver.GetComponent(WaterMoverKey);
			component.Set(CleanWaterMovementKey, CleanWaterMovement);
			component.Set(ContaminatedWaterMovementKey, ContaminatedWaterMovement);
		}

		public void Load(IEntityLoader entityLoader)
		{
			IObjectLoader component = entityLoader.GetComponent(WaterMoverKey);
			CleanWaterMovement = component.Get(CleanWaterMovementKey);
			ContaminatedWaterMovement = component.Get(ContaminatedWaterMovementKey);
		}

		public void DuplicateFrom(WaterMover source)
		{
			CleanWaterMovement = source.CleanWaterMovement;
			ContaminatedWaterMovement = source.ContaminatedWaterMovement;
		}

		private void MoveWater(float waterAmount)
		{
			float num = waterAmount * GetCleanMovementScaler();
			float num2 = waterAmount - num;
			float availableSpace = _waterOutput.AvailableSpace;
			float num3 = Mathf.Max(Mathf.Min(num, _waterInput.CleanWaterAmount, availableSpace), 0f);
			float num4 = Mathf.Max(Mathf.Min(num2, _waterInput.ContaminatedWaterAmount, availableSpace), 0f);
			_waterInput.RemoveCleanWater(num3);
			_waterInput.RemoveContaminatedWater(num4);
			_waterOutput.AddWater(num3, num4);
		}

		private float GetCleanMovementScaler()
		{
			if (CleanWaterMovement)
			{
				float contaminationPercentage = _waterInput.ContaminationPercentage;
				if (!ContaminatedWaterMovement)
				{
					return 1f;
				}
				return 1f - contaminationPercentage;
			}
			return 0f;
		}
	}
}
