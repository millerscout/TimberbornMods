using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Timberborn.SingletonSystem;

namespace Timberborn.HttpApiSystem
{
	internal class StaticFilesEndpoint : IHttpApiEndpoint, ILoadableSingleton
	{
		private record ExtensionContentType(string Extension, string ContentType)
		{
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return typeof(ExtensionContentType);
				}
			}

			public ExtensionContentType(string Extension, string ContentType)
			{
				this.Extension = ;
				this.ContentType = ContentType;
				base._002Ector();
			}

			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("ExtensionContentType");
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
				builder.Append("Extension = ");
				builder.Append((object)Extension);
				builder.Append(", ContentType = ");
				builder.Append((object)ContentType);
				return true;
			}

			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Extension)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ContentType);
			}

			[CompilerGenerated]
			public virtual bool Equals(ExtensionContentType? other)
			{
				if ((object)this != other)
				{
					if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(Extension, other!.Extension))
					{
						return EqualityComparer<string>.Default.Equals(ContentType, other!.ContentType);
					}
					return false;
				}
				return true;
			}

			[CompilerGenerated]
			protected ExtensionContentType(ExtensionContentType original)
			{
				Extension = original.Extension;
				ContentType = original.ContentType;
			}
		}

		private static readonly string StaticDirectoryName = "static";

		private static readonly ImmutableArray<ExtensionContentType> ExtensionsContentTypes = ImmutableArray.Create<ExtensionContentType>().Add(new ExtensionContentType(".css", "text/css; charset=utf-8")).Add(new ExtensionContentType(".png", "image/png; charset=utf-8"));

		private ImmutableDictionary<string, byte[]> _staticFiles;

		public void Load()
		{
			string path2 = Path.Combine(HttpApi.RootPath, StaticDirectoryName);
			_staticFiles = Directory.EnumerateFiles(path2).Where(AnyExtensionContentTypeMatches).ToImmutableDictionary((string path) => "/" + Path.GetFileName(path), new Func<string, byte[]>(File.ReadAllBytes));
		}

		public async Task<bool> TryHandle(HttpListenerContext context)
		{
			string absolutePath = context.Request.Url.AbsolutePath;
			if (_staticFiles.TryGetValue(absolutePath, out var value))
			{
				await context.Write(GetContentType(absolutePath), value);
				return true;
			}
			return false;
		}

		private static string GetContentType(string path)
		{
			ImmutableArray<ExtensionContentType>.Enumerator enumerator = ExtensionsContentTypes.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ExtensionContentType current = enumerator.Current;
				if (path.EndsWith(current.Extension))
				{
					return current.ContentType;
				}
			}
			throw new ArgumentException(path);
		}

		private static bool AnyExtensionContentTypeMatches(string path)
		{
			return ExtensionsContentTypes.Any((ExtensionContentType extensionsContentType) => path.EndsWith(extensionsContentType.Extension));
		}
	}
}
