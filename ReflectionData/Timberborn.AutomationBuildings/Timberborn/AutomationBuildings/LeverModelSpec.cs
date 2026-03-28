using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.AutomationBuildings
{
	internal record LeverModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(LeverModelSpec);
			}
		}

		[Serialize]
		public string OnModelName { get; init; }

		[Serialize]
		public string OffModelName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("LeverModelSpec");
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
			builder.Append("OnModelName = ");
			builder.Append((object)OnModelName);
			builder.Append(", OffModelName = ");
			builder.Append((object)OffModelName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OnModelName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OffModelName);
		}

		[CompilerGenerated]
		public virtual bool Equals(LeverModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(OnModelName, other!.OnModelName))
				{
					return EqualityComparer<string>.Default.Equals(OffModelName, other!.OffModelName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected LeverModelSpec(LeverModelSpec original)
			: base(original)
		{
			OnModelName = original.OnModelName;
			OffModelName = original.OffModelName;
		}

		public LeverModelSpec()
		{
		}
	}
}
