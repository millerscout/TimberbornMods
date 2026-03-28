using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;
using Timberborn.LocalizationSerialization;

namespace Timberborn.WorkerTypes
{
	public record WorkerTypeSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WorkerTypeSpec);
			}
		}

		[Serialize]
		public string Id { get; init; }

		[Serialize]
		public ImmutableArray<string> BackwardCompatibleIds { get; init; }

		[Serialize("DisplayNameLocKey")]
		public LocalizedText DisplayName { get; init; }

		[Serialize("WorkerOnlyTextLocKey")]
		public LocalizedText WorkerOnlyText { get; init; }

		[Serialize]
		public bool IgnoresWorkingHours { get; init; }

		[Serialize]
		private string DisplayNameLocKey { get; init; }

		[Serialize]
		private string WorkerOnlyTextLocKey { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WorkerTypeSpec");
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
			builder.Append("Id = ");
			builder.Append((object)Id);
			builder.Append(", BackwardCompatibleIds = ");
			builder.Append(BackwardCompatibleIds.ToString());
			builder.Append(", DisplayName = ");
			builder.Append(DisplayName);
			builder.Append(", WorkerOnlyText = ");
			builder.Append(WorkerOnlyText);
			builder.Append(", IgnoresWorkingHours = ");
			builder.Append(IgnoresWorkingHours.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return ((((((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id)) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(BackwardCompatibleIds)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(DisplayName)) * -1521134295 + EqualityComparer<LocalizedText>.Default.GetHashCode(WorkerOnlyText)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(IgnoresWorkingHours)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DisplayNameLocKey)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WorkerOnlyTextLocKey);
		}

		[CompilerGenerated]
		public virtual bool Equals(WorkerTypeSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(Id, other!.Id) && EqualityComparer<ImmutableArray<string>>.Default.Equals(BackwardCompatibleIds, other!.BackwardCompatibleIds) && EqualityComparer<LocalizedText>.Default.Equals(DisplayName, other!.DisplayName) && EqualityComparer<LocalizedText>.Default.Equals(WorkerOnlyText, other!.WorkerOnlyText) && EqualityComparer<bool>.Default.Equals(IgnoresWorkingHours, other!.IgnoresWorkingHours) && EqualityComparer<string>.Default.Equals(DisplayNameLocKey, other!.DisplayNameLocKey))
				{
					return EqualityComparer<string>.Default.Equals(WorkerOnlyTextLocKey, other!.WorkerOnlyTextLocKey);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WorkerTypeSpec(WorkerTypeSpec original)
			: base(original)
		{
			Id = original.Id;
			BackwardCompatibleIds = original.BackwardCompatibleIds;
			DisplayName = original.DisplayName;
			WorkerOnlyText = original.WorkerOnlyText;
			IgnoresWorkingHours = original.IgnoresWorkingHours;
			DisplayNameLocKey = original.DisplayNameLocKey;
			WorkerOnlyTextLocKey = original.WorkerOnlyTextLocKey;
		}

		public WorkerTypeSpec()
		{
		}
	}
}
