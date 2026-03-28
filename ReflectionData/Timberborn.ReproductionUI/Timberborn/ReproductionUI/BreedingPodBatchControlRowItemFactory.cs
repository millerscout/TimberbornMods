using Timberborn.BaseComponentSystem;
using Timberborn.BatchControl;
using Timberborn.CoreUI;
using Timberborn.Localization;
using Timberborn.Reproduction;
using Timberborn.TooltipSystem;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.ReproductionUI
{
	public class BreedingPodBatchControlRowItemFactory
	{
		private static readonly string ProgressLocKey = "Breeding.Progress";

		private readonly VisualElementLoader _visualElementLoader;

		private readonly ITooltipRegistrar _tooltipRegistrar;

		private readonly ILoc _loc;

		public BreedingPodBatchControlRowItemFactory(VisualElementLoader visualElementLoader, ITooltipRegistrar tooltipRegistrar, ILoc loc)
		{
			_visualElementLoader = visualElementLoader;
			_tooltipRegistrar = tooltipRegistrar;
			_loc = loc;
		}

		public IBatchControlRowItem Create(BaseComponent entity)
		{
			BreedingPod breedingPod = entity.GetComponent<BreedingPod>();
			if ((bool)breedingPod)
			{
				string elementName = "Game/BatchControl/BreedingPodBatchControlRowItem";
				VisualElement visualElement = _visualElementLoader.LoadVisualElement(elementName);
				_tooltipRegistrar.Register(visualElement, () => GetTooltipText(breedingPod));
				return new BreedingPodBatchControlRowItem(visualElement, breedingPod, visualElement.Q<Label>("Progress"));
			}
			return null;
		}

		private string GetTooltipText(BreedingPod breedingPod)
		{
			return _loc.T(ProgressLocKey) + ": " + GetProgress(breedingPod);
		}

		private static string GetProgress(BreedingPod breedingPod)
		{
			return NumberFormatter.FormatAsPercentFloored(breedingPod.CalculateProgress());
		}
	}
}
