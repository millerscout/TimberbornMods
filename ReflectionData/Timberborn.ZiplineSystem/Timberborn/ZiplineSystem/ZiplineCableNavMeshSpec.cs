using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.ZiplineSystem
{
	public record ZiplineCableNavMeshSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ZiplineCableNavMeshSpec);
			}
		}

		[Serialize]
		public float CableUnitCost { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ZiplineCableNavMeshSpec");
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
			builder.Append("CableUnitCost = ");
			builder.Append(CableUnitCost.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(CableUnitCost);
		}

		[CompilerGenerated]
		public virtual bool Equals(ZiplineCableNavMeshSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(CableUnitCost, other!.CableUnitCost);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ZiplineCableNavMeshSpec(ZiplineCableNavMeshSpec original)
			: base(original)
		{
			CableUnitCost = original.CableUnitCost;
		}

		public ZiplineCableNavMeshSpec()
		{
		}
	}
}
