using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Healthcare
{
	internal record BeaverInjuryTextureSetterSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BeaverInjuryTextureSetterSpec);
			}
		}

		[Serialize]
		public ImmutableArray<BeaverInjuryTextureSet> InjuryTextureSets { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BeaverInjuryTextureSetterSpec");
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
			builder.Append("InjuryTextureSets = ");
			builder.Append(InjuryTextureSets.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<BeaverInjuryTextureSet>>.Default.GetHashCode(InjuryTextureSets);
		}

		[CompilerGenerated]
		public virtual bool Equals(BeaverInjuryTextureSetterSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<BeaverInjuryTextureSet>>.Default.Equals(InjuryTextureSets, other!.InjuryTextureSets);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BeaverInjuryTextureSetterSpec(BeaverInjuryTextureSetterSpec original)
			: base(original)
		{
			InjuryTextureSets = original.InjuryTextureSets;
		}

		public BeaverInjuryTextureSetterSpec()
		{
		}
	}
}
