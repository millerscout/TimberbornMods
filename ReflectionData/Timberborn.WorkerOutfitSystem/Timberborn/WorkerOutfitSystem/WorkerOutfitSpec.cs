using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.WorkerOutfitSystem
{
	internal record WorkerOutfitSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WorkerOutfitSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public string FactionId { get; init; }

		[Serialize]
		public string WorkerType { get; init; }

		[Serialize]
		public AssetRef<Texture2D> DiffuseTexture { get; init; }

		[Serialize]
		public AssetRef<Texture2D> NormalTexture { get; init; }

		[Serialize]
		public ImmutableArray<string> Attachments { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WorkerOutfitSpec");
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
			builder.Append(", FactionId = ");
			builder.Append((object)FactionId);
			builder.Append(", WorkerType = ");
			builder.Append((object)WorkerType);
			builder.Append(", DiffuseTexture = ");
			builder.Append(DiffuseTexture);
			builder.Append(", NormalTexture = ");
			builder.Append(NormalTexture);
			builder.Append(", Attachments = ");
			builder.Append(Attachments.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FactionId)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WorkerType)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(DiffuseTexture)) * -1521134295 + EqualityComparer<AssetRef<Texture2D>>.Default.GetHashCode(NormalTexture)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(Attachments);
		}

		[CompilerGenerated]
		public virtual bool Equals(WorkerOutfitSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<string>.Default.Equals(FactionId, other!.FactionId) && EqualityComparer<string>.Default.Equals(WorkerType, other!.WorkerType) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(DiffuseTexture, other!.DiffuseTexture) && EqualityComparer<AssetRef<Texture2D>>.Default.Equals(NormalTexture, other!.NormalTexture))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(Attachments, other!.Attachments);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WorkerOutfitSpec(WorkerOutfitSpec original)
			: base(original)
		{
			Id = original.Id;
			FactionId = original.FactionId;
			WorkerType = original.WorkerType;
			DiffuseTexture = original.DiffuseTexture;
			NormalTexture = original.NormalTexture;
			Attachments = original.Attachments;
		}

		public WorkerOutfitSpec()
		{
		}
	}
}
