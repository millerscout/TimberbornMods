using System;
using Timberborn.Automation;
using Timberborn.BaseComponentSystem;
using Timberborn.BlockSystem;
using Timberborn.Common;
using Timberborn.DuplicationSystem;
using Timberborn.EntitySystem;
using Timberborn.Persistence;
using Timberborn.TickSystem;
using Timberborn.WaterSystem;
using Timberborn.WorldPersistence;
using UnityEngine;

namespace Timberborn.WaterBuildings
{
	public class FillValve : TickableComponent, IAwakableComponent, IInitializableEntity, IFinishedStateListener, IUnfinishedStateListener, IPersistentEntity, IDuplicable<FillValve>, IDuplicable, ITerminal
	{
		private static readonly ComponentKey ComponentKey = new ComponentKey("FillValve");

		private static readonly PropertyKey<bool> IsSynchronizedKey = new PropertyKey<bool>("IsSynchronized");

		private static readonly PropertyKey<bool> TargetHeightEnabledKey = new PropertyKey<bool>("TargetHeightEnabled");

		private static readonly PropertyKey<float> TargetHeightKey = new PropertyKey<float>("TargetHeight");

		private static readonly PropertyKey<bool> AutomationTargetHeightEnabledKey = new PropertyKey<bool>("AutomationTargetHeightEnabled");

		private static readonly PropertyKey<float> AutomationTargetHeightKey = new PropertyKey<float>("AutomationTargetHeight");

		private static readonly PropertyKey<FlowControllerState> FlowControllerStateKey = new PropertyKey<FlowControllerState>("FlowControllerState");

		private static readonly PropertyKey<bool> ObstacleAddedKey = new PropertyKey<bool>("ObstacleAdded");

		private readonly IWaterService _waterService;

		private readonly IThreadSafeWaterMap _threadSafeWaterMap;

		private readonly FillValveSynchronizer _fillValveSynchronizer;

		private BlockObject _blockObject;

		private Automatable _automatable;

		private WaterObstacleController _waterObstacleController;

		private FillValveSpec _fillValveSpec;

		private FlowControllerState _flowControllerState;

		private bool _obstacleAdded;

		private bool _isLoadedOrDuplicated;

		public bool IsSynchronized { get; private set; } = true;


		public bool TargetHeightEnabled { get; private set; }

		public float TargetHeight { get; private set; }

		public bool AutomationTargetHeightEnabled { get; private set; }

		public float AutomationTargetHeight { get; private set; }

		public Vector3Int OutputCoordinates { get; private set; }

		public bool IsAutomated => _automatable.IsAutomated;

		public bool IsInputOn => _automatable.State == ConnectionState.On;

		public int MinTargetHeight
		{
			get
			{
				if (!_threadSafeWaterMap.TryGetColumnFloor(OutputCoordinates, out var floor))
				{
					return MaxTargetHeight;
				}
				return floor;
			}
		}

		public int MaxTargetHeight => _blockObject.Coordinates.z + 1;

		public float ActualHeight => _threadSafeWaterMap.WaterHeightOrFloor(OutputCoordinates);

		public float ClampedTargetHeight => Mathf.Clamp(TargetHeight, MinTargetHeight, MaxTargetHeight);

		public float ClampedAutomationTargetHeight => Mathf.Clamp(AutomationTargetHeight, MinTargetHeight, MaxTargetHeight);

		public float TargetDepth => ClampedTargetHeight - (float)MinTargetHeight;

		public float AutomationTargetDepth => ClampedAutomationTargetHeight - (float)MinTargetHeight;

		private float EffectiveTargetHeight
		{
			get
			{
				if (!IsAutomated || !IsInputOn)
				{
					if (!TargetHeightEnabled)
					{
						return float.PositiveInfinity;
					}
					return TargetHeight;
				}
				if (!AutomationTargetHeightEnabled)
				{
					return float.PositiveInfinity;
				}
				return AutomationTargetHeight;
			}
		}

