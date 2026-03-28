using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.SimpleOutputBuildings
{
	internal record SimpleOutputInventorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(SimpleOutputInventorySpec);
			}
		}

		[Serialize]
		public int Capacity { get; init; }

		[Serialize]
		public bool IgnorableCapacity { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SimpleOutputInventorySpec");
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
			builder.Append("Capacity = ");
			builder.Append(Capacity.ToString());
			builder.Append(", IgnorableCapacity = ");
			builder.Append(IgnorableCapacity.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Capacity)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IgnorableCapacity);
		}

		[CompilerGenerated]
		public virtual bool Equals(SimpleOutputInventorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(Capacity, other!.Capacity))
				{
					return EqualityComparer<bool>.Default.Equals(IgnorableCapacity, other!.IgnorableCapacity);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected SimpleOutputInventorySpec(SimpleOutputInventorySpec original)
			: base(original)
		{
			Capacity = original.Capacity;
			IgnorableCapacity = original.IgnorableCapacity;
		}

		public SimpleOutputInventorySpec()
		{
		}
	}
}
