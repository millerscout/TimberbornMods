using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WonderPlanes
{
	internal record PlaneSpawnerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlaneSpawnerSpec);
			}
		}

		[Serialize]
		public string SpawnPointName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlaneSpawnerSpec");
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
			builder.Append("SpawnPointName = ");
			builder.Append((object)SpawnPointName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SpawnPointName);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlaneSpawnerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(SpawnPointName, other!.SpawnPointName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlaneSpawnerSpec(PlaneSpawnerSpec original)
			: base(original)
		{
			SpawnPointName = original.SpawnPointName;
		}

		public PlaneSpawnerSpec()
		{
		}
	}
}
