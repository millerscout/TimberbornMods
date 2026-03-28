using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WorkshopsEffects
{
	internal record ObservatoryAnimatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ObservatoryAnimatorSpec);
			}
		}

		[Serialize]
		public string DomeName { get; init; }

		[Serialize]
		public string TelescopeName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ObservatoryAnimatorSpec");
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
			builder.Append("DomeName = ");
			builder.Append((object)DomeName);
			builder.Append(", TelescopeName = ");
			builder.Append((object)TelescopeName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DomeName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TelescopeName);
		}

		[CompilerGenerated]
		public virtual bool Equals(ObservatoryAnimatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(DomeName, other!.DomeName))
				{
					return EqualityComparer<string>.Default.Equals(TelescopeName, other!.TelescopeName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ObservatoryAnimatorSpec(ObservatoryAnimatorSpec original)
			: base(original)
		{
			DomeName = original.DomeName;
			TelescopeName = original.TelescopeName;
		}

		public ObservatoryAnimatorSpec()
		{
		}
	}
}
