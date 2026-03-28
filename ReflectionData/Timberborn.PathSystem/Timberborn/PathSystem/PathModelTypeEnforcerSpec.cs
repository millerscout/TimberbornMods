using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.PathSystem
{
	internal record PathModelTypeEnforcerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PathModelTypeEnforcerSpec);
			}
		}

		[Serialize]
		public PathModelType PathModelType { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PathModelTypeEnforcerSpec");
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
			builder.Append("PathModelType = ");
			builder.Append(PathModelType.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode() * -1521134295 + EqualityComparer<PathModelType>.Default.GetHashCode(PathModelType);
		}

		[CompilerGenerated]
		public virtual bool Equals(PathModelTypeEnforcerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other))
				{
					return EqualityComparer<PathModelType>.Default.Equals(PathModelType, other!.PathModelType);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PathModelTypeEnforcerSpec(PathModelTypeEnforcerSpec original)
			: base(original)
		{
			PathModelType = original.PathModelType;
		}

		public PathModelTypeEnforcerSpec()
		{
		}
	}
}
