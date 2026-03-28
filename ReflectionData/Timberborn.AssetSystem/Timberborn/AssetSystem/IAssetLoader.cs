using System.Collections.Generic;
using UnityEngine;

namespace Timberborn.AssetSystem
{
	public interface IAssetLoader
	{
		T Load<T>(string path) where T : Object;

		T LoadSafe<T>(string path) where T : Object;

		IEnumerable<LoadedAsset<T>> LoadAll<T>(string path) where T : Object;

		void Reset();
	}
}
