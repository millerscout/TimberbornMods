using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.AutomationBuildings
{
	public record PinnedLeverModified(Lever Lever)
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PinnedLeverModified);
			}
		}

		public PinnedLeverModified(Lever Lever)
		{
			this.Lever = ;
			base._002Ector();
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PinnedLeverModified");
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
			builder.Append("Lever = ");
			builder.Append((object)Lever);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<Lever>.Default.GetHashCode(Lever);
		}

		[CompilerGenerated]
		public virtual bool Equals(PinnedLeverModified? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract)
				{
					return EqualityComparer<Lever>.Default.Equals(Lever, other!.Lever);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PinnedLeverModified(PinnedLeverModified original)
		{
			Lever = original.Lever;
		}
	}
}
