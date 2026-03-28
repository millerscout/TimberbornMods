using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.GameDistrictsUI
{
	internal record DistrictConnectionDrawingServiceSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DistrictConnectionDrawingServiceSpec);
			}
		}

		[Serialize]
		public Color ConnectionHighlight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DistrictConnectionDrawingServiceSpec");
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
			builder.Append("ConnectionHighlight = ");
			builder.Append(ConnectionHighlight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(ConnectionHighlight);
		}

		[CompilerGenerated]
		public virtual bool Equals(DistrictConnectionDrawingServiceSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Color>.Default.Equals(ConnectionHighlight, other!.ConnectionHighlight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DistrictConnectionDrawingServiceSpec(DistrictConnectionDrawingServiceSpec original)
			: base(original)
		{
			ConnectionHighlight = original.ConnectionHighlight;
		}

		public DistrictConnectionDrawingServiceSpec()
		{
		}
	}
}
