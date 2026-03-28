using System;
using System.Collections.Generic;
using System.Linq;
using Timberborn.BlueprintSystem;
using Timberborn.Common;
using Timberborn.SingletonSystem;
using UnityEngine;

namespace Timberborn.Goods
{
	public class GoodsGroupSpecService : ILoadableSingleton
	{
		private readonly ISpecService _specService;

		private readonly IGoodService _goodService;

		private readonly List<GoodGroupSpec> _goodGroupSpecs = new List<GoodGroupSpec>();

		public ReadOnlyList<GoodGroupSpec> GoodGroupSpecs => _goodGroupSpecs.AsReadOnlyList();

		public GoodsGroupSpecService(ISpecService specService, IGoodService goodService)
		{
			_specService = specService;
			_goodService = goodService;
		}

		public void Load()
		{
			foreach (GoodGroupSpec item in from goodGroupSpec in _specService.GetSpecs<GoodGroupSpec>()
				orderby goodGroupSpec.Order
				select goodGroupSpec)
			{
				if (_goodService.GetGoodsForGroup(item.Id).Any())
				{
					_goodGroupSpecs.Add(item);
				}
				else
				{
					Debug.LogWarning("Good group " + item.Id + " has no goods");
				}
			}
		}

		public GoodGroupSpec GetSpec(string goodGroupId)
		{
			GoodGroupSpec goodGroupSpec2 = _goodGroupSpecs.SingleOrDefault((GoodGroupSpec goodGroupSpec) => goodGroupSpec.Id == goodGroupId);
			if (goodGroupSpec2 != null)
			{
				return goodGroupSpec2;
			}
			throw new InvalidOperationException("Good group spec with id " + goodGroupId + " not found or multiple specs found");
		}
	}
}
