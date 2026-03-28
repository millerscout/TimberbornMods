using Timberborn.BaseComponentSystem;
using Timberborn.BatchControl;
using Timberborn.CoreUI;
using Timberborn.Localization;
using Timberborn.TooltipSystem;
using Timberborn.UIFormatters;
using Timberborn.Workshops;
using UnityEngine.UIElements;

namespace Timberborn.WorkshopsUI
{
	public class ProductivityBatchControlRowItemFactory
	{
		private static readonly string ProductivityLocKey = "Work.Productivity";

		private readonly VisualElementLoader _visualElementLoader;

		private readonly ITooltipRegistrar _tooltipRegistrar;

		private readonly ILoc _loc;

		public ProductivityBatchControlRowItemFactory(VisualElementLoader visualElementLoader, ITooltipRegistrar tooltipRegistrar, ILoc loc)
		{
			_visualElementLoader = visualElementLoader;
			_tooltipRegistrar = tooltipRegistrar;
			_loc = loc;
		}

		public IBatchControlRowItem Create(BaseComponent entity)
		{
			WorkshopProductivityCounter workshopProductivityCounter = entity.GetComponent<WorkshopProductivityCounter>();
			if (workshopProductivityCounter != null)
			{
				string elementName = "Game/BatchControl/ProductivityBatchControlRowItem";
				VisualElement visualElement = _visualElementLoader.LoadVisualElement(elementName);
				Image productivity = visualElement.Q<Image>("Productivity");
				_tooltipRegistrar.Register(visualElement, () => GetTooltipText(workshopProductivityCounter));
				return new ProductivityBatchControlRowItem(visualElement, productivity, workshopProductivityCounter);
			}
			return null;
		}

		private string GetTooltipText(WorkshopProductivityCounter workshopProductivityCounter)
		{
			string text = NumberFormatter.FormatAsPercentCeiled(workshopProductivityCounter.CalculateProductivity());
			return _loc.T(ProductivityLocKey) + " " + text;
		}
	}
}
