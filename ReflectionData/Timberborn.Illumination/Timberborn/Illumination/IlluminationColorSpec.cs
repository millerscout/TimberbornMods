using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using UnityEngine;

namespace Timberborn.Illumination
{
	internal record IlluminationColorSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(IlluminationColorSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public Color Color { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("IlluminationColorSpec");
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
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", Color = ");
			builder.Append(Color.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<Color>.Default.GetHashCode(Color);
		}

		[CompilerGenerated]
		public virtual bool Equals(IlluminationColorSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id))
				{
					return EqualityComparer<Color>.Default.Equals(Color, other!.Color);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected IlluminationColorSpec(IlluminationColorSpec original)
			: base(original)
		{
			Id = original.Id;
			Color = original.Color;
		}

		public IlluminationColorSpec()
		{
		}
	}
}
