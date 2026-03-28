using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.EnterableSystem
{
	internal record EnterableAnimationControllerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(EnterableAnimationControllerSpec);
			}
		}

		[Serialize]
		public bool ResetAnimationUponExit { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("EnterableAnimationControllerSpec");
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
			builder.Append("ResetAnimationUponExit = ");
			builder.Append(ResetAnimationUponExit.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(ResetAnimationUponExit);
		}

		[CompilerGenerated]
		public virtual bool Equals(EnterableAnimationControllerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<bool>.Default.Equals(ResetAnimationUponExit, other!.ResetAnimationUponExit);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected EnterableAnimationControllerSpec(EnterableAnimationControllerSpec original)
			: base(original)
		{
			ResetAnimationUponExit = original.ResetAnimationUponExit;
		}

		public EnterableAnimationControllerSpec()
		{
		}
	}
}