		internal FillValve(IWaterService waterService, IThreadSafeWaterMap threadSafeWaterMap, FillValveSynchronizer fillValveSynchronizer)
		{
			_waterService = waterService;
			_threadSafeWaterMap = threadSafeWaterMap;
			_fillValveSynchronizer = fillValveSynchronizer;
		}

		public void Awake()
		{
			_blockObject = GetComponent<BlockObject>();
			_automatable = GetComponent<Automatable>();
			_waterObstacleController = GetComponent<WaterObstacleController>();
			_fillValveSpec = GetComponent<FillValveSpec>();
			DisableComponent();
			_automatable.InputReconnected += OnAutomatableInputReconnected;
		}

		public void InitializeEntity()
		{
			InitializeOutputCoordinates();
			if (!_isLoadedOrDuplicated)
			{
				TargetHeightEnabled = _fillValveSpec.DefaultTargetHeightEnabled;
				TargetHeight = (float)MinTargetHeight + _fillValveSpec.DefaultTargetHeightOffset;
				AutomationTargetHeightEnabled = _fillValveSpec.DefaultAutomationTargetHeightEnabled;
				AutomationTargetHeight = (float)MinTargetHeight + _fillValveSpec.DefaultAutomationTargetHeightOffset;
			}
		}

		public void Save(IEntitySaver entitySaver)
		{
			IObjectSaver component = entitySaver.GetComponent(ComponentKey);
			component.Set(IsSynchronizedKey, IsSynchronized);
			component.Set(TargetHeightEnabledKey, TargetHeightEnabled);
			component.Set(TargetHeightKey, TargetHeight);
			component.Set(AutomationTargetHeightEnabledKey, AutomationTargetHeightEnabled);
			component.Set(AutomationTargetHeightKey, AutomationTargetHeight);
			component.Set(FlowControllerStateKey, _flowControllerState);
			component.Set(ObstacleAddedKey, _obstacleAdded);
		}

		[BackwardCompatible(2026, 3, 6, Compatibility.Save)]
		public void Load(IEntityLoader entityLoader)
		{
			IObjectLoader component = entityLoader.GetComponent(ComponentKey);
			IsSynchronized = component.Get(IsSynchronizedKey);
			SetTargetHeightEnabled(component.Get(TargetHeightEnabledKey));
			SetTargetHeight(component.Get(TargetHeightKey));
			SetAutomationTargetHeightEnabled(component.Get(AutomationTargetHeightEnabledKey));
			SetAutomationTargetHeight(component.Get(AutomationTargetHeightKey));
			_flowControllerState = component.Get(FlowControllerStateKey);
			_obstacleAdded = component.Has(ObstacleAddedKey) && component.Get(ObstacleAddedKey);
			_isLoadedOrDuplicated = true;
		}

		public void DuplicateFrom(FillValve source)
		{
			InitializeOutputCoordinates();
			IsSynchronized = source.IsSynchronized;
			SetTargetHeightEnabled(source.TargetHeightEnabled);
			SetTargetHeight((float)MinTargetHeight + source.TargetDepth);
			SetAutomationTargetHeightEnabled(source.AutomationTargetHeightEnabled);
			SetAutomationTargetHeight((float)MinTargetHeight + source.AutomationTargetDepth);
			SynchronizeNeighbors();
			_isLoadedOrDuplicated = true;
		}

		public void OnEnterUnfinishedState()
		{
			_fillValveSynchronizer.SynchronizeWithUnfinishedNeighbors(this);
		}

		public void OnExitUnfinishedState()
		{
		}

		public void OnEnterFinishedState()
		{
			EnableComponent();
			_waterService.AddDirectionLimiter(_blockObject.Coordinates, _blockObject.Orientation.ToFlowDirection());
			_waterObstacleController.UpdateState(_obstacleAdded);
			if (_flowControllerState == FlowControllerState.IncreaseFlow)
			{
				_waterService.SetControllerToIncreaseFlow(_blockObject.Coordinates);
			}
			else if (_flowControllerState == FlowControllerState.DecreaseFlow)
			{
				_waterService.SetControllerToDecreaseFlow(_blockObject.Coordinates);
			}
		}

