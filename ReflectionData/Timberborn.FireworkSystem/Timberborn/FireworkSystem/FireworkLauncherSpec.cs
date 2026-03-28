using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.FireworkSystem
{
	internal record FireworkLauncherSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(FireworkLauncherSpec);
			}
		}

		[Serialize]
		public string Turret { get; init; }

		[Serialize]
		public string Barrel { get; init; }

		[Serialize]
		public string GoodId { get; init; }

		[Serialize]
		public int GoodAmount { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("FireworkLauncherSpec");
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
			builder.Append("Turret = ");
			builder.Append((object)Turret);
			builder.Append(", Barrel = ");
			builder.Append((object)Barrel);
			builder.Append(", GoodId = ");
			builder.Append((object)GoodId);
			builder.Append(", GoodAmount = ");
			builder.Append(GoodAmount.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Turret)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Barrel)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GoodId)) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(GoodAmount);
		}

		[CompilerGenerated]
		public virtual bool Equals(FireworkLauncherSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Turret, other!.Turret) && EqualityComparer<string>.Default.Equals(Barrel, other!.Barrel) && EqualityComparer<string>.Default.Equals(GoodId, other!.GoodId))
				{
					return EqualityComparer<int>.Default.Equals(GoodAmount, other!.GoodAmount);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected FireworkLauncherSpec(FireworkLauncherSpec original)
			: base(original)
		{
			Turret = original.Turret;
			Barrel = original.Barrel;
			GoodId = original.GoodId;
			GoodAmount = original.GoodAmount;
		}

		public FireworkLauncherSpec()
		{
		}
	}
}
