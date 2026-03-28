using System;
using System.Collections.Generic;
using System.Linq;
using Timberborn.BlockObjectPickingSystem;
using Timberborn.BlockSystem;
using UnityEngine;

namespace Timberborn.AreaSelectionSystem
{
	public class AreaBlockObjectPicker
	{
		public delegate void Callback(IEnumerable<BlockObject> blockObjects, Vector3Int start, Vector3Int end, bool selectionStarted, bool selectingArea);

		private readonly AreaSelectionController _areaSelectionController;

		private readonly AreaSelector _areaSelector;

		private readonly BlockObjectPicker _blockObjectPicker;

		private readonly BlockObjectPickingMode _pickingMode;

		private SelectionStart? _selectionStart;

		internal AreaBlockObjectPicker(AreaSelectionController areaSelectionController, AreaSelector areaSelector, BlockObjectPicker blockObjectPicker, BlockObjectPickingMode pickingMode)
		{
			_areaSelectionController = areaSelectionController;
			_areaSelector = areaSelector;
			_blockObjectPicker = blockObjectPicker;
			_pickingMode = pickingMode;
		}

		public bool PickBlockObjects<T>(Callback previewCallback, Callback actionCallback, Action showNoneCallback, Func<BlockObject, bool> blockObjectFilter = null)
		{
			return _areaSelectionController.ProcessInput(delegate(Ray startRay, Ray endRay, bool selectionStarted)
			{
				var (blockObjects2, start2, end2, selectingArea2) = PickBlockObjects<T>(startRay, endRay, blockObjectFilter);
				previewCallback(blockObjects2, start2, end2, selectionStarted, selectingArea2);
			}, delegate(Ray startRay, Ray endRay, bool selectionStarted)
			{
				var (blockObjects, start, end, selectingArea) = PickBlockObjects<T>(startRay, endRay, blockObjectFilter);
				actionCallback(blockObjects, start, end, selectionStarted, selectingArea);
			}, showNoneCallback);
		}

		public void Reset()
		{
			_areaSelectionController.Reset();
			_selectionStart = null;
		}

		private (IEnumerable<BlockObject> blockObjects, Vector3Int start, Vector3Int end, bool selectingArea) PickBlockObjects<T>(Ray startRay, Ray endRay, Func<BlockObject, bool> blockObjectFilter)
		{
			bool flag = !startRay.Equals(endRay);
			SelectionStart? selectionStart = GetSelectionStart<T>(startRay, flag);
			if (selectionStart.HasValue)
			{
				SelectionStart valueOrDefault = selectionStart.GetValueOrDefault();
				Vector3Int coordinates = valueOrDefault.Coordinates;
				Vector3Int vector3Int = (flag ? _areaSelector.GetSelectionEnd(valueOrDefault, endRay) : coordinates);
				return (from blockObject in _blockObjectPicker.PickBlockObjects(valueOrDefault, vector3Int, _pickingMode, blockObjectFilter, flag)
					where blockObject.GetComponent<T>() != null
					select blockObject, coordinates, vector3Int, flag);
			}
			return (Enumerable.Empty<BlockObject>(), default(Vector3Int), default(Vector3Int), false);
		}

		private SelectionStart? GetSelectionStart<T>(Ray startRay, bool selectingArea)
		{
			if (!selectingArea)
			{
				_selectionStart = _areaSelector.GetSelectionStart<T>(startRay);
			}
			return _selectionStart;
		}
	}
}
