using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.StockpileVisualization
{
	public record GoodVisualizationSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodVisualizationSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public string Variant { get; init; }

		[Serialize]
		public Vector3 Offset { get; init; }

		[Serialize]
		public float LimitingAmount { get; init; }

		[Serialize]
		public AssetRef<Mesh> PrimaryMesh { get; init; }

		[Serialize]
		public AssetRef<Mesh> SecondaryMesh { get; init; }

		[Serialize]
		public AssetRef<Material> Material { get; init; }

		[Serialize]
		public float NonLinearity { get; init; }

		public int LimitingAmountFlooredToInt => (int)LimitingAmount;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodVisualizationSpec");
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
			builder.Append(", Variant = ");
			builder.Append((object)Variant);
			builder.Append(", Offset = ");
			builder.Append(Offset.ToString());
			builder.Append(", LimitingAmount = ");
			builder.Append(LimitingAmount.ToString());
			builder.Append(", PrimaryMesh = ");
			builder.Append(PrimaryMesh);
			builder.Append(", SecondaryMesh = ");
			builder.Append(SecondaryMesh);
			builder.Append(", Material = ");
			builder.Append(Material);
			builder.Append(", NonLinearity = ");
			builder.Append(NonLinearity.ToString());
			builder.Append(", LimitingAmountFlooredToInt = ");
			builder.Append(LimitingAmountFlooredToInt.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Variant)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Offset)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(LimitingAmount)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(PrimaryMesh)) * -1521134295 + EqualityComparer<AssetRef<Mesh>>.Default.GetHashCode(SecondaryMesh)) * -1521134295 + EqualityComparer<AssetRef<UnityEngine.Material>>.Default.GetHashCode(Material)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(NonLinearity);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodVisualizationSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<string>.Default.Equals(Variant, other!.Variant) && EqualityComparer<Vector3>.Default.Equals(Offset, other!.Offset) && EqualityComparer<float>.Default.Equals(LimitingAmount, other!.LimitingAmount) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(PrimaryMesh, other!.PrimaryMesh) && EqualityComparer<AssetRef<Mesh>>.Default.Equals(SecondaryMesh, other!.SecondaryMesh) && EqualityComparer<AssetRef<UnityEngine.Material>>.Default.Equals(Material, other!.Material))
				{
					return EqualityComparer<float>.Default.Equals(NonLinearity, other!.NonLinearity);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodVisualizationSpec(GoodVisualizationSpec original)
			: base(original)
		{
			Id = original.Id;
			Variant = original.Variant;
			Offset = original.Offset;
			LimitingAmount = original.LimitingAmount;
			PrimaryMesh = original.PrimaryMesh;
			SecondaryMesh = original.SecondaryMesh;
			Material = original.Material;
			NonLinearity = original.NonLinearity;
		}

		public GoodVisualizationSpec()
		{
		}
	}
}
