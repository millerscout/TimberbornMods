using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Planting
{
	public record PlanterBuildingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlanterBuildingSpec);
			}
		}

		[Serialize]
		public string PlantableResourceGroup { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlanterBuildingSpec");
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
			builder.Append("PlantableResourceGroup = ");
			builder.Append((object)PlantableResourceGroup);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PlantableResourceGroup);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlanterBuildingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(PlantableResourceGroup, other!.PlantableResourceGroup);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlanterBuildingSpec(PlanterBuildingSpec original)
			: base(original)
		{
			PlantableResourceGroup = original.PlantableResourceGroup;
		}

		public PlanterBuildingSpec()
		{
		}
	}
}
