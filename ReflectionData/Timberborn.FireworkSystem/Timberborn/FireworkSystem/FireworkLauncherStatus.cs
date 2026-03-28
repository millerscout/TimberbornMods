using Timberborn.BaseComponentSystem;
using Timberborn.BlockSystem;
using Timberborn.GameDistricts;
using Timberborn.Hauling;
using Timberborn.Workshops;

namespace Timberborn.FireworkSystem
{
	public class FireworkLauncherStatus : BaseComponent, IAwakableComponent, IFinishedStateListener
	{
		private FireworkLauncher _fireworkLauncher;

		private DistrictBuilding _districtBuilding;

		private NoHaulingPostStatus _noHaulingPostStatus;

		private LackOfResourcesStatus _lackOfResourcesStatus;

		public void Awake()
		{
			_fireworkLauncher = GetComponent<FireworkLauncher>();
			_districtBuilding = GetComponent<DistrictBuilding>();
			_noHaulingPostStatus = GetComponent<NoHaulingPostStatus>();
			_lackOfResourcesStatus = GetComponent<LackOfResourcesStatus>();
		}

		public void OnEnterFinishedState()
		{
			_lackOfResourcesStatus.Initialize(CanShowLackOfResourcesStatus);
			_noHaulingPostStatus.Initialize(() => true);
		}

		public void OnExitFinishedState()
		{
			_lackOfResourcesStatus.Disable();
			_noHaulingPostStatus.Disable();
		}

		private bool CanShowLackOfResourcesStatus()
		{
			if (_fireworkLauncher.Inventory?.IsEmpty ?? false)
			{
				return _districtBuilding.District;
			}
			return false;
		}
	}
}
