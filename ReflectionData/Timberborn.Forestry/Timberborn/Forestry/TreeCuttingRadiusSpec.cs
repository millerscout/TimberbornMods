using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Forestry
{
	internal record TreeCuttingRadiusSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TreeCuttingRadiusSpec);
			}
		}

		[Serialize]
		public float Radius { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TreeCuttingRadiusSpec");
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
			builder.Append("Radius = ");
			builder.Append(Radius.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<float>.Default.GetHashCode(Radius);
		}

		[CompilerGenerated]
		public virtual bool Equals(TreeCuttingRadiusSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<float>.Default.Equals(Radius, other!.Radius);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TreeCuttingRadiusSpec(TreeCuttingRadiusSpec original)
			: base(original)
		{
			Radius = original.Radius;
		}

		public TreeCuttingRadiusSpec()
		{
		}
	}
}
