using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.NewGameConfigurationSystem
{
	public record MinMaxSpec<T> : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MinMaxSpec<T>);
			}
		}

		[Serialize]
		public T Min { get; init; }

		[Serialize]
		public T Max { get; init; }

		public override string ToString()
		{
			return $"{Min} - {Max}";
		}

		[CompilerGenerated]
		protected override bool PrintMembers(StringBuilder builder)
		{
			if (base.PrintMembers(builder))
			{
				builder.Append(", ");
			}
			builder.Append("Min = ");
			builder.Append(Min);
			builder.Append(", Max = ");
			builder.Append(Max);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<T>.Default.GetHashCode(Min)) * -1521134295 + EqualityComparer<T>.Default.GetHashCode(Max);
		}

		[CompilerGenerated]
		public virtual bool Equals(MinMaxSpec<T>? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<T>.Default.Equals(Min, other!.Min))
				{
					return EqualityComparer<T>.Default.Equals(Max, other!.Max);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MinMaxSpec(MinMaxSpec<T> original)
			: base(original)
		{
			Min = original.Min;
			Max = original.Max;
		}

		public MinMaxSpec()
		{
		}
	}
}
