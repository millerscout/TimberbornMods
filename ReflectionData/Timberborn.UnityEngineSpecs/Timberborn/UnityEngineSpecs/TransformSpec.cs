using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.UnityEngineSpecs
{
	public record TransformSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TransformSpec);
			}
		}

		[Serialize]
		public Vector3 Position { get; init; }

		[Serialize]
		public Vector3 Rotation { get; init; }

		[Serialize]
		public Vector3 Scale { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TransformSpec");
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
			builder.Append(", Rotation = ");
			builder.Append(Rotation.ToString());
			builder.Append(", Scale = ");
			builder.Append(Scale.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Position)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Rotation)) * -1521134295 + EqualityComparer<Vector3>.Default.GetHashCode(Scale);
		}

		[CompilerGenerated]
		public virtual bool Equals(TransformSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<Vector3>.Default.Equals(Position, other!.Position) && EqualityComparer<Vector3>.Default.Equals(Rotation, other!.Rotation))
				{
					return EqualityComparer<Vector3>.Default.Equals(Scale, other!.Scale);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TransformSpec(TransformSpec original)
			: base(original)
		{
			Position = original.Position;
			Rotation = original.Rotation;
			Scale = original.Scale;
		}

		public TransformSpec()
		{
			Scale = Vector3.one;
			base._002Ector();
		}
	}
}
