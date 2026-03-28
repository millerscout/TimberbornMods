using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.TutorialSteps
{
	internal record GameSpeedStepSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GameSpeedStepSpec);
			}
		}

		[Serialize]
		public int Speed { get; init; }

		[Serialize]
		public bool OnlyOnce { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GameSpeedStepSpec");
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
			builder.Append("Speed = ");
			builder.Append(Speed.ToString());
			builder.Append(", OnlyOnce = ");
			builder.Append(OnlyOnce.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Speed)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(OnlyOnce);
		}

		[CompilerGenerated]
		public virtual bool Equals(GameSpeedStepSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<int>.Default.Equals(Speed, other!.Speed))
				{
					return EqualityComparer<bool>.Default.Equals(OnlyOnce, other!.OnlyOnce);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GameSpeedStepSpec(GameSpeedStepSpec original)
			: base(original)
		{
			Speed = original.Speed;
			OnlyOnce = original.OnlyOnce;
		}

		public GameSpeedStepSpec()
		{
		}
	}
}
