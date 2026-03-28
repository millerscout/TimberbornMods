using Timberborn.CoreUI;
using Timberborn.ResourceCountingSystem;
using Timberborn.ResourceCountingSystemUI;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.TopBarSystem
{
	public class TopBarCounterRow : ITopBarCounter
	{
		private readonly ContextualResourceCountingService _contextualResourceCountingService;

		private readonly VisualElement _root;

		private readonly string _goodId;

		private readonly Label _counter;

		private readonly VisualElement _fillGauge;

		private readonly bool _alwaysVisible;

		private int _previousAmount = -1;

		public TopBarCounterRow(ContextualResourceCountingService contextualResourceCountingService, string goodId, VisualElement root, Label counter, VisualElement fillGauge, bool alwaysVisible = false)
		{
			_contextualResourceCountingService = contextualResourceCountingService;
			_root = root;
			_goodId = goodId;
			_counter = counter;
			_fillGauge = fillGauge;
			_alwaysVisible = alwaysVisible;
		}

		public void UpdateValues()
		{
			UpdateAndGetStock();
		}

		public int UpdateAndGetStock()
		{
			ResourceCount contextualResourceCount = _contextualResourceCountingService.GetContextualResourceCount(_goodId);
			_fillGauge.SetHeightAsPercent(contextualResourceCount.FillRate);
			int availableStock = contextualResourceCount.AvailableStock;
			if (_previousAmount != availableStock)
			{
				_counter.text = NumberFormatter.Format(availableStock);
				_previousAmount = availableStock;
			}
			_root.ToggleDisplayStyle(_alwaysVisible || contextualResourceCount.AllStock > 0);
			return availableStock;
		}
	}
}
