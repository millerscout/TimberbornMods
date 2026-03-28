using Timberborn.BaseComponentSystem;
using Timberborn.CoreUI;
using Timberborn.EntityPanelSystem;
using Timberborn.InventorySystemUI;
using Timberborn.Reproduction;
using UnityEngine.UIElements;

namespace Timberborn.ReproductionUI
{
	public class BreedingPodFragment : IEntityPanelFragment
	{
		private readonly VisualElementLoader _visualElementLoader;

		private readonly InventoryFragmentBuilderFactory _inventoryFragmentBuilderFactory;

		private InventoryFragment _inventoryFragment;

		private BreedingPod _breedingPod;

		private VisualElement _root;

		private Timberborn.CoreUI.ProgressBar _progressBar;

		public BreedingPodFragment(VisualElementLoader visualElementLoader, InventoryFragmentBuilderFactory inventoryFragmentBuilderFactory)
		{
			_visualElementLoader = visualElementLoader;
			_inventoryFragmentBuilderFactory = inventoryFragmentBuilderFactory;
		}

		public VisualElement InitializeFragment()
		{
			_root = _visualElementLoader.LoadVisualElement("Game/EntityPanel/BreedingPodFragment");
			_progressBar = _root.Q<Timberborn.CoreUI.ProgressBar>("ProgressBar");
			_root.ToggleDisplayStyle(visible: false);
			VisualElement root = _root.Q<VisualElement>("BreedingPodInventoryFragment");
			_inventoryFragment = _inventoryFragmentBuilderFactory.CreateBuilder(root).ShowRowLimit().ShowEmptyRows()
				.Build();
			return _root;
		}

		public void ShowFragment(BaseComponent entity)
		{
			_breedingPod = entity.GetComponent<BreedingPod>();
			if ((bool)_breedingPod)
			{
				_inventoryFragment.ShowFragment(_breedingPod.Inventory);
			}
		}

		public void ClearFragment()
		{
			_breedingPod = null;
			_inventoryFragment.ClearFragment();
			UpdateFragment();
		}

		public void UpdateFragment()
		{
			if ((bool)_breedingPod && _breedingPod.Enabled)
			{
				_progressBar.SetProgress(_breedingPod.CalculateProgress());
				_inventoryFragment.UpdateFragment();
				_root.ToggleDisplayStyle(visible: true);
			}
			else
			{
				_root.ToggleDisplayStyle(visible: false);
			}
		}
	}
}