		public void OnExitFinishedState()
		{
			DisableComponent();
			_waterService.RemoveDirectionLimiter(_blockObject.Coordinates);
			_waterService.RemoveFlowController(_blockObject.Coordinates);
		}

		public override void Tick()
		{
			if (TargetHeight < (float)MinTargetHeight)
			{
				SetTargetHeight(MinTargetHeight);
			}
			if (AutomationTargetHeight < (float)MinTargetHeight)
			{
				SetAutomationTargetHeight(MinTargetHeight);
			}
			if (EffectiveTargetHeight > (float)MinTargetHeight)
			{
				UpdateObstacle(add: false);
				if (EffectiveTargetHeight < float.PositiveInfinity || _flowControllerState != 0)
				{
					TickOutflowLimit();
				}
				else
				{
					RemoveFlowController();
				}
			}
			else
			{
				RemoveFlowController();
				UpdateObstacle(add: true);
			}
		}

		public void SetTargetHeightEnabledAndSynchronize(bool value)
		{
			SetTargetHeightEnabled(value);
			SynchronizeNeighbors();
		}

		public void SetTargetHeightEnabled(bool value)
		{
			TargetHeightEnabled = value;
		}

		public void SetTargetHeightAndSynchronize(float value)
		{
			SetTargetHeight(value);
			SynchronizeNeighbors();
		}

		public void SetTargetHeight(float value)
		{
			TargetHeight = value;
		}

		public void SetAutomationTargetHeightEnabledAndSynchronize(bool value)
		{
			SetAutomationTargetHeightEnabled(value);
			SynchronizeNeighbors();
		}

		public void SetAutomationTargetHeightEnabled(bool value)
		{
			AutomationTargetHeightEnabled = value;
		}

		public void SetAutomationTargetHeightAndSynchronize(float value)
		{
			SetAutomationTargetHeight(value);
			SynchronizeNeighbors();
		}

		public void SetAutomationTargetHeight(float value)
		{
			AutomationTargetHeight = value;
		}

		public void ToggleSynchronization(bool value)
		{
			IsSynchronized = value;
			_fillValveSynchronizer.SynchronizeWithAllNeighbors(this);
		}

		public void Evaluate()
		{
		}

		private void InitializeOutputCoordinates()
		{
			OutputCoordinates = _blockObject.TransformCoordinates(_fillValveSpec.OutputCoordinates);
		}

		private void TickOutflowLimit()
		{
			float num = _threadSafeWaterMap.WaterHeightOrFloor(OutputCoordinates) - EffectiveTargetHeight;
			bool flag = _flowControllerState == FlowControllerState.IncreaseFlow;
			bool flag2 = (flag ? (num < _fillValveSpec.OverflowLimit) : (num < 0f));
			if (flag2 != flag || _flowControllerState == FlowControllerState.NoControl)
			{
				if (flag2)
				{
					_waterService.SetControllerToIncreaseFlow(_blockObject.Coordinates);
					_flowControllerState = FlowControllerState.IncreaseFlow;
				}
				else
				{
					_waterService.SetControllerToDecreaseFlow(_blockObject.Coordinates);
					_flowControllerState = FlowControllerState.DecreaseFlow;
				}
			}
		}

		private void OnAutomatableInputReconnected(object sender, EventArgs e)
		{
			if (IsSynchronized)
			{
				SynchronizeNeighbors();
			}
		}

		private void SynchronizeNeighbors()
		{
			_fillValveSynchronizer.SynchronizeAllNeighbors(this);
		}

		private void RemoveFlowController()
		{
			if (_flowControllerState != 0)
			{
				_waterService.RemoveFlowController(_blockObject.Coordinates);
			}
			_flowControllerState = FlowControllerState.NoControl;
		}

		private void UpdateObstacle(bool add)
		{
			_waterObstacleController.UpdateState(add);
			_obstacleAdded = add;
		}
	}
}
