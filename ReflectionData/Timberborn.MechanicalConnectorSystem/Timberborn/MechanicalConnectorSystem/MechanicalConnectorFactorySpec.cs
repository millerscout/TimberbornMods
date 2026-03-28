using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.MechanicalConnectorSystem
{
	internal record MechanicalConnectorFactorySpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(MechanicalConnectorFactorySpec);
			}
		}

		[Serialize]
		public string MechanicalConnectorPrefabPath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("MechanicalConnectorFactorySpec");
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
			builder.Append("MechanicalConnectorPrefabPath = ");
			builder.Append((object)MechanicalConnectorPrefabPath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MechanicalConnectorPrefabPath);
		}

		[CompilerGenerated]
		public virtual bool Equals(MechanicalConnectorFactorySpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(MechanicalConnectorPrefabPath, other!.MechanicalConnectorPrefabPath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected MechanicalConnectorFactorySpec(MechanicalConnectorFactorySpec original)
			: base(original)
		{
			MechanicalConnectorPrefabPath = original.MechanicalConnectorPrefabPath;
		}

		public MechanicalConnectorFactorySpec()
		{
		}
	}
}
