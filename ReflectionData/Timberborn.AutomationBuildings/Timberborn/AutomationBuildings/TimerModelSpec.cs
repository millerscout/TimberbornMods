using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.AutomationBuildings
{
	internal record TimerModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TimerModelSpec);
			}
		}

		[Serialize]
		public string ProgressObjectName { get; init; }

		[Serialize]
		public float MinHeight { get; init; }

		[Serialize]
		public float MaxHeight { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TimerModelSpec");
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
			builder.Append("ProgressObjectName = ");
			builder.Append((object)ProgressObjectName);
			builder.Append(", MinHeight = ");
			builder.Append(MinHeight.ToString());
			builder.Append(", MaxHeight = ");
			builder.Append(MaxHeight.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProgressObjectName)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MinHeight)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(MaxHeight);
		}

		[CompilerGenerated]
		public virtual bool Equals(TimerModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(ProgressObjectName, other!.ProgressObjectName) && EqualityComparer<float>.Default.Equals(MinHeight, other!.MinHeight))
				{
					return EqualityComparer<float>.Default.Equals(MaxHeight, other!.MaxHeight);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TimerModelSpec(TimerModelSpec original)
			: base(original)
		{
			ProgressObjectName = original.ProgressObjectName;
			MinHeight = original.MinHeight;
			MaxHeight = original.MaxHeight;
		}

		public TimerModelSpec()
		{
		}
	}
}
