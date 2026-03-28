using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GameDistrictsMigration
{
	internal record MigrationCoordinatorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MigrationCoordinatorSpec);
			}
		}

		[Serialize]
		public int MaxAutomaticMigration { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MigrationCoordinatorSpec");
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
			builder.Append("MaxAutomaticMigration = ");
			builder.Append(MaxAutomaticMigration.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(MaxAutomaticMigration);
		}

		[CompilerGenerated]
		public virtual bool Equals(MigrationCoordinatorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<int>.Default.Equals(MaxAutomaticMigration, other!.MaxAutomaticMigration);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MigrationCoordinatorSpec(MigrationCoordinatorSpec original)
			: base(original)
		{
			MaxAutomaticMigration = original.MaxAutomaticMigration;
		}

		public MigrationCoordinatorSpec()
		{
		}
	}
}
