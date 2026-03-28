using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.UnityEngineSpecs
{
	public record CollidersSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CollidersSpec);
			}
		}

		[Serialize]
		public ImmutableArray<BoxColliderSpec> BoxColliders { get; init; }

		[Serialize]
		public ImmutableArray<SphereColliderSpec> SphereColliders { get; init; }

		[Serialize]
		public ImmutableArray<CapsuleColliderSpec> CapsuleColliders { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CollidersSpec");
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
			builder.Append("BoxColliders = ");
			builder.Append(BoxColliders.ToString());
			builder.Append(", SphereColliders = ");
			builder.Append(SphereColliders.ToString());
			builder.Append(", CapsuleColliders = ");
			builder.Append(CapsuleColliders.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((base.GetHashCode() * -1521134295 + EqualityComparer<ImmutableArray<BoxColliderSpec>>.Default.GetHashCode(BoxColliders)) * -1521134295 + EqualityComparer<ImmutableArray<SphereColliderSpec>>.Default.GetHashCode(SphereColliders)) * -1521134295 + EqualityComparer<ImmutableArray<CapsuleColliderSpec>>.Default.GetHashCode(CapsuleColliders);
		}

		[CompilerGenerated]
		public virtual bool Equals(CollidersSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<ImmutableArray<BoxColliderSpec>>.Default.Equals(BoxColliders, other!.BoxColliders) && EqualityComparer<ImmutableArray<SphereColliderSpec>>.Default.Equals(SphereColliders, other!.SphereColliders))
				{
					return EqualityComparer<ImmutableArray<CapsuleColliderSpec>>.Default.Equals(CapsuleColliders, other!.CapsuleColliders);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CollidersSpec(CollidersSpec original)
			: base(original)
		{
			BoxColliders = original.BoxColliders;
			SphereColliders = original.SphereColliders;
			CapsuleColliders = original.CapsuleColliders;
		}

		public CollidersSpec()
		{
		}
	}
}
