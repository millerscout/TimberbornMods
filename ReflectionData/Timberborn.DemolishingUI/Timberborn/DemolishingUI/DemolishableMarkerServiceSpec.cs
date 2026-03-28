using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.DemolishingUI
{
	internal record DemolishableMarkerServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DemolishableMarkerServiceSpec);
			}
		}

		[Serialize]
		public AssetRef<Mesh> Mesh { get; init; }

		[Serialize]
		public AssetRef<Material> Material { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DemolishableMarkerServiceSpec");
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
			builder.Append("Mesh = ");
			builder.Append(Mesh);
			builder.Append(", Material = ");
			builder.Append(Material);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<UnityEngine.Mesh>>.Default.GetHashCode(Mesh)) * -1521134295 + EqualityComparer<AssetRef<UnityEngine.Material>>.Default.GetHashCode(Material);
		}

		[CompilerGenerated]
		public virtual bool Equals(DemolishableMarkerServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<UnityEngine.Mesh>>.Default.Equals(Mesh, other!.Mesh))
				{
					return EqualityComparer<AssetRef<UnityEngine.Material>>.Default.Equals(Material, other!.Material);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DemolishableMarkerServiceSpec(DemolishableMarkerServiceSpec original)
			: base(original)
		{
			Mesh = original.Mesh;
			Material = original.Material;
		}

		public DemolishableMarkerServiceSpec()
		{
		}
	}
}
