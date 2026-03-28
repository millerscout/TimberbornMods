using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Timberborn.BlueprintSystem;
using Timberborn.Common;
using Timberborn.SingletonSystem;

namespace Timberborn.NeedSpecs
{
	public class NeedGroupSpecService : ILoadableSingleton
	{
		private readonly ISpecService _specService;

		private ImmutableArray<NeedGroupSpec> _needGroups;

		public IEnumerable<NeedGroupSpec> NeedGroups => _needGroups.AsReadOnlyEnumerable();

		public NeedGroupSpecService(ISpecService specService)
		{
			_specService = specService;
		}

		public void Load()
		{
			_needGroups = (from needGroupSpec in _specService.GetSpecs<NeedGroupSpec>()
				orderby needGroupSpec.Order
				select needGroupSpec).ToImmutableArray();
		}

		public bool IsValidGroup(string needGroupId)
		{
			return _needGroups.Any((NeedGroupSpec spec) => spec.Id == needGroupId);
		}

		public NeedGroupSpec GetNeedGroup(string needGroupId)
		{
			NeedGroupSpec needGroupSpec2 = _needGroups.SingleOrDefault((NeedGroupSpec needGroupSpec) => needGroupSpec.Id == needGroupId);
			if (needGroupSpec2 != null)
			{
				return needGroupSpec2;
			}
			throw new InvalidOperationException("NeedGroupSpec with id " + needGroupId + " not found or multiple specs found");
		}
	}
}
