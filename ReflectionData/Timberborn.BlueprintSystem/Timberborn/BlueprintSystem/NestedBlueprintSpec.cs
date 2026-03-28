using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Timberborn.BlueprintSystem
{
	public record NestedBlueprintSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NestedBlueprintSpec);
			}
		}

		[Serialize]
		public string BlueprintPath { get; init; }

		[Serialize]
		public string Modification { get; init; }

		public static readonly string BlueprintPathKey = "BlueprintPath";

		public static readonly string ModificationKey = "Modification";

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NestedBlueprintSpec");
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
			builder.Append("BlueprintPath = ");
			builder.Append((object)BlueprintPath);
			builder.Append(", Modification = ");
			builder.Append((object)Modification);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BlueprintPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Modification);
		}

		[CompilerGenerated]
		public virtual bool Equals(NestedBlueprintSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(BlueprintPath, other!.BlueprintPath))
				{
					return EqualityComparer<string>.Default.Equals(Modification, other!.Modification);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NestedBlueprintSpec(NestedBlueprintSpec original)
			: base(original)
		{
			BlueprintPath = original.BlueprintPath;
			Modification = original.Modification;
		}

		public NestedBlueprintSpec()
		{
		}
	}
}
