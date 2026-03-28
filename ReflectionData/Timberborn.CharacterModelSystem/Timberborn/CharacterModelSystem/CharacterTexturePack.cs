using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.CharacterModelSystem
{
	internal record CharacterTexturePack
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CharacterTexturePack);
			}
		}

		[Serialize]
		public string DiffuseTexture { get; init; }

		[Serialize]
		public string EmissionTexture { get; init; }

		[Serialize]
		public string NormalTexture { get; init; }

		[Serialize]
		public string DisplacementTexture { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CharacterTexturePack");
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
			builder.Append("DiffuseTexture = ");
			builder.Append((object)DiffuseTexture);
			builder.Append(", EmissionTexture = ");
			builder.Append((object)EmissionTexture);
			builder.Append(", NormalTexture = ");
			builder.Append((object)NormalTexture);
			builder.Append(", DisplacementTexture = ");
			builder.Append((object)DisplacementTexture);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DiffuseTexture)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(EmissionTexture)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NormalTexture)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplacementTexture);
		}

		[CompilerGenerated]
		public virtual bool Equals(CharacterTexturePack? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(DiffuseTexture, other!.DiffuseTexture) && EqualityComparer<string>.Default.Equals(EmissionTexture, other!.EmissionTexture) && EqualityComparer<string>.Default.Equals(NormalTexture, other!.NormalTexture))
				{
					return EqualityComparer<string>.Default.Equals(DisplacementTexture, other!.DisplacementTexture);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected CharacterTexturePack(CharacterTexturePack original)
		{
			DiffuseTexture = original.DiffuseTexture;
			EmissionTexture = original.EmissionTexture;
			NormalTexture = original.NormalTexture;
			DisplacementTexture = original.DisplacementTexture;
		}

		public CharacterTexturePack()
		{
		}
	}
}
