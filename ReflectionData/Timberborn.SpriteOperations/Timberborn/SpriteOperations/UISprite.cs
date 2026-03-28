using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

namespace Timberborn.SpriteOperations
{
	public record UISprite(Sprite Value)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(UISprite);
			}
		}

		public UISprite(Sprite Value)
		{
			this.Value = ;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("UISprite");
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
		public virtual bool Equals(UISprite? other)
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
		protected UISprite(UISprite original)
		{
			Value = original.Value;
		}
	}
}
