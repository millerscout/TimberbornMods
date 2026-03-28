using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.BlockObjectTools
{
	internal record PreviewShowerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PreviewShowerSpec);
			}
		}

		[Serialize]
		public Color BuildablePreview { get; init; }

		[Serialize]
		public Color UnbuildablePreview { get; init; }

		[Serialize]
		public Color WarningPreview { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PreviewShowerSpec");
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
			builder.Append("BuildablePreview = ");
			builder.Append(BuildablePreview.ToString());
			builder.Append(", UnbuildablePreview = ");
			builder.Append(UnbuildablePreview.ToString());
			builder.Append(", WarningPreview = ");
			builder.Append(WarningPreview.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(BuildablePreview)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(UnbuildablePreview)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(WarningPreview);
		}

		[CompilerGenerated]
		public virtual bool Equals(PreviewShowerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Color>.Default.Equals(BuildablePreview, other!.BuildablePreview) && EqualityComparer<Color>.Default.Equals(UnbuildablePreview, other!.UnbuildablePreview))
				{
					return EqualityComparer<Color>.Default.Equals(WarningPreview, other!.WarningPreview);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PreviewShowerSpec(PreviewShowerSpec original)
			: base(original)
		{
			BuildablePreview = original.BuildablePreview;
			UnbuildablePreview = original.UnbuildablePreview;
			WarningPreview = original.WarningPreview;
		}

		public PreviewShowerSpec()
		{
		}
	}
}
