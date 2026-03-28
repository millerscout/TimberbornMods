using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Timberborn.AssetSystem;
using Timberborn.Common;
using Timberborn.SerializationSystem;
using Timberborn.SingletonSystem;

namespace Timberborn.BlueprintSystem
{
	internal class SpecService : ISpecService, ILoadableSingleton
	{
		private readonly SerializedObjectReaderWriter _serializedObjectReaderWriter;

		private readonly BlueprintDeserializer _blueprintDeserializer;

		private readonly BlueprintFileBundleLoader _blueprintFileBundleLoader;

		private readonly BlueprintSourceService _blueprintSourceService;

		private readonly ImmutableArray<IBlueprintModifierProvider> _blueprintModifierProviders;

		private readonly Dictionary<string, Lazy<Blueprint>> _cachedBlueprintsByPath = new Dictionary<string, Lazy<Blueprint>>();

		private readonly Dictionary<Type, List<Lazy<Blueprint>>> _cachedBlueprintsBySpecs = new Dictionary<Type, List<Lazy<Blueprint>>>();

		public SpecService(SerializedObjectReaderWriter serializedObjectReaderWriter, BlueprintDeserializer blueprintDeserializer, BlueprintFileBundleLoader blueprintFileBundleLoader, BlueprintSourceService blueprintSourceService, IEnumerable<IBlueprintModifierProvider> blueprintModifierProviders)
		{
			_serializedObjectReaderWriter = serializedObjectReaderWriter;
			_blueprintDeserializer = blueprintDeserializer;
			_blueprintFileBundleLoader = blueprintFileBundleLoader;
			_blueprintSourceService = blueprintSourceService;
			_blueprintModifierProviders = blueprintModifierProviders.ToImmutableArray();
		}

		public void Load()
		{
			foreach (BlueprintFileBundle blueprintBundle in _blueprintFileBundleLoader.GetBundles(string.Empty))
			{
				Lazy<Blueprint> lazy = new Lazy<Blueprint>(() => Deserialize(blueprintBundle));
				_cachedBlueprintsByPath.Add(blueprintBundle.Path, lazy);
				SerializedObject serializedObject = _serializedObjectReaderWriter.ReadJsons(blueprintBundle.Jsons);
				foreach (Type specType in _blueprintDeserializer.GetSpecTypes(serializedObject))
				{
					_cachedBlueprintsBySpecs.GetOrAdd(specType).Add(lazy);
				}
			}
		}

		public Blueprint GetBlueprint(string blueprintPath)
		{
			string key = AssetPathHelper.NormalizePath(blueprintPath);
			if (_cachedBlueprintsByPath.TryGetValue(key, out var value))
			{
				return value.Value;
			}
			throw new ArgumentException("Blueprint not found at path: " + blueprintPath);
		}

		public T GetSingleSpec<T>() where T : ComponentSpec
		{
			List<Lazy<Blueprint>> orDefault = _cachedBlueprintsBySpecs.GetOrDefault(typeof(T));
			int count = orDefault.Count;
			if (count <= 1)
			{
				if (count == 0)
				{
					throw new Exception($"No blueprint found for {typeof(T)}");
				}
				return orDefault[0].Value.GetSpec<T>();
			}
			throw new Exception($"Multiple blueprints found for {typeof(T)}");
		}

		public IEnumerable<T> GetSpecs<T>() where T : ComponentSpec
		{
			List<Lazy<Blueprint>> orDefault = _cachedBlueprintsBySpecs.GetOrDefault(typeof(T));
			if (orDefault == null)
			{
				yield break;
			}
			foreach (Lazy<Blueprint> item in orDefault)
			{
				yield return item.Value.GetSpec<T>();
			}
		}

		private Blueprint Deserialize(BlueprintFileBundle blueprintFileBundle)
		{
			ImmutableArray<IBlueprintModifierProvider>.Enumerator enumerator = _blueprintModifierProviders.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IBlueprintModifierProvider current = enumerator.Current;
				foreach (string modifier in current.GetModifiers(blueprintFileBundle.Path))
				{
					blueprintFileBundle = blueprintFileBundle.AddJson(modifier, current.ModifierName);
				}
			}
			Blueprint blueprint = _blueprintDeserializer.DeserializeUnsafe(blueprintFileBundle);
			_blueprintSourceService.Add(blueprint, blueprintFileBundle);
			return blueprint;
		}
	}
}
