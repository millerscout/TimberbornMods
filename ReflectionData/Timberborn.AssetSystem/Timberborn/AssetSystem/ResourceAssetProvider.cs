using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Timberborn.AssetSystem
{
	public class ResourceAssetProvider : IAssetProvider
	{
		private static readonly int ResourceAssetOrder = -1;

		public bool IsBuiltIn => true;

		public bool TryLoad<T>(string path, out OrderedAsset orderedAsset) where T : Object
		{
			orderedAsset = new OrderedAsset(ResourceAssetOrder, Resources.Load<T>(path));
			return orderedAsset.Asset != null;
		}

		public IEnumerable<OrderedAsset> LoadAll<T>(string path) where T : Object
		{
			return from asset in Resources.LoadAll<T>(path)
				select new OrderedAsset(ResourceAssetOrder, asset);
		}

		public void Reset()
		{
		}
	}
}
