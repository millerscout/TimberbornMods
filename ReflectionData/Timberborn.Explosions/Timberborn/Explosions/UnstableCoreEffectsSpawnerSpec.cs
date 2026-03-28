using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Explosions
{
	internal record UnstableCoreEffectsSpawnerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UnstableCoreEffectsSpawnerSpec);
			}
		}

		[Serialize]
		public string ExplosionPrefabPath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UnstableCoreEffectsSpawnerSpec");
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
			builder.Append("ExplosionPrefabPath = ");
			builder.Append((object)ExplosionPrefabPath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ExplosionPrefabPath);
		}

		[CompilerGenerated]
		public virtual bool Equals(UnstableCoreEffectsSpawnerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(ExplosionPrefabPath, other!.ExplosionPrefabPath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected UnstableCoreEffectsSpawnerSpec(UnstableCoreEffectsSpawnerSpec original)
			: base(original)
		{
			ExplosionPrefabPath = original.ExplosionPrefabPath;
		}

		public UnstableCoreEffectsSpawnerSpec()
		{
		}
	}
}
