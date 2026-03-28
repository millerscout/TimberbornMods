using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.PathSystem
{
	internal record DrivewayModelInstantiatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DrivewayModelInstantiatorSpec);
			}
		}

		[Serialize]
		public AssetRef<GameObject> NarrowLeftDrivewayPrefab { get; init; }

		[Serialize]
		public AssetRef<GameObject> NarrowCenterDrivewayPrefab { get; init; }

		[Serialize]
		public AssetRef<GameObject> NarrowRightDrivewayPrefab { get; init; }

		[Serialize]
		public AssetRef<GameObject> WideCenterDrivewayPrefab { get; init; }

		[Serialize]
		public AssetRef<GameObject> LongCenterDrivewayPrefab { get; init; }

		[Serialize]
		public AssetRef<GameObject> StraightPathDrivewayPrefab { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DrivewayModelInstantiatorSpec");
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
			builder.Append("NarrowLeftDrivewayPrefab = ");
			builder.Append(NarrowLeftDrivewayPrefab);
			builder.Append(", NarrowCenterDrivewayPrefab = ");
			builder.Append(NarrowCenterDrivewayPrefab);
			builder.Append(", NarrowRightDrivewayPrefab = ");
			builder.Append(NarrowRightDrivewayPrefab);
			builder.Append(", WideCenterDrivewayPrefab = ");
			builder.Append(WideCenterDrivewayPrefab);
			builder.Append(", LongCenterDrivewayPrefab = ");
			builder.Append(LongCenterDrivewayPrefab);
			builder.Append(", StraightPathDrivewayPrefab = ");
			builder.Append(StraightPathDrivewayPrefab);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(NarrowLeftDrivewayPrefab)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(NarrowCenterDrivewayPrefab)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(NarrowRightDrivewayPrefab)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(WideCenterDrivewayPrefab)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(LongCenterDrivewayPrefab)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(StraightPathDrivewayPrefab);
		}

		[CompilerGenerated]
		public virtual bool Equals(DrivewayModelInstantiatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(NarrowLeftDrivewayPrefab, other!.NarrowLeftDrivewayPrefab) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(NarrowCenterDrivewayPrefab, other!.NarrowCenterDrivewayPrefab) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(NarrowRightDrivewayPrefab, other!.NarrowRightDrivewayPrefab) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(WideCenterDrivewayPrefab, other!.WideCenterDrivewayPrefab) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(LongCenterDrivewayPrefab, other!.LongCenterDrivewayPrefab))
				{
					return EqualityComparer<AssetRef<GameObject>>.Default.Equals(StraightPathDrivewayPrefab, other!.StraightPathDrivewayPrefab);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DrivewayModelInstantiatorSpec(DrivewayModelInstantiatorSpec original)
			: base(original)
		{
			NarrowLeftDrivewayPrefab = original.NarrowLeftDrivewayPrefab;
			NarrowCenterDrivewayPrefab = original.NarrowCenterDrivewayPrefab;
			NarrowRightDrivewayPrefab = original.NarrowRightDrivewayPrefab;
			WideCenterDrivewayPrefab = original.WideCenterDrivewayPrefab;
			LongCenterDrivewayPrefab = original.LongCenterDrivewayPrefab;
			StraightPathDrivewayPrefab = original.StraightPathDrivewayPrefab;
		}

		public DrivewayModelInstantiatorSpec()
		{
		}
	}
}
