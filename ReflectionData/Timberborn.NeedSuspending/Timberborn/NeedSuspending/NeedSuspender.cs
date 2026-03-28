using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BaseComponentSystem;
using Timberborn.BlueprintSystem;
using Timberborn.NeedSystem;

namespace Timberborn.NeedSuspending
{
	internal record NeedSuspender
	{
		[CompilerGenerated]
		protected virtual Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(NeedSuspender);
			}
		}

		[Serialize]
		public ImmutableArray<string> SuspendableNeedIds { get; init; }

		public void SuspendNeeds(BaseComponent component)
		{
			UpdateNeedSuspensions(component, shouldSuspend: true);
		}

		public void ResumeNeeds(BaseComponent component)
		{
			UpdateNeedSuspensions(component, shouldSuspend: false);
		}

		private void UpdateNeedSuspensions(BaseComponent component, bool shouldSuspend)
		{
			NeedManager component2 = component.GetComponent<NeedManager>();
			if (component2 == null)
			{
				return;
			}
			ImmutableArray<string>.Enumerator enumerator = SuspendableNeedIds.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				if (shouldSuspend)
				{
					component2.DisableUpdate(current);
				}
				else
				{
					component2.EnableUpdate(current);
				}
			}
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("NeedSuspender");
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
			builder.Append("SuspendableNeedIds = ");
			builder.Append(SuspendableNeedIds.ToString());
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<ImmutableArray<string>>.Default.GetHashCode(SuspendableNeedIds);
		}

		[CompilerGenerated]
		public virtual bool Equals(NeedSuspender? other)
		{
			if ((object)this != other)
			{
				if ((object)other != null && EqualityContract == other!.EqualityContract)
				{
					return EqualityComparer<ImmutableArray<string>>.Default.Equals(SuspendableNeedIds, other!.SuspendableNeedIds);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected NeedSuspender(NeedSuspender original)
		{
			SuspendableNeedIds = original.SuspendableNeedIds;
		}

		public NeedSuspender()
		{
		}
	}
}
