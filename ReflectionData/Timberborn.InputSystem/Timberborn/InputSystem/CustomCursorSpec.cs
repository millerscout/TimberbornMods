using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.InputSystem
{
	internal record CustomCursorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CustomCursorSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public AssetRef<Texture2D> WindowsCursor { get; init; }

		[Serialize]
		public AssetRef<Texture2D> MacOsCursor { get; init; }

		[Serialize]
		public Vector2 Hotspot { get; init; }

		[Serialize]
		public Vector2 WindowsCursorOffset { get; init; }

		[Serialize]
		public Vector2 MacOsCursorOffset { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CustomCursorSpec");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder)
		{
			if (base.PrintMembers(builder))
			{
				builder.Append(", ");
			}
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", WindowsCursor = ");
			builder.Append(WindowsCursor);
			builder.Append(", MacOsCursor = ");
			builder.Append(MacOsCursor);
			builder.Append(", Hotspot = ");
			builder.Append(Hotspot.ToString());
			builder.Append(", WindowsCursorOffset = ");
			builder.Append(WindowsCursorOffset.ToString());
			builder.Append(", MacOsCursorOffset = ");
			builder.Append(MacOsCursorOffset.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(WindowsCursor)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(MacOsCursor)) * -1521134295 + EqualityComparer<Vector2>.Default.GetHashCode(Hotspot)) * -1521134295 + EqualityComparer<Vector2>.Default.GetHashCode(WindowsCursorOffset)) * -1521134295 + EqualityComparer<Vector2>.Default.GetHashCode(MacOsCursorOffset);
		}

		[CompilerGenerated]
		public virtual bool Equals(CustomCursorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(WindowsCursor, other!.WindowsCursor) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(MacOsCursor, other!.MacOsCursor) && EqualityComparer<Vector2>.Default.Equals(Hotspot, other!.Hotspot) && EqualityComparer<Vector2>.Default.Equals(WindowsCursorOffset, other!.WindowsCursorOffset))
				{
					return EqualityComparer<Vector2>.Default.Equals(MacOsCursorOffset, other!.MacOsCursorOffset);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CustomCursorSpec(CustomCursorSpec original)
			: base(original)
		{
			Id = original.Id;
			WindowsCursor = original.WindowsCursor;
			MacOsCursor = original.MacOsCursor;
			Hotspot = original.Hotspot;
			WindowsCursorOffset = original.WindowsCursorOffset;
			MacOsCursorOffset = original.MacOsCursorOffset;
		}

		public CustomCursorSpec()
		{
		}
	}
}
