using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace Timberborn.BlueprintSystem
{
	public record AssetRef<T> where T : UnityEngine.Object
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AssetRef<T>);
			}
		}

		public string Path { get; }

		public T Asset => _lazyAsset.Value;

		private readonly Lazy<T> _lazyAsset;

		public AssetRef(string path, Lazy<T> lazyAsset)
		{
			Path = path;
			_lazyAsset = lazyAsset;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AssetRef");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("Path = ");
			builder.Append((object)Path);
			builder.Append(", Asset = ");
			builder.Append(Asset);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<Lazy<T>>.Default.GetHashCode(_lazyAsset);
		}

		[CompilerGenerated]
		public virtual bool Equals(AssetRef<T>? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Path, other!.Path))
				{
					return EqualityComparer<Lazy<T>>.Default.Equals(_lazyAsset, other!._lazyAsset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AssetRef(AssetRef<T> original)
		{
			Path = original.Path;
			_lazyAsset = original._lazyAsset;
		}
	}
}
