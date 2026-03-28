using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NaturalResourcesModelSystem
{
	internal record NaturalResourceModelRandomizerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NaturalResourceModelRandomizerSpec);
			}
		}

		[Serialize]
		public bool ConstrainProportion { get; init; }

		[Serialize]
		public float MinHeightScaleFactor { get; init; }

		[Serialize]
		public float MaxHeightScaleFactor { get; init; }

		[Serialize]
		public float MinWidthScaleFactor { get; init; }

		[Serialize]
		public float MaxWidthScaleFactor { get; init; }

		[Serialize]
		public RandomizeRotationMode RandomizedRotation { get; init; }

		[Serialize]
		public float MinRotation { get; init; }

		[Serialize]
		public float MaxRotation { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NaturalResourceModelRandomizerSpec");
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
			builder.Append("ConstrainProportion = ");
			builder.Append(ConstrainProportion.ToString());
			builder.Append(", MinHeightScaleFactor = ");
			builder.Append(MinHeightScaleFactor.ToString());
			builder.Append(", MaxHeightScaleFactor = ");
			builder.Append(MaxHeightScaleFactor.ToString());
			builder.Append(", MinWidthScaleFactor = ");
			builder.Append(MinWidthScaleFactor.ToString());
			builder.Append(", MaxWidthScaleFactor = ");
			builder.Append(MaxWidthScaleFactor.ToString());
			builder.Append(", RandomizedRotation = ");
			builder.Append(RandomizedRotation.ToString());
			builder.Append(", MinRotation = ");
			builder.Append(MinRotation.ToString());
			builder.Append(", MaxRotation = ");
			builder.Append(MaxRotation.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((((base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ConstrainProportion)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinHeightScaleFactor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxHeightScaleFactor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinWidthScaleFactor)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxWidthScaleFactor)) * -1521134295 + EqualityComparer<RandomizeRotationMode>.Default.GetHashCode(RandomizedRotation)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinRotation)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxRotation);
		}

		[CompilerGenerated]
		public virtual bool Equals(NaturalResourceModelRandomizerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<bool>.Default.Equals(ConstrainProportion, other!.ConstrainProportion) && EqualityComparer<float>.Default.Equals(MinHeightScaleFactor, other!.MinHeightScaleFactor) && EqualityComparer<float>.Default.Equals(MaxHeightScaleFactor, other!.MaxHeightScaleFactor) && EqualityComparer<float>.Default.Equals(MinWidthScaleFactor, other!.MinWidthScaleFactor) && EqualityComparer<float>.Default.Equals(MaxWidthScaleFactor, other!.MaxWidthScaleFactor) && EqualityComparer<RandomizeRotationMode>.Default.Equals(RandomizedRotation, other!.RandomizedRotation) && EqualityComparer<float>.Default.Equals(MinRotation, other!.MinRotation))
				{
					return EqualityComparer<float>.Default.Equals(MaxRotation, other!.MaxRotation);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NaturalResourceModelRandomizerSpec(NaturalResourceModelRandomizerSpec original)
			: base(original)
		{
			ConstrainProportion = original.ConstrainProportion;
			MinHeightScaleFactor = original.MinHeightScaleFactor;
			MaxHeightScaleFactor = original.MaxHeightScaleFactor;
			MinWidthScaleFactor = original.MinWidthScaleFactor;
			MaxWidthScaleFactor = original.MaxWidthScaleFactor;
			RandomizedRotation = original.RandomizedRotation;
			MinRotation = original.MinRotation;
			MaxRotation = original.MaxRotation;
		}

		public NaturalResourceModelRandomizerSpec()
		{
			MinHeightScaleFactor = 0.8f;
			MaxHeightScaleFactor = 1.2f;
			MinWidthScaleFactor = 0.8f;
			MaxWidthScaleFactor = 1.2f;
			MaxRotation = 360f;
			base._002Ector();
		}
	}
}
