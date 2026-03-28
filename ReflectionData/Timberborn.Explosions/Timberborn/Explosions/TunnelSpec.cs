using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Explosions
{
	internal record TunnelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(TunnelSpec);
			}
		}

		[Serialize]
		public string ExplosionPrefabPath { get; init; }

		[Serialize]
		public string TunnelSupportTemplateName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TunnelSpec");
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
			builder.Append("ExplosionPrefabPath = ");
			builder.Append((object)ExplosionPrefabPath);
			builder.Append(", TunnelSupportTemplateName = ");
			builder.Append((object)TunnelSupportTemplateName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ExplosionPrefabPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TunnelSupportTemplateName);
		}

		[CompilerGenerated]
		public virtual bool Equals(TunnelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(ExplosionPrefabPath, other!.ExplosionPrefabPath))
				{
					return EqualityComparer<string>.Default.Equals(TunnelSupportTemplateName, other!.TunnelSupportTemplateName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected TunnelSpec(TunnelSpec original)
			: base(original)
		{
			ExplosionPrefabPath = original.ExplosionPrefabPath;
			TunnelSupportTemplateName = original.TunnelSupportTemplateName;
		}

		public TunnelSpec()
		{
		}
	}
}
