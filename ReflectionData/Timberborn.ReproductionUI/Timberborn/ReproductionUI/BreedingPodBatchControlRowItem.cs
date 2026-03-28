using Timberborn.BatchControl;
using Timberborn.CoreUI;
using Timberborn.Reproduction;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.ReproductionUI
{
	internal class BreedingPodBatchControlRowItem : IUpdatableBatchControlRowItem, IBatchControlRowItem, IFinishableBatchControlRowItem
	{
		private readonly BreedingPod _breedingPod;

		private readonly Label _progressLabel;

		public VisualElement Root { get; }

		public BreedingPodBatchControlRowItem(VisualElement root, BreedingPod breedingPod, Label progressLabel)
		{
			Root = root;
			_breedingPod = breedingPod;
			_progressLabel = progressLabel;
		}

		public void UpdateRowItem()
		{
			_progressLabel.text = NumberFormatter.FormatAsPercentFloored(_breedingPod.CalculateProgress());
		}

		public void SetFinishedState(bool isFinished)
		{
			Root.ToggleDisplayStyle(isFinished);
		}
	}
}
