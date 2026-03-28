using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Buildings
{
	internal record BuildingModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BuildingModelSpec);
			}
		}

		[Serialize]
		public string FinishedModelName { get; init; }

		[Serialize]
		public string UnfinishedModelName { get; init; }

		[Serialize]
		public string FinishedUncoveredModelName { get; init; }

		[Serialize]
		public string UndergroundModelName { get; init; }

		[Serialize]
		public ConstructionModeModel ConstructionModeModel { get; init; }

		[Serialize]
		public int UndergroundModelDepth { get; init; }

		public bool UnfinishedConstructionModeModel => ConstructionModeModel == ConstructionModeModel.Unfinished;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BuildingModelSpec");
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
			builder.Append("FinishedModelName = ");
			builder.Append((object)FinishedModelName);
			builder.Append(", UnfinishedModelName = ");
			builder.Append((object)UnfinishedModelName);
			builder.Append(", FinishedUncoveredModelName = ");
			builder.Append((object)FinishedUncoveredModelName);
			builder.Append(", UndergroundModelName = ");
			builder.Append((object)UndergroundModelName);
			builder.Append(", ConstructionModeModel = ");
			builder.Append(ConstructionModeModel.ToString());
			builder.Append(", UndergroundModelDepth = ");
			builder.Append(UndergroundModelDepth.ToString());
			builder.Append(", UnfinishedConstructionModeModel = ");
			builder.Append(UnfinishedConstructionModeModel.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FinishedModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UnfinishedModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FinishedUncoveredModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UndergroundModelName)) * -1521134295 + EqualityComparer<ConstructionModeModel>.Default.GetHashCode(ConstructionModeModel)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(UndergroundModelDepth);
		}

		[CompilerGenerated]
		public virtual bool Equals(BuildingModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(FinishedModelName, other!.FinishedModelName) && EqualityComparer<string>.Default.Equals(UnfinishedModelName, other!.UnfinishedModelName) && EqualityComparer<string>.Default.Equals(FinishedUncoveredModelName, other!.FinishedUncoveredModelName) && EqualityComparer<string>.Default.Equals(UndergroundModelName, other!.UndergroundModelName) && EqualityComparer<ConstructionModeModel>.Default.Equals(ConstructionModeModel, other!.ConstructionModeModel))
				{
					return EqualityComparer<int>.Default.Equals(UndergroundModelDepth, other!.UndergroundModelDepth);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BuildingModelSpec(BuildingModelSpec original)
			: base(original)
		{
			FinishedModelName = original.FinishedModelName;
			UnfinishedModelName = original.UnfinishedModelName;
			FinishedUncoveredModelName = original.FinishedUncoveredModelName;
			UndergroundModelName = original.UndergroundModelName;
			ConstructionModeModel = original.ConstructionModeModel;
			UndergroundModelDepth = original.UndergroundModelDepth;
		}

		public BuildingModelSpec()
		{
		}
	}
}
