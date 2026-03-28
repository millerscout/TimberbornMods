using System;
using System.Collections.Generic;
using Timberborn.Common;
using Timberborn.MapEditorTickSystem;
using Timberborn.MapIndexSystem;
using Timberborn.SingletonSystem;
using Timberborn.TickSystem;
using UnityEngine;

namespace Timberborn.WaterSystem
{
	[MapEditorTickable]
	internal class FlowLimiterService : IFlowLimiterService, ITickableSingleton, ILoadableSingleton, IPostLoadableSingleton
	{
		private readonly struct Modification
		{
			public Vector3Int Coordinates { get; }

			public float FlowLimit { get; }

			public FlowDirection? FlowDirection { get; }

			public sbyte? FlowController { get; }

			public float? OutflowLimit { get; }

			private Modification(Vector3Int coordinates, float? flowLimit, FlowDirection? flowDirection, sbyte? flowController, float? outflowLimit)
			{
				Coordinates = coordinates;
				FlowLimit = flowLimit ?? float.MinValue;
				FlowDirection = flowDirection;
				FlowController = flowController;
				OutflowLimit = outflowLimit;
			}

			public static Modification CreateFlowModification(Vector3Int coordinates, float flowLimit)
			{
				return new Modification(coordinates, flowLimit, null, null, null);
			}

			public static Modification CreateDirectionModification(Vector3Int coordinates, FlowDirection flowDirection)
			{
				return new Modification(coordinates, null, flowDirection, null, null);
			}

			public static Modification CreateControllerModification(Vector3Int coordinates, sbyte flowController)
			{
				return new Modification(coordinates, null, null, flowController, null);
			}

			public static Modification CreateOutflowLimitModification(Vector3Int coordinates, float outflowLimit)
			{
				return new Modification(coordinates, null, null, null, outflowLimit);
			}
		}

		private readonly MapIndexService _mapIndexService;

		private readonly Queue<Modification> _modifications = new Queue<Modification>();

		private float[] _limitedValues;

		private int[] _limitedDirections;

		private sbyte[] _flowControllers;

		private float[] _outflowLimits;

		private int _stride;

		public ReadOnlyArray<int> LimitedDirections => new ReadOnlyArray<int>(_limitedDirections);

		public ReadOnlyArray<float> LimitedValues => new ReadOnlyArray<float>(_limitedValues);

		public ReadOnlyArray<sbyte> FlowControllers => new ReadOnlyArray<sbyte>(_flowControllers);

		public ReadOnlyArray<float> OutflowLimits => new ReadOnlyArray<float>(_outflowLimits);

		public event EventHandler<int> LimitedValueChanged;

		public FlowLimiterService(MapIndexService mapIndexService)
		{
			_mapIndexService = mapIndexService;
		}

		public void Load()
		{
			_stride = _mapIndexService.Stride;
			int num = _mapIndexService.TotalSize.z + 2;
			int num2 = _mapIndexService.VerticalStride * num;
			_limitedValues = new float[num2];
			_limitedDirections = new int[num2];
			_flowControllers = new sbyte[num2];
			_outflowLimits = new float[num2];
			for (int i = 0; i < num2; i++)
			{
				_limitedValues[i] = float.MinValue;
				_outflowLimits[i] = float.MaxValue;
			}
		}

		public void PostLoad()
		{
			ProcessModifications();
		}

		public void Tick()
		{
			ProcessModifications();
		}

		public void UpdateInflowLimiter(Vector3Int coordinates, float flowLimit)
		{
			_modifications.Enqueue(Modification.CreateFlowModification(coordinates, flowLimit));
		}

		public void RemoveInflowLimiter(Vector3Int coordinates)
		{
			_modifications.Enqueue(Modification.CreateFlowModification(coordinates, float.MinValue));
		}

		public void SetOutflowLimit(Vector3Int coordinates, float outflowLimit)
		{
			_modifications.Enqueue(Modification.CreateOutflowLimitModification(coordinates, outflowLimit));
		}

		public void RemoveOutflowLimit(Vector3Int coordinates)
		{
			_modifications.Enqueue(Modification.CreateOutflowLimitModification(coordinates, float.MaxValue));
		}

		public void AddDirectionLimiter(Vector3Int coordinates, FlowDirection flowDirection)
		{
			_modifications.Enqueue(Modification.CreateDirectionModification(coordinates, flowDirection));
		}

		public void RemoveDirectionLimiter(Vector3Int coordinates)
		{
			_modifications.Enqueue(Modification.CreateDirectionModification(coordinates, FlowDirection.Any));
		}

		public void SetControllerToDecreaseFlow(Vector3Int coordinates)
		{
			_modifications.Enqueue(Modification.CreateControllerModification(coordinates, -1));
		}

		public void SetControllerToIncreaseFlow(Vector3Int coordinates)
		{
			_modifications.Enqueue(Modification.CreateControllerModification(coordinates, 1));
		}

		public void RemoveFlowController(Vector3Int coordinates)
		{
			_modifications.Enqueue(Modification.CreateControllerModification(coordinates, 0));
		}

		private void ProcessModifications()
		{
			while (!_modifications.IsEmpty())
			{
				Modification modification = _modifications.Dequeue();
				ProcessModification(in modification);
			}
		}

		private void ProcessModification(in Modification modification)
		{
			int num = _mapIndexService.CoordinatesToIndex3D(modification.Coordinates);
			if (modification.FlowDirection.HasValue)
			{
				_limitedDirections[num] = FlowDirectionToIntDirection(modification.FlowDirection.Value);
				return;
			}
			if (modification.FlowController.HasValue)
			{
				_flowControllers[num] = modification.FlowController.Value;
				return;
			}
			if (modification.OutflowLimit.HasValue)
			{
				_outflowLimits[num] = modification.OutflowLimit.Value;
				return;
			}
			_limitedValues[num] = modification.FlowLimit;
			this.LimitedValueChanged?.Invoke(this, num);
		}

		private int FlowDirectionToIntDirection(FlowDirection flowDirection)
		{
			return flowDirection switch
			{
				FlowDirection.Any => 0, 
				FlowDirection.Bottom => -_stride, 
				FlowDirection.Left => -1, 
				FlowDirection.Top => _stride, 
				FlowDirection.Right => 1, 
				_ => throw new ArgumentOutOfRangeException("flowDirection", flowDirection, null), 
			};
		}
	}
}
