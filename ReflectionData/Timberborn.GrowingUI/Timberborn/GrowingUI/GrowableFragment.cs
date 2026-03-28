using System;
using Timberborn.BaseComponentSystem;
using Timberborn.CoreUI;
using Timberborn.Cutting;
using Timberborn.EntityPanelSystem;
using Timberborn.Goods;
using Timberborn.GoodsUI;
using Timberborn.Growing;
using Timberborn.Localization;
using Timberborn.NaturalResourcesLifecycle;
using Timberborn.TooltipSystem;
using Timberborn.UIFormatters;
using Timberborn.YieldingUI;
using UnityEngine.UIElements;

namespace Timberborn.GrowingUI
{
	public class GrowableFragment : IEntityPanelFragment
	{
		private static readonly string GrowingTimeLocKey = "Growing.Time";

		private static readonly string IconClass = "resource-yield__icon--calendar";

		private static readonly string NoYieldClass = "resource-yield__no-yield";

		private readonly VisualElementLoader _visualElementLoader;

		private readonly ILoc _loc;

		private readonly YieldTooltipFactory _yieldTooltipFactory;

		private readonly ITooltipRegistrar _tooltipRegistrar;

		private readonly GoodDescriber _goodDescriber;

		private VisualElement _root;

		private Label _progressText;

		private Label _growthTime;

		private Label _yieldAmount;

		private Image _yieldIcon;

		private Growable _growable;

		private Cuttable _cuttable;

		private LivingNaturalResource _livingNaturalResource;

		private readonly Phrase _growthTimePhrase = Phrase.New().Format<string>(UnitFormatter.FormatDays);

		private string GrowthTime => _growable.GrowthTimeInDays.ToString("F0");

		public GrowableFragment(VisualElementLoader visualElementLoader, ILoc loc, YieldTooltipFactory yieldTooltipFactory, ITooltipRegistrar tooltipRegistrar, GoodDescriber goodDescriber)
		{
			_visualElementLoader = visualElementLoader;
			_loc = loc;
			_yieldTooltipFactory = yieldTooltipFactory;
			_tooltipRegistrar = tooltipRegistrar;
			_goodDescriber = goodDescriber;
		}

		public VisualElement InitializeFragment()
		{
			_root = _visualElementLoader.LoadVisualElement("Game/EntityPanel/ResourceYieldFragment");
			_progressText = _root.Q<Label>("ProgressText");
			_growthTime = _root.Q<Label>("GrowthTime");
			_yieldAmount = _root.Q<Label>("YieldAmount");
			_yieldIcon = _root.Q<Image>("YieldIcon");
			_root.Q<VisualElement>("Calendar").AddToClassList(IconClass);
			_tooltipRegistrar.Register(_root, (Func<VisualElement>)GetTooltip);
			_root.ToggleDisplayStyle(visible: false);
			return _root;
		}

		public void ShowFragment(BaseComponent entity)
		{
			_growable = entity.GetComponent<Growable>();
			if ((bool)_growable)
			{
				_cuttable = _growable.GetComponent<Cuttable>();
				_livingNaturalResource = _growable.GetComponent<LivingNaturalResource>();
			}
		}

		public void ClearFragment()
		{
			_growable = null;
			_cuttable = null;
			_livingNaturalResource = null;
		}

		public void UpdateFragment()
		{
			bool flag = (bool)_growable && (!_livingNaturalResource.IsDead || ((bool)_cuttable && _cuttable.Yielder.IsYielding));
			_root.ToggleDisplayStyle(flag);
			if (flag)
			{
				_progressText.text = NumberFormatter.FormatAsPercentFloored(_growable.GrowthProgress);
				_growthTime.text = _loc.T(_growthTimePhrase, GrowthTime);
				if ((bool)_cuttable)
				{
					GoodAmountSpec yield = _cuttable.YielderSpec.Yield;
					_yieldAmount.text = yield.Amount.ToString();
					_yieldIcon.sprite = _goodDescriber.GetIcon(yield.Id);
				}
				else
				{
					_yieldIcon.sprite = null;
				}
				_yieldAmount.ToggleDisplayStyle(_cuttable);
				_yieldIcon.EnableInClassList(NoYieldClass, !_cuttable);
			}
		}

		private VisualElement GetTooltip()
		{
			if ((bool)_cuttable)
			{
				return _yieldTooltipFactory.Create(_cuttable.YielderSpec, GrowthTime);
			}
			Label label = new Label(_loc.T(GrowingTimeLocKey, GrowthTime));
			label.AddToClassList("game-text-normal");
			label.AddToClassList("text--grey");
			return label;
		}
	}
}
