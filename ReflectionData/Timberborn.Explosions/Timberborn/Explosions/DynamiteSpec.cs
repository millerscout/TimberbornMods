using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Explosions
{
	internal record DynamiteSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DynamiteSpec);
			}
		}

		[Serialize]
		public int Depth { get; init; }

		[Serialize]
		public string ExplosionPrefabPath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DynamiteSpec");
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
			builder.Append("Depth = ");
			builder.Append(Depth.ToString());
			builder.Append(", ExplosionPrefabPath = ");
			builder.Append((object)ExplosionPrefabPath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Depth)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ExplosionPrefabPath);
		}

		[CompilerGenerated]
		public virtual bool Equals(DynamiteSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(Depth, other!.Depth))
				{
					return EqualityComparer<string>.Default.Equals(ExplosionPrefabPath, other!.ExplosionPrefabPath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DynamiteSpec(DynamiteSpec original)
			: base(original)
		{
			Depth = original.Depth;
			ExplosionPrefabPath = original.ExplosionPrefabPath;
		}

		public DynamiteSpec()
		{
		}
	}
}
