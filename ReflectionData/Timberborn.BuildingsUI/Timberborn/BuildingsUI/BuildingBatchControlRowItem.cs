using Timberborn.BaseComponentSystem;
using Timberborn.BatchControl;
using Timberborn.Buildings;
using Timberborn.BuildingsNavigation;
using Timberborn.ConstructionSites;
using Timberborn.CoreUI;
using Timberborn.GameDistricts;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.BuildingsUI
{
	internal class BuildingBatchControlRowItem : IBatchControlRowItem, IUpdatableBatchControlRowItem
	{
		private readonly DistanceToColorConverter _distanceToColorConverter;

		private readonly DistrictBuildingDistance _districtBuildingDistance;

		private readonly VisualElement _pausableWrapper;

		private readonly Toggle _pausableToggle;

		private readonly PausableBuilding _pausableBuilding;

		private readonly ConstructionSite _constructionSite;

		private readonly VisualElement _constructionWrapper;

		private readonly Label _constructionProgressLabel;

		private readonly Label _distanceLabel;

		private readonly VisualElement _constructionProgressBar;

		public VisualElement Root { get; }

		public BuildingBatchControlRowItem(DistanceToColorConverter distanceToColorConverter, VisualElement root, DistrictBuildingDistance districtBuildingDistance, Label distanceLabel, VisualElement pausableWrapper, Toggle pausableToggle, PausableBuilding pausableBuilding, ConstructionSite constructionSite, VisualElement constructionWrapper, Label constructionProgressLabel, VisualElement constructionProgressBar)
		{
			_distanceToColorConverter = distanceToColorConverter;
			Root = root;
			_districtBuildingDistance = districtBuildingDistance;
			_distanceLabel = distanceLabel;
			_pausableWrapper = pausableWrapper;
			_pausableToggle = pausableToggle;
			_pausableBuilding = pausableBuilding;
			_constructionSite = constructionSite;
			_constructionWrapper = constructionWrapper;
			_constructionProgressLabel = constructionProgressLabel;
			_constructionProgressBar = constructionProgressBar;
		}

		public void UpdateRowItem()
		{
			UpdatePausable();
			UpdateDistance();
			UpdateConstructionSiteInfo();
		}

		private void UpdatePausable()
		{
			if ((bool)_pausableBuilding && _pausableBuilding.IsPausable())
			{
				_pausableToggle.SetValueWithoutNotify(!_pausableBuilding.Paused);
				_pausableWrapper.ToggleDisplayStyle(visible: true);
			}
			else
			{
				_pausableWrapper.ToggleDisplayStyle(visible: false);
			}
		}

		private void UpdateDistance()
		{
			if ((bool)_districtBuildingDistance && _districtBuildingDistance.TryGetDistanceToDistrict(out var distance))
			{
				_distanceLabel.text = NumberFormatter.Format(distance);
				_distanceLabel.style.color = _distanceToColorConverter.DistanceToColor(distance);
				_distanceLabel.parent.ToggleDisplayStyle(visible: true);
			}
			else
			{
				_distanceLabel.parent.ToggleDisplayStyle(visible: false);
			}
		}

		private void UpdateConstructionSiteInfo()
		{
			if (((BaseComponent)(object)_constructionSite).Enabled)
			{
				float buildTimeProgress = _constructionSite.BuildTimeProgress;
				string text = NumberFormatter.FormatAsPercentFloored(buildTimeProgress);
				_constructionProgressLabel.text = text;
				_constructionProgressBar.style.width = new StyleLength(Length.Percent(buildTimeProgress * 100f));
				_constructionWrapper.ToggleDisplayStyle(visible: true);
			}
			else
			{
				_constructionWrapper.ToggleDisplayStyle(visible: false);
			}
		}
	}
}
