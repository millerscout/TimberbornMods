using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.BlueprintSystem;

namespace Timberborn.WalkingSystemUI
{
	internal record WalkerDebuggerSpec : ComponentSpec
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(WalkerDebuggerSpec);
			}
		}

		[Serialize]
		public string WalkerGameObjectMarkerPath { get; init; }

		[Serialize]
		public string WalkerModelMarkerPath { get; init; }

		[Serialize]
		public string DestinationMarkerPath { get; init; }

		[Serialize]
		public string CornerMarkerPath { get; init; }

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("WalkerDebuggerSpec");
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
			builder.Append("WalkerGameObjectMarkerPath = ");
			builder.Append((object)WalkerGameObjectMarkerPath);
			builder.Append(", WalkerModelMarkerPath = ");
			builder.Append((object)WalkerModelMarkerPath);
			builder.Append(", DestinationMarkerPath = ");
			builder.Append((object)DestinationMarkerPath);
			builder.Append(", CornerMarkerPath = ");
			builder.Append((object)CornerMarkerPath);
			return true;
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (((base.GetHashCode() * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WalkerGameObjectMarkerPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(WalkerModelMarkerPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DestinationMarkerPath)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CornerMarkerPath);
		}

		[CompilerGenerated]
		public virtual bool Equals(WalkerDebuggerSpec? other)
		{
			if ((object)this != other)
			{
				if (base.Equals(other) && EqualityComparer<string>.Default.Equals(WalkerGameObjectMarkerPath, other!.WalkerGameObjectMarkerPath) && EqualityComparer<string>.Default.Equals(WalkerModelMarkerPath, other!.WalkerModelMarkerPath) && EqualityComparer<string>.Default.Equals(DestinationMarkerPath, other!.DestinationMarkerPath))
				{
					return EqualityComparer<string>.Default.Equals(CornerMarkerPath, other!.CornerMarkerPath);
				}
				return false;
			}
			return true;
		}

		[CompilerGenerated]
		protected WalkerDebuggerSpec(WalkerDebuggerSpec original)
			: base(original)
		{
			WalkerGameObjectMarkerPath = original.WalkerGameObjectMarkerPath;
			WalkerModelMarkerPath = original.WalkerModelMarkerPath;
			DestinationMarkerPath = original.DestinationMarkerPath;
			CornerMarkerPath = original.CornerMarkerPath;
		}

		public WalkerDebuggerSpec()
		{
		}
	}
}
