using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.KeyBindingSystem
{
	public record InputBindingSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(InputBindingSpec);
			}
		}

		[Serialize]
		public string Path { get; init; }

		[Serialize]
		public InputModifiers InputModifiers { get; init; }

		[Serialize]
		public bool Unchangeable { get; init; }

		public bool IsDefined => !string.IsNullOrEmpty(Path);

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("InputBindingSpec");
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
			builder.Append("Path = ");
			builder.Append((object)Path);
			builder.Append(", InputModifiers = ");
			builder.Append(InputModifiers.ToString());
			builder.Append(", Unchangeable = ");
			builder.Append(Unchangeable.ToString());
			builder.Append(", IsDefined = ");
			builder.Append(IsDefined.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Path)) * -1521134295 + EqualityComparer<InputModifiers>.Default.GetHashCode(InputModifiers)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(Unchangeable);
		}

		[CompilerGenerated]
		public virtual bool Equals(InputBindingSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Path, other!.Path) && EqualityComparer<InputModifiers>.Default.Equals(InputModifiers, other!.InputModifiers))
				{
					return EqualityComparer<bool>.Default.Equals(Unchangeable, other!.Unchangeable);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected InputBindingSpec(InputBindingSpec original)
			: base(original)
		{
			Path = original.Path;
			InputModifiers = original.InputModifiers;
			Unchangeable = original.Unchangeable;
		}

		public InputBindingSpec()
		{
		}
	}
}
