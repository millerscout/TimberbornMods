using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.AutomationBuildings
{
	internal record GateSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GateSpec);
			}
		}

		[Serialize]
		public Vector3Int Start { get; init; }

		[Serialize]
		public Vector3Int End { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GateSpec");
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
			builder.Append("Start = ");
			builder.Append(Start.ToString());
			builder.Append(", End = ");
			builder.Append(End.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(Start)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(End);
		}

		[CompilerGenerated]
		public virtual bool Equals(GateSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3Int>.Default.Equals(Start, other!.Start))
				{
					return EqualityComparer<Vector3Int>.Default.Equals(End, other!.End);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GateSpec(GateSpec original)
			: base(original)
		{
			Start = original.Start;
			End = original.End;
		}

		public GateSpec()
		{
		}
	}
}
