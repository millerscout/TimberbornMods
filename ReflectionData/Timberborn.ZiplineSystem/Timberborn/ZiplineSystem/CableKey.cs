using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.EntitySystem;

namespace Timberborn.ZiplineSystem
{
	internal record CableKey
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CableKey);
			}
		}

		public ZiplineTower ZiplineTower { get; private init; }

		public ZiplineTower OtherZiplineTower { get; private init; }

		public static CableKey Create(ZiplineTower ziplineTower, ZiplineTower otherZiplineTower)
		{
			Guid entityId = ziplineTower.GetComponent<EntityComponent>().EntityId;
			Guid entityId2 = otherZiplineTower.GetComponent<EntityComponent>().EntityId;
			if (entityId.CompareTo(entityId2) <= 0)
			{
				return new CableKey
				{
					ZiplineTower = otherZiplineTower,
					OtherZiplineTower = ziplineTower
				};
			}
			return new CableKey
			{
				ZiplineTower = ziplineTower,
				OtherZiplineTower = otherZiplineTower
			};
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CableKey");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("ZiplineTower = ");
			builder.Append((object)ZiplineTower);
			builder.Append(", OtherZiplineTower = ");
			builder.Append((object)OtherZiplineTower);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ZiplineTower>.Default.GetHashCode(ZiplineTower)) * -1521134295 + EqualityComparer<ZiplineTower>.Default.GetHashCode(OtherZiplineTower);
		}

		[CompilerGenerated]
		public virtual bool Equals(CableKey? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<ZiplineTower>.Default.Equals(ZiplineTower, other!.ZiplineTower))
				{
					return EqualityComparer<ZiplineTower>.Default.Equals(OtherZiplineTower, other!.OtherZiplineTower);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CableKey(CableKey original)
		{
			ZiplineTower = original.ZiplineTower;
			OtherZiplineTower = original.OtherZiplineTower;
		}

		public CableKey()
		{
		}
	}
}
