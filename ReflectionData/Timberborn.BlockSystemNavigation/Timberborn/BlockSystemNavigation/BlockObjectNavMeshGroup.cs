using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.BlockSystemNavigation
{
	internal record BlockObjectNavMeshGroup
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BlockObjectNavMeshGroup);
			}
		}

		[Serialize]
		public bool UseGroup { get; init; }

		[Serialize]
		public string GroupName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BlockObjectNavMeshGroup");
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
			builder.Append("UseGroup = ");
			builder.Append(UseGroup.ToString());
			builder.Append(", GroupName = ");
			builder.Append((object)GroupName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(UseGroup)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GroupName);
		}

		[CompilerGenerated]
		public virtual bool Equals(BlockObjectNavMeshGroup? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<bool>.Default.Equals(UseGroup, other!.UseGroup))
				{
					return EqualityComparer<string>.Default.Equals(GroupName, other!.GroupName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BlockObjectNavMeshGroup(BlockObjectNavMeshGroup original)
		{
			UseGroup = original.UseGroup;
			GroupName = original.GroupName;
		}

		public BlockObjectNavMeshGroup()
		{
		}
	}
}
