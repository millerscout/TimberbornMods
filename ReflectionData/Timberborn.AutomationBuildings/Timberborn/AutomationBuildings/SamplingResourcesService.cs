using System.Collections.Generic;
using Timberborn.Automation;
using Timberborn.Common;
using Timberborn.GameDistricts;
using Timberborn.ResourceCountingSystem;
using Timberborn.SingletonSystem;

namespace Timberborn.AutomationBuildings
{
	internal class SamplingResourcesService : ISamplingSingleton, IPostLoadableSingleton
	{
		private readonly DistrictCenterRegistry _districtCenterRegistry;

		private readonly ResourceCountingService _resourceCountingService;

		private readonly Dictionary<DistrictCenter, DistrictResourceCounter> _districtResourceCounters = new Dictionary<DistrictCenter, DistrictResourceCounter>();

		private readonly Dictionary<DistrictCenter, DistrictResourceCounter> _oldDistrictResourceCounters = new Dictionary<DistrictCenter, DistrictResourceCounter>();

		private readonly DistrictResourceCounter _emptyDistrictResourcesCounter = new DistrictResourceCounter();

		public SamplingResourcesService(DistrictCenterRegistry districtCenterRegistry, ResourceCountingService resourceCountingService)
		{
			_districtCenterRegistry = districtCenterRegistry;
			_resourceCountingService = resourceCountingService;
		}

		public void PostLoad()
		{
			foreach (DistrictCenter finishedDistrictCenter in _districtCenterRegistry.FinishedDistrictCenters)
			{
				_resourceCountingService.GetDistrictResourceCounter(finishedDistrictCenter).UpdateCounters();
			}
			Sample();
		}

		public void Sample()
		{
			_oldDistrictResourceCounters.AddRange(_districtResourceCounters);
			_districtResourceCounters.Clear();
			ReadOnlyList<DistrictCenter> finishedDistrictCenters = _districtCenterRegistry.FinishedDistrictCenters;
			for (int i = 0; i < finishedDistrictCenters.Count; i++)
			{
				DistrictCenter districtCenter = finishedDistrictCenters[i];
				DistrictResourceCounter value;
				DistrictResourceCounter value2 = (_oldDistrictResourceCounters.TryGetValue(districtCenter, out value) ? value : _resourceCountingService.GetDistrictResourceCounter(districtCenter));
				_districtResourceCounters.Add(districtCenter, value2);
			}
			_oldDistrictResourceCounters.Clear();
		}

		public DistrictResourceCounter GetDistrictCounter(DistrictCenter districtCenter)
		{
			if (districtCenter == null)
			{
				return _emptyDistrictResourcesCounter;
			}
			return _districtResourceCounters.GetValueOrDefault(districtCenter, _emptyDistrictResourcesCounter);
		}
	}
}
