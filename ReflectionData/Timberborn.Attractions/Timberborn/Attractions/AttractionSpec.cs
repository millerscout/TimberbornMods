using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.NeedSpecs;

namespace Timberborn.Attractions
{
	internal record AttractionSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(AttractionSpec);
			}
		}

		[Serialize]
		public ImmutableArray<ContinuousEffectSpec> Effects { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("AttractionSpec");
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
			builder.Append("Effects = ");
			builder.Append(Effects.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.GetHashCode(Effects);
		}

		[CompilerGenerated]
		public virtual bool Equals(AttractionSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<ImmutableArray<ContinuousEffectSpec>>.Default.Equals(Effects, other!.Effects);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected AttractionSpec(AttractionSpec original)
			: base(original)
		{
			Effects = original.Effects;
		}

		public AttractionSpec()
		{
		}
	}
}
