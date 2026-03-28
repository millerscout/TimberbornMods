using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.PathSystem
{
	public record PathSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PathSpec);
			}
		}

		[Serialize]
		public Vector3Int MainPathCoordinates { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PathSpec");
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
			builder.Append("MainPathCoordinates = ");
			builder.Append(MainPathCoordinates.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(MainPathCoordinates);
		}

		[CompilerGenerated]
		public virtual bool Equals(PathSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(MainPathCoordinates, other!.MainPathCoordinates);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PathSpec(PathSpec original)
			: base(original)
		{
			MainPathCoordinates = original.MainPathCoordinates;
		}

		public PathSpec()
		{
		}
	}
}
