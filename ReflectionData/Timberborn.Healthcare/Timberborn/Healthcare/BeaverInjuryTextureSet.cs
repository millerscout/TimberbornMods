using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Healthcare
{
	internal record BeaverInjuryTextureSet
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(BeaverInjuryTextureSet);
			}
		}

		[Serialize]
		public string DiffusePath { get; init; }

		[Serialize]
		public string NormalMapPath { get; init; }

		[Serialize]
		public string DisplacementPath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("BeaverInjuryTextureSet");
			stringBuilder.Append(" { ");
			if (PrintMembers(stringBuilder))
			{
				stringBuilder.Append(' ');
			}
			stringBuilder.Append('}');
			return stringBuilder.ToString();
		}

		[CompilerGenerated]
		protected virtual bool PrintMembers(StringBuilder builder)
		{
			RuntimeHelpers.EnsureSufficientExecutionStack();
			builder.Append("DiffusePath = ");
			builder.Append((object)DiffusePath);
			builder.Append(", NormalMapPath = ");
			builder.Append((object)NormalMapPath);
			builder.Append(", DisplacementPath = ");
			builder.Append((object)DisplacementPath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DiffusePath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NormalMapPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplacementPath);
		}

		[CompilerGenerated]
		public virtual bool Equals(BeaverInjuryTextureSet? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(DiffusePath, other!.DiffusePath) && EqualityComparer<string>.Default.Equals(NormalMapPath, other!.NormalMapPath))
				{
					return EqualityComparer<string>.Default.Equals(DisplacementPath, other!.DisplacementPath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected BeaverInjuryTextureSet(BeaverInjuryTextureSet original)
		{
			DiffusePath = original.DiffusePath;
			NormalMapPath = original.NormalMapPath;
			DisplacementPath = original.DisplacementPath;
		}

		public BeaverInjuryTextureSet()
		{
		}
	}
}
