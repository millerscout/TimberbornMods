using Timberborn.BatchControl;
using Timberborn.DeteriorationSystem;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.DeteriorationSystemUI
{
	internal class DeteriorableBatchControlRowItem : IBatchControlRowItem, IUpdatableBatchControlRowItem
	{
		private readonly Label _progressLabel;

		private readonly Deteriorable _deteriorable;

		public VisualElement Root { get; }

		public DeteriorableBatchControlRowItem(VisualElement root, Label progressLabel, Deteriorable deteriorable)
		{
			Root = root;
			_progressLabel = progressLabel;
			_deteriorable = deteriorable;
		}

		public void UpdateRowItem()
		{
			_progressLabel.text = NumberFormatter.FormatAsPercentFloored(_deteriorable.DeteriorationProgress);
		}
	}
}
