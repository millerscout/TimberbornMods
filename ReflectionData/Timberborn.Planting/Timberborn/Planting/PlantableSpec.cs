using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.TemplateSystem;

namespace Timberborn.Planting
{
	public record PlantableSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(PlantableSpec);
			}
		}

		[Serialize]
		public string ResourceGroup { get; init; }

		[Serialize]
		public float PlantTimeInHours { get; init; }

		public string TemplateName => GetSpec<TemplateSpec>().TemplateName;

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlantableSpec");
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
			builder.Append("ResourceGroup = ");
			builder.Append((object)ResourceGroup);
			builder.Append(", PlantTimeInHours = ");
			builder.Append(PlantTimeInHours.ToString());
			builder.Append(", TemplateName = ");
			builder.Append((object)TemplateName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ResourceGroup)) * -1521134295 + EqualityComparer<float>.Default.GetHashCode(PlantTimeInHours);
		}

		[CompilerGenerated]
		public virtual bool Equals(PlantableSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(ResourceGroup, other!.ResourceGroup))
				{
					return EqualityComparer<float>.Default.Equals(PlantTimeInHours, other!.PlantTimeInHours);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected PlantableSpec(PlantableSpec original)
			: base(original)
		{
			ResourceGroup = original.ResourceGroup;
			PlantTimeInHours = original.PlantTimeInHours;
		}

		public PlantableSpec()
		{
		}
	}
}
