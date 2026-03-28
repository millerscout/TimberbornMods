using Timberborn.BaseComponentSystem;
using Timberborn.BeaverContaminationSystem;
using Timberborn.Carrying;
using Timberborn.CoreUI;
using Timberborn.EntityPanelSystem;
using Timberborn.Goods;
using Timberborn.GoodsUI;
using Timberborn.Localization;
using UnityEngine.UIElements;

namespace Timberborn.CarryingUI
{
	internal class GoodCarrierFragment : IEntityPanelFragment
	{
		private static readonly string CarryLocKey = "Carrying.Carry";

		private static readonly string NothingLocKey = "Carrying.Nothing";

		private readonly VisualElementLoader _visualElementLoader;

		private readonly GoodDescriber _goodDescriber;

		private readonly ILoc _loc;

		private readonly IGoodService _goodService;

		private GoodCarrier _goodCarrier;

		private Contaminable _contaminable;

		private Label _carryText;

		private VisualElement _root;

		public GoodCarrierFragment(VisualElementLoader visualElementLoader, GoodDescriber goodDescriber, ILoc loc, IGoodService goodService)
		{
			_visualElementLoader = visualElementLoader;
			_goodDescriber = goodDescriber;
			_loc = loc;
			_goodService = goodService;
		}

		public VisualElement InitializeFragment()
		{
			_root = _visualElementLoader.LoadVisualElement("Game/EntityPanel/GoodCarrierFragment");
			_carryText = _root.Q<Label>("GoodCarrierFragment");
			_root.ToggleDisplayStyle(visible: false);
			return _root;
		}

		public void ShowFragment(BaseComponent entity)
		{
			_goodCarrier = entity.GetComponent<GoodCarrier>();
			_contaminable = entity.GetComponent<Contaminable>();
		}

		public void ClearFragment()
		{
			_root.ToggleDisplayStyle(visible: false);
			_goodCarrier = null;
		}

		public void UpdateFragment()
		{
			if (!_goodCarrier)
			{
				return;
			}
			GoodAmount carriedGoods = _goodCarrier.CarriedGoods;
			int liftingCapacity = _goodCarrier.LiftingCapacity;
			_root.ToggleDisplayStyle(visible: true);
			if (carriedGoods.Amount > 0)
			{
				int weight = _goodService.GetGood(carriedGoods.GoodId).Weight;
				int param = carriedGoods.Amount * weight;
				string param2 = _goodDescriber.Describe(carriedGoods);
				_carryText.text = _loc.T(CarryLocKey, param2, param, liftingCapacity);
				return;
			}
			Contaminable contaminable = _contaminable;
			if (contaminable != null && contaminable.IsContaminated)
			{
				_root.ToggleDisplayStyle(visible: false);
				return;
			}
			string param3 = _loc.T(NothingLocKey);
			_carryText.text = _loc.T(CarryLocKey, param3, 0, liftingCapacity);
		}
	}
}
