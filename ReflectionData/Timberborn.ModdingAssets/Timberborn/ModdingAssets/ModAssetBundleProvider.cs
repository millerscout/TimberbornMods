using System.Collections.Generic;
using Timberborn.AssetSystem;
using Timberborn.SingletonSystem;
using UnityEngine;

namespace Timberborn.ModdingAssets
{
	internal class ModAssetBundleProvider : ILoadableSingleton, IAssetProvider
	{
		private readonly struct AssetBundleAssetPath
		{
			private readonly AssetBundle _assetBundle;

			private readonly string _assetPath;

			private readonly int _order;

			public AssetBundleAssetPath(AssetBundle assetBundle, string assetPath, int order)
			{
				_assetBundle = assetBundle;
				_assetPath = assetPath;
				_order = order;
			}

			public bool TryLoad<T>(out OrderedAsset orderedAsset) where T : Object
			{
				T val = _assetBundle.LoadAsset<T>(_assetPath);
				if (!(Object)val && typeof(Component).IsAssignableFrom(typeof(T)))
				{
					GameObject gameObject = _assetBundle.LoadAsset<GameObject>(_assetPath);
					if ((bool)gameObject)
					{
						val = gameObject.GetComponent<T>();
					}
				}
				orderedAsset = new OrderedAsset(_order, val);
				return (Object)val;
			}
		}

		private readonly ModAssetBundleLoader _modAssetBundleLoader;

		private readonly Dictionary<string, List<AssetBundleAssetPath>> _assetPaths = new Dictionary<string, List<AssetBundleAssetPath>>();

		public bool IsBuiltIn => false;

		public ModAssetBundleProvider(ModAssetBundleLoader modAssetBundleLoader)
		{
			_modAssetBundleLoader = modAssetBundleLoader;
		}

		public void Load()
		{
			CachePaths();
		}

		public bool TryLoad<T>(string path, out OrderedAsset orderedAsset) where T : Object
		{
			if (_assetPaths.TryGetValue(path, out var value))
			{
				List<AssetBundleAssetPath> list = value;
				if (list[list.Count - 1].TryLoad<T>(out orderedAsset))
				{
					return true;
				}
			}
			orderedAsset = default(OrderedAsset);
			return false;
		}

		public IEnumerable<OrderedAsset> LoadAll<T>(string path) where T : Object
		{
			foreach (KeyValuePair<string, List<AssetBundleAssetPath>> assetPath in _assetPaths)
			{
				assetPath.Deconstruct(out var key, out var value);
				string text = key;
				List<AssetBundleAssetPath> list = value;
				if (!text.StartsWith(path))
				{
					continue;
				}
				foreach (AssetBundleAssetPath item in list)
				{
					if (item.TryLoad<T>(out var orderedAsset))
					{
						yield return orderedAsset;
					}
				}
			}
		}

		public void Reset()
		{
			_assetPaths.Clear();
			_modAssetBundleLoader.Reload();
			CachePaths();
		}

		private void CachePaths()
		{
			foreach (OrderedAssetBundle loadedAssetBundle in _modAssetBundleLoader.LoadedAssetBundles)
			{
				string[] allAssetNames = loadedAssetBundle.AssetBundle.GetAllAssetNames();
				foreach (string assetPath in allAssetNames)
				{
					string key = AssetPathHelper.NormalizeAssetPath(assetPath);
					if (!_assetPaths.ContainsKey(key))
					{
						_assetPaths[key] = new List<AssetBundleAssetPath>();
					}
					_assetPaths[key].Add(new AssetBundleAssetPath(loadedAssetBundle.AssetBundle, assetPath, loadedAssetBundle.Order));
				}
			}
		}
	}
}
