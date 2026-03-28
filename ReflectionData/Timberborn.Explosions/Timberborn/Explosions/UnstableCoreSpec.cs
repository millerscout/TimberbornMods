using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Explosions
{
	internal record UnstableCoreSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UnstableCoreSpec);
			}
		}

		[Serialize]
		public int MinExplosionRadius { get; init; }

		[Serialize]
		public int MaxExplosionRadius { get; init; }

		[Serialize]
		public int DefaultExplosionRadius { get; init; }

		[Serialize]
		public float InnerRadius { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UnstableCoreSpec");
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
			builder.Append("MinExplosionRadius = ");
			builder.Append(MinExplosionRadius.ToString());
			builder.Append(", MaxExplosionRadius = ");
			builder.Append(MaxExplosionRadius.ToString());
			builder.Append(", DefaultExplosionRadius = ");
			builder.Append(DefaultExplosionRadius.ToString());
			builder.Append(", InnerRadius = ");
			builder.Append(InnerRadius.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MinExplosionRadius)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxExplosionRadius)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(DefaultExplosionRadius)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(InnerRadius);
		}

		[CompilerGenerated]
		public virtual bool Equals(UnstableCoreSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(MinExplosionRadius, other!.MinExplosionRadius) && EqualityComparer<int>.Default.Equals(MaxExplosionRadius, other!.MaxExplosionRadius) && EqualityComparer<int>.Default.Equals(DefaultExplosionRadius, other!.DefaultExplosionRadius))
				{
					return EqualityComparer<float>.Default.Equals(InnerRadius, other!.InnerRadius);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UnstableCoreSpec(UnstableCoreSpec original)
			: base(original)
		{
			MinExplosionRadius = original.MinExplosionRadius;
			MaxExplosionRadius = original.MaxExplosionRadius;
			DefaultExplosionRadius = original.DefaultExplosionRadius;
			InnerRadius = original.InnerRadius;
		}

		public UnstableCoreSpec()
		{
		}
	}
}
