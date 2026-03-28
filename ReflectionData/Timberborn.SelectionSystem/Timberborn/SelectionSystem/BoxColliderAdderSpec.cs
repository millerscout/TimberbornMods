using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.SelectionSystem
{
	internal record BoxColliderAdderSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BoxColliderAdderSpec);
			}
		}

		[Serialize]
		public string TargetName { get; init; }

		[Serialize]
		public Vector3 Center { get; init; }

		[Serialize]
		public Vector3 Size { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BoxColliderAdderSpec");
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
			builder.Append("TargetName = ");
			builder.Append((object)TargetName);
			builder.Append(", Center = ");
			builder.Append(Center.ToString());
			builder.Append(", Size = ");
			builder.Append(Size.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TargetName)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Center)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Size);
		}

		[CompilerGenerated]
		public virtual bool Equals(BoxColliderAdderSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(TargetName, other!.TargetName) && EqualityComparer<Vector3>.Default.Equals(Center, other!.Center))
				{
					return EqualityComparer<Vector3>.Default.Equals(Size, other!.Size);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BoxColliderAdderSpec(BoxColliderAdderSpec original)
			: base(original)
		{
			TargetName = original.TargetName;
			Center = original.Center;
			Size = original.Size;
		}

		public BoxColliderAdderSpec()
		{
		}
	}
}
