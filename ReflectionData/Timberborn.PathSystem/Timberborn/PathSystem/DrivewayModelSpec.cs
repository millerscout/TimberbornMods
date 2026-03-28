using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.Coordinates;
using UnityEngine;

namespace Timberborn.PathSystem
{
	internal record DrivewayModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DrivewayModelSpec);
			}
		}

		[Serialize]
		public Driveway Driveway { get; init; }

		[Serialize]
		public bool HasCustomCoordinates { get; init; }

		[Serialize]
		public Vector3Int CustomCoordinates { get; init; }

		[Serialize]
		public Direction2D CustomDirection { get; init; }

		[Serialize]
		public DrivewayMode DrivewayMode { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DrivewayModelSpec");
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
			builder.Append("Driveway = ");
			builder.Append(Driveway.ToString());
			builder.Append(", HasCustomCoordinates = ");
			builder.Append(HasCustomCoordinates.ToString());
			builder.Append(", CustomCoordinates = ");
			builder.Append(CustomCoordinates.ToString());
			builder.Append(", CustomDirection = ");
			builder.Append(CustomDirection.ToString());
			builder.Append(", DrivewayMode = ");
			builder.Append(DrivewayMode.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((base.GetHashCode() * -1521134295 + EqualityComparer<Driveway>.Default.GetHashCode(Driveway)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(HasCustomCoordinates)) * -1521134295 + EqualityComparer<Vector3Int>.Default.GetHashCode(CustomCoordinates)) * -1521134295 + EqualityComparer<Direction2D>.Default.GetHashCode(CustomDirection)) * -1521134295 + EqualityComparer<DrivewayMode>.Default.GetHashCode(DrivewayMode);
		}

		[CompilerGenerated]
		public virtual bool Equals(DrivewayModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Driveway>.Default.Equals(Driveway, other!.Driveway) && EqualityComparer<bool>.Default.Equals(HasCustomCoordinates, other!.HasCustomCoordinates) && EqualityComparer<Vector3Int>.Default.Equals(CustomCoordinates, other!.CustomCoordinates) && EqualityComparer<Direction2D>.Default.Equals(CustomDirection, other!.CustomDirection))
				{
					return EqualityComparer<DrivewayMode>.Default.Equals(DrivewayMode, other!.DrivewayMode);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DrivewayModelSpec(DrivewayModelSpec original)
			: base(original)
		{
			Driveway = original.Driveway;
			HasCustomCoordinates = original.HasCustomCoordinates;
			CustomCoordinates = original.CustomCoordinates;
			CustomDirection = original.CustomDirection;
			DrivewayMode = original.DrivewayMode;
		}

		public DrivewayModelSpec()
		{
		}
	}
}
