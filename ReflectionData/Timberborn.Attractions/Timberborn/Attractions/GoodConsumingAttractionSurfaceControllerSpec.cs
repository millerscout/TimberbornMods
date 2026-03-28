using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Attractions
{
	internal record GoodConsumingAttractionSurfaceControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodConsumingAttractionSurfaceControllerSpec);
			}
		}

		[Serialize]
		public string SurfaceName { get; init; }

		[Serialize]
		public ImmutableArray<string> AttachmentIds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodConsumingAttractionSurfaceControllerSpec");
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
			builder.Append("SurfaceName = ");
			builder.Append((object)SurfaceName);
			builder.Append(", AttachmentIds = ");
			builder.Append(AttachmentIds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SurfaceName)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(AttachmentIds);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodConsumingAttractionSurfaceControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(SurfaceName, other!.SurfaceName))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(AttachmentIds, other!.AttachmentIds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodConsumingAttractionSurfaceControllerSpec(GoodConsumingAttractionSurfaceControllerSpec original)
			: base(original)
		{
			SurfaceName = original.SurfaceName;
			AttachmentIds = original.AttachmentIds;
		}

		public GoodConsumingAttractionSurfaceControllerSpec()
		{
		}
	}
}
