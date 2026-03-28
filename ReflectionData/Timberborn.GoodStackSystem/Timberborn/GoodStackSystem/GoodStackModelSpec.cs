using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.GoodStackSystem
{
	internal record GoodStackModelSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(GoodStackModelSpec);
			}
		}

		[Serialize]
		public string LogObjectName { get; init; }

		[Serialize]
		public string BarrelObjectName { get; init; }

		[Serialize]
		public string BoxObjectName { get; init; }

		[Serialize]
		public string BagObjectName { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GoodStackModelSpec");
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
			builder.Append("LogObjectName = ");
			builder.Append((object)LogObjectName);
			builder.Append(", BarrelObjectName = ");
			builder.Append((object)BarrelObjectName);
			builder.Append(", BoxObjectName = ");
			builder.Append((object)BoxObjectName);
			builder.Append(", BagObjectName = ");
			builder.Append((object)BagObjectName);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LogObjectName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BarrelObjectName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BoxObjectName)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(BagObjectName);
		}

		[CompilerGenerated]
		public virtual bool Equals(GoodStackModelSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(LogObjectName, other!.LogObjectName) && EqualityComparer<string>.Default.Equals(BarrelObjectName, other!.BarrelObjectName) && EqualityComparer<string>.Default.Equals(BoxObjectName, other!.BoxObjectName))
				{
					return EqualityComparer<string>.Default.Equals(BagObjectName, other!.BagObjectName);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected GoodStackModelSpec(GoodStackModelSpec original)
			: base(original)
		{
			LogObjectName = original.LogObjectName;
			BarrelObjectName = original.BarrelObjectName;
			BoxObjectName = original.BoxObjectName;
			BagObjectName = original.BagObjectName;
		}

		public GoodStackModelSpec()
		{
		}
	}
}
