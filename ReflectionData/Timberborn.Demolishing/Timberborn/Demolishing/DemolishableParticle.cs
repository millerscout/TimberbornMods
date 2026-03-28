using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.Demolishing
{
	internal record DemolishableParticle
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(DemolishableParticle);
			}
		}

		[Serialize]
		public string AttachmentId { get; init; }

		[Serialize]
		public ImmutableArray<string> TemplateNames { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("DemolishableParticle");
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
			builder.Append("AttachmentId = ");
			builder.Append((object)AttachmentId);
			builder.Append(", TemplateNames = ");
			builder.Append(TemplateNames.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AttachmentId)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(TemplateNames);
		}

		[CompilerGenerated]
		public virtual bool Equals(DemolishableParticle? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<string>.Default.Equals(AttachmentId, other!.AttachmentId))
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(TemplateNames, other!.TemplateNames);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected DemolishableParticle(DemolishableParticle original)
		{
			AttachmentId = original.AttachmentId;
			TemplateNames = original.TemplateNames;
		}

		public DemolishableParticle()
		{
		}
	}
}
