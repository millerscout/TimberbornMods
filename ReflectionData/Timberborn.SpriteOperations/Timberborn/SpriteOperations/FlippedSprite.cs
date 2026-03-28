using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace Timberborn.SpriteOperations
{
	public record FlippedSprite(Sprite Value)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FlippedSprite);
			}
		}

		public FlippedSprite(Sprite Value)
		{
			this.Value = ;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FlippedSprite");
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
			builder.Append("Value = ");
			builder.Append((object)Value);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Sprite>.Default.GetHashCode(Value);
		}

		[CompilerGenerated]
		public virtual bool Equals(FlippedSprite? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract)
				{
					return EqualityComparer<Sprite>.Default.Equals(Value, other!.Value);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FlippedSprite(FlippedSprite original)
		{
			Value = original.Value;
		}
	}
}
