using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.ModularShafts
{
	internal record ModularShaftPartsSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ModularShaftPartsSpec);
			}
		}

		[Serialize]
		public AssetRef<GameObject> ShaftBase { get; init; }

		[Serialize]
		public AssetRef<GameObject> ShaftLowerFrame { get; init; }

		[Serialize]
		public AssetRef<GameObject> ShaftSupport { get; init; }

		[Serialize]
		public AssetRef<GameObject> ShaftFrame { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearSmall { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearMedium { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearLarge { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearBottomBase { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearBottomSmall { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearBottomLarge { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearTopSmall { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearTopLarge { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearInner { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearInnerLong { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearInnerOpposite { get; init; }

		[Serialize]
		public AssetRef<GameObject> GearInnerThrough { get; init; }

		[Serialize]
		public AssetRef<GameObject> AxleInnerLong { get; init; }

		[Serialize]
		public AssetRef<GameObject> AxleVertical { get; init; }

		[Serialize]
		public AssetRef<GameObject> AxleHorizontal { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ModularShaftPartsSpec");
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
			builder.Append("ShaftBase = ");
			builder.Append(ShaftBase);
			builder.Append(", ShaftLowerFrame = ");
			builder.Append(ShaftLowerFrame);
			builder.Append(", ShaftSupport = ");
			builder.Append(ShaftSupport);
			builder.Append(", ShaftFrame = ");
			builder.Append(ShaftFrame);
			builder.Append(", GearSmall = ");
			builder.Append(GearSmall);
			builder.Append(", GearMedium = ");
			builder.Append(GearMedium);
			builder.Append(", GearLarge = ");
			builder.Append(GearLarge);
			builder.Append(", GearBottomBase = ");
			builder.Append(GearBottomBase);
			builder.Append(", GearBottomSmall = ");
			builder.Append(GearBottomSmall);
			builder.Append(", GearBottomLarge = ");
			builder.Append(GearBottomLarge);
			builder.Append(", GearTopSmall = ");
			builder.Append(GearTopSmall);
			builder.Append(", GearTopLarge = ");
			builder.Append(GearTopLarge);
			builder.Append(", GearInner = ");
			builder.Append(GearInner);
			builder.Append(", GearInnerLong = ");
			builder.Append(GearInnerLong);
			builder.Append(", GearInnerOpposite = ");
			builder.Append(GearInnerOpposite);
			builder.Append(", GearInnerThrough = ");
			builder.Append(GearInnerThrough);
			builder.Append(", AxleInnerLong = ");
			builder.Append(AxleInnerLong);
			builder.Append(", AxleVertical = ");
			builder.Append(AxleVertical);
			builder.Append(", AxleHorizontal = ");
			builder.Append(AxleHorizontal);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((((((((((((((base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(ShaftBase)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(ShaftLowerFrame)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(ShaftSupport)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(ShaftFrame)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearSmall)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearMedium)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearLarge)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearBottomBase)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearBottomSmall)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearBottomLarge)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearTopSmall)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearTopLarge)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearInner)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearInnerLong)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearInnerOpposite)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(GearInnerThrough)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(AxleInnerLong)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(AxleVertical)) * -1521134295 + EqualityComparer<AssetRef<GameObject>>.Default.GetHashCode(AxleHorizontal);
		}

		[CompilerGenerated]
		public virtual bool Equals(ModularShaftPartsSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(ShaftBase, other!.ShaftBase) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(ShaftLowerFrame, other!.ShaftLowerFrame) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(ShaftSupport, other!.ShaftSupport) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(ShaftFrame, other!.ShaftFrame) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearSmall, other!.GearSmall) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearMedium, other!.GearMedium) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearLarge, other!.GearLarge) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearBottomBase, other!.GearBottomBase) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearBottomSmall, other!.GearBottomSmall) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearBottomLarge, other!.GearBottomLarge) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearTopSmall, other!.GearTopSmall) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearTopLarge, other!.GearTopLarge) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearInner, other!.GearInner) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearInnerLong, other!.GearInnerLong) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearInnerOpposite, other!.GearInnerOpposite) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(GearInnerThrough, other!.GearInnerThrough) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(AxleInnerLong, other!.AxleInnerLong) && EqualityComparer<AssetRef<GameObject>>.Default.Equals(AxleVertical, other!.AxleVertical))
				{
					return EqualityComparer<AssetRef<GameObject>>.Default.Equals(AxleHorizontal, other!.AxleHorizontal);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ModularShaftPartsSpec(ModularShaftPartsSpec original)
			: base(original)
		{
			ShaftBase = original.ShaftBase;
			ShaftLowerFrame = original.ShaftLowerFrame;
			ShaftSupport = original.ShaftSupport;
			ShaftFrame = original.ShaftFrame;
			GearSmall = original.GearSmall;
			GearMedium = original.GearMedium;
			GearLarge = original.GearLarge;
			GearBottomBase = original.GearBottomBase;
			GearBottomSmall = original.GearBottomSmall;
			GearBottomLarge = original.GearBottomLarge;
			GearTopSmall = original.GearTopSmall;
			GearTopLarge = original.GearTopLarge;
			GearInner = original.GearInner;
			GearInnerLong = original.GearInnerLong;
			GearInnerOpposite = original.GearInnerOpposite;
			GearInnerThrough = original.GearInnerThrough;
			AxleInnerLong = original.AxleInnerLong;
			AxleVertical = original.AxleVertical;
			AxleHorizontal = original.AxleHorizontal;
		}

		public ModularShaftPartsSpec()
		{
		}
	}
}
