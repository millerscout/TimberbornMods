using Timberborn.BatchControl;
using Timberborn.Beavers;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.BeaversUI
{
	internal class AdulthoodBatchControlRowItem : IBatchControlRowItem, IUpdatableBatchControlRowItem
	{
		private readonly Label _progressLabel;

		private readonly Child _child;

		public VisualElement Root { get; }

		public AdulthoodBatchControlRowItem(VisualElement root, Label progressLabel, Child child)
		{
			Root = root;
			_progressLabel = progressLabel;
			_child = child;
		}

		public void UpdateRowItem()
		{
			_progressLabel.text = NumberFormatter.FormatAsPercentFloored(_child.GrowthProgress);
		}
	}
}
