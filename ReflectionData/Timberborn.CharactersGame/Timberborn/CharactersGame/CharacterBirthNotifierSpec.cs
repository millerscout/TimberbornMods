using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CharactersGame
{
	internal record CharacterBirthNotifierSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CharacterBirthNotifierSpec);
			}
		}

		[Serialize]
		public string NotificationLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CharacterBirthNotifierSpec");
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
			builder.Append("NotificationLocKey = ");
			builder.Append((object)NotificationLocKey);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NotificationLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(CharacterBirthNotifierSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<string>.Default.Equals(NotificationLocKey, other!.NotificationLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CharacterBirthNotifierSpec(CharacterBirthNotifierSpec original)
			: base(original)
		{
			NotificationLocKey = original.NotificationLocKey;
		}

		public CharacterBirthNotifierSpec()
		{
		}
	}
}
