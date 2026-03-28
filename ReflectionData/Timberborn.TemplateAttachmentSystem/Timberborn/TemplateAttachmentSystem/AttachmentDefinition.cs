using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.TemplateAttachmentSystem
{
	internal record AttachmentDefinition
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AttachmentDefinition);
			}
		}

		[Serialize]
		public string AttachmentId { get; init; }

		[Serialize]
		public AssetRef<GameObject> Prefab { get; init; }

		[Serialize]
		public string Parent { get; init; }

		[Serialize]
		public Vector3 Position { get; init; }

		[Serialize]
		public Vector3 Rotation { get; init; }

		[Serialize]
		public Vector3 Scale { get; init; }

		[Serialize]
		public bool CreateInstantly { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AttachmentDefinition");
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
			builder.Append("AttachmentId = ");
			builder.Append((object)AttachmentId);
			builder.Append(", Prefab = ");
			builder.Append(Prefab);
			builder.Append(", Parent = ");
			builder.Append((object)Parent);
			builder.Append(", Position = ");
			builder.Append(Position.ToString());
			builder.Append(", Rotation = ");
			builder.Append(Rotation.ToString());
			builder.Append(", Scale = ");
			builder.Append(Scale.ToString());
			builder.Append(", CreateInstantly = ");
			builder.Append(CreateInstantly.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AttachmentId)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(Prefab)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Parent)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Position)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Rotation)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Scale)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(CreateInstantly);
		}

		[CompilerGenerated]
		public virtual bool Equals(AttachmentDefinition? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(AttachmentId, other!.AttachmentId) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(Prefab, other!.Prefab) && EqualityComparer<string>.Default.Equals(Parent, other!.Parent) && EqualityComparer<Vector3>.Default.Equals(Position, other!.Position) && EqualityComparer<Vector3>.Default.Equals(Rotation, other!.Rotation) && EqualityComparer<Vector3>.Default.Equals(Scale, other!.Scale))
				{
					return EqualityComparer<bool>.Default.Equals(CreateInstantly, other!.CreateInstantly);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AttachmentDefinition(AttachmentDefinition original)
		{
			AttachmentId = original.AttachmentId;
			Prefab = original.Prefab;
			Parent = original.Parent;
			Position = original.Position;
			Rotation = original.Rotation;
			Scale = original.Scale;
			CreateInstantly = original.CreateInstantly;
		}

		public AttachmentDefinition()
		{
			Scale = Vector3.one;
			CreateInstantly = true;
			base._002Ector();
		}
	}
}
