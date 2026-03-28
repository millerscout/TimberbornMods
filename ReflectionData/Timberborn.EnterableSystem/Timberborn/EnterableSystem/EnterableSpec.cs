using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.EnterableSystem
{
	public record EnterableSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EnterableSpec);
			}
		}

		[Serialize]
		public OperatingState OperatingState { get; init; }

		[Serialize]
		public bool LimitedCapacityFinished { get; init; }

		[Serialize]
		public int CapacityFinished { get; init; }

		[Serialize]
		public bool LimitedCapacityUnfinished { get; init; }

		[Serialize]
		public int CapacityUnfinished { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EnterableSpec");
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
			builder.Append("OperatingState = ");
			builder.Append(OperatingState.ToString());
			builder.Append(", LimitedCapacityFinished = ");
			builder.Append(LimitedCapacityFinished.ToString());
			builder.Append(", CapacityFinished = ");
			builder.Append(CapacityFinished.ToString());
			builder.Append(", LimitedCapacityUnfinished = ");
			builder.Append(LimitedCapacityUnfinished.ToString());
			builder.Append(", CapacityUnfinished = ");
			builder.Append(CapacityUnfinished.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<OperatingState>.Default.GetHashCode(OperatingState)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(LimitedCapacityFinished)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CapacityFinished)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(LimitedCapacityUnfinished)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(CapacityUnfinished);
		}

		[CompilerGenerated]
		public virtual bool Equals(EnterableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<OperatingState>.Default.Equals(OperatingState, other!.OperatingState) && EqualityComparer<bool>.Default.Equals(LimitedCapacityFinished, other!.LimitedCapacityFinished) && EqualityComparer<int>.Default.Equals(CapacityFinished, other!.CapacityFinished) && EqualityComparer<bool>.Default.Equals(LimitedCapacityUnfinished, other!.LimitedCapacityUnfinished))
				{
					return EqualityComparer<int>.Default.Equals(CapacityUnfinished, other!.CapacityUnfinished);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected EnterableSpec(EnterableSpec original)
			: base(original)
		{
			OperatingState = original.OperatingState;
			LimitedCapacityFinished = original.LimitedCapacityFinished;
			CapacityFinished = original.CapacityFinished;
			LimitedCapacityUnfinished = original.LimitedCapacityUnfinished;
			CapacityUnfinished = original.CapacityUnfinished;
		}

		public EnterableSpec()
		{
		}
	}
}
