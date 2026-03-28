using Timberborn.BaseComponentSystem;
using Timberborn.BatchControl;
using Timberborn.CoreUI;
using Timberborn.DeteriorationSystem;
using Timberborn.Localization;
using Timberborn.TooltipSystem;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.DeteriorationSystemUI
{
	public class DeteriorableBatchControlRowItemFactory
	{
		private static readonly string DurabilityLocKey = "Bot.Durability";

		private readonly VisualElementLoader _visualElementLoader;

		private readonly ITooltipRegistrar _tooltipRegistrar;

		private readonly ILoc _loc;

		public DeteriorableBatchControlRowItemFactory(VisualElementLoader visualElementLoader, ITooltipRegistrar tooltipRegistrar, ILoc loc)
		{
			_visualElementLoader = visualElementLoader;
			_tooltipRegistrar = tooltipRegistrar;
			_loc = loc;
		}

		public IBatchControlRowItem Create(BaseComponent entity)
		{
			Deteriorable deteriorable = entity.GetComponent<Deteriorable>();
			if (deteriorable != null)
			{
				string elementName = "Game/BatchControl/DeteriorableBatchControlRowItem";
				VisualElement visualElement = _visualElementLoader.LoadVisualElement(elementName);
				Label progressLabel = visualElement.Q<Label>("Progress");
				_tooltipRegistrar.Register(visualElement, () => GetTooltipText(deteriorable));
				return new DeteriorableBatchControlRowItem(visualElement, progressLabel, deteriorable);
			}
			return null;
		}

		private string GetTooltipText(Deteriorable deteriorable)
		{
			string text = NumberFormatter.FormatAsPercentFloored(deteriorable.DeteriorationProgress);
			return _loc.T(DurabilityLocKey) + ": " + text;
		}
	}
}
