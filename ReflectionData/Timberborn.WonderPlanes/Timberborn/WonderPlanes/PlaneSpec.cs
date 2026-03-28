using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WonderPlanes
{
	internal record PlaneSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlaneSpec);
			}
		}

		[Serialize]
		public string PilotSeatName { get; init; }

		[Serialize]
		public float RotationSpeed { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlaneSpec");
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
			builder.Append("PilotSeatName = ");
			builder.Append((object)PilotSeatName);
			builder.Append(", RotationSpeed = ");
			builder.Append(RotationSpeed.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PilotSeatName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(RotationSpeed);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlaneSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(PilotSeatName, other!.PilotSeatName))
				{
					return EqualityComparer<float>.Default.Equals(RotationSpeed, other!.RotationSpeed);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlaneSpec(PlaneSpec original)
			: base(original)
		{
			PilotSeatName = original.PilotSeatName;
			RotationSpeed = original.RotationSpeed;
		}

		public PlaneSpec()
		{
		}
	}
}
