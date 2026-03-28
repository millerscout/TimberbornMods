using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.AssetSystem;
using Timberborn.BlueprintSystem;

namespace Timberborn.PlantingUI
{
	internal record PlantablePreviewSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlantablePreviewSpec);
			}
		}

		[Serialize]
		public AssetRef<BinaryData> Model { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlantablePreviewSpec");
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
			builder.Append("Model = ");
			builder.Append(Model);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<AssetRef<BinaryData>>.Default.GetHashCode(Model);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlantablePreviewSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<AssetRef<BinaryData>>.Default.Equals(Model, other!.Model);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlantablePreviewSpec(PlantablePreviewSpec original)
			: base(original)
		{
			Model = original.Model;
		}

		public PlantablePreviewSpec()
		{
		}
	}
}
