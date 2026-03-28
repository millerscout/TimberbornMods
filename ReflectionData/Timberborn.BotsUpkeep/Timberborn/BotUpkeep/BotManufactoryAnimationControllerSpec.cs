using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BotUpkeep
{
	internal record BotManufactoryAnimationControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BotManufactoryAnimationControllerSpec);
			}
		}

		[Serialize]
		public float AssemblyDuration { get; init; }

		[Serialize]
		public float RingRotationSpeed { get; init; }

		[Serialize]
		public float DrillRotationSpeed { get; init; }

		[Serialize]
		public string RingName { get; init; }

		[Serialize]
		public string DrillName { get; init; }

		[Serialize]
		public ImmutableArray<string> AttachmentIds { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BotManufactoryAnimationControllerSpec");
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
			builder.Append("AssemblyDuration = ");
			builder.Append(AssemblyDuration.ToString());
			builder.Append(", RingRotationSpeed = ");
			builder.Append(RingRotationSpeed.ToString());
			builder.Append(", DrillRotationSpeed = ");
			builder.Append(DrillRotationSpeed.ToString());
			builder.Append(", RingName = ");
			builder.Append((object)RingName);
			builder.Append(", DrillName = ");
			builder.Append((object)DrillName);
			builder.Append(", AttachmentIds = ");
			builder.Append(AttachmentIds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((((base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(AssemblyDuration)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RingRotationSpeed)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(DrillRotationSpeed)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(RingName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DrillName)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(AttachmentIds);
		}

		[CompilerGenerated]
		public virtual bool Equals(BotManufactoryAnimationControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<float>.Default.Equals(AssemblyDuration, other!.AssemblyDuration) && EqualityComparer<float>.Default.Equals(RingRotationSpeed, other!.RingRotationSpeed) && EqualityComparer<float>.Default.Equals(DrillRotationSpeed, other!.DrillRotationSpeed) && EqualityComparer<string>.Default.Equals(RingName, other!.RingName) && EqualityComparer<string>.Default.Equals(DrillName, other!.DrillName))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(AttachmentIds, other!.AttachmentIds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BotManufactoryAnimationControllerSpec(BotManufactoryAnimationControllerSpec original)
			: base(original)
		{
			AssemblyDuration = original.AssemblyDuration;
			RingRotationSpeed = original.RingRotationSpeed;
			DrillRotationSpeed = original.DrillRotationSpeed;
			RingName = original.RingName;
			DrillName = original.DrillName;
			AttachmentIds = original.AttachmentIds;
		}

		public BotManufactoryAnimationControllerSpec()
		{
		}
	}
}
