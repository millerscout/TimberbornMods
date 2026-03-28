using System.Collections.Generic;
using UnityEngine;

namespace Timberborn.AssetSystem
{
	public interface IAssetProvider
	{
		bool IsBuiltIn { get; }

		bool TryLoad<T>(string path, out OrderedAsset orderedAsset) where T : Object;

		IEnumerable<OrderedAsset> LoadAll<T>(string path) where T : Object;

		void Reset();
	}
}
