using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.GameDistrictsUI
{
	public record ConnectionAnchorPointSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(ConnectionAnchorPointSpec);
			}
		}

		[Serialize]
		public Vector3 Position { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ConnectionAnchorPointSpec");
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
			builder.Append("Position = ");
			builder.Append(Position.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Position);
		}

		[CompilerGenerated]
		public virtual bool Equals(ConnectionAnchorPointSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<Vector3>.Default.Equals(Position, other!.Position);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected ConnectionAnchorPointSpec(ConnectionAnchorPointSpec original)
			: base(original)
		{
			Position = original.Position;
		}

		public ConnectionAnchorPointSpec()
		{
		}
	}
}
