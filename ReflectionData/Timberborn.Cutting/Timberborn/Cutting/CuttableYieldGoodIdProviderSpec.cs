using System;
using System.Runtime.CompilerServices;
using System.Text;
using JetBrains.Annotations;
using Timberborn.BlueprintSystem;
using Timberborn.Planting;

namespace Timberborn.Cutting
{
	[UsedImplicitly]
	internal record CuttableYieldGoodIdProviderSpec : ComponentSpec, IPlantableGoodIdProvider
	{
		[CompilerGenerated]
		protected override Type EqualityContract
		{
			[CompilerGenerated]
			get
			{
				return typeof(CuttableYieldGoodIdProviderSpec);
			}
		}

		public string GetGoodId()
		{
			return GetSpec<CuttableSpec>().Yielder.Yield.Id;
		}

		[CompilerGenerated]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CuttableYieldGoodIdProviderSpec");
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
			return base.PrintMembers(builder);
		}

		[CompilerGenerated]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[CompilerGenerated]
		public virtual bool Equals(CuttableYieldGoodIdProviderSpec? other)
		{
			if ((object)this != other)
			{
				return base.Equals(other);
			}
			return true;
		}

		[CompilerGenerated]
		protected CuttableYieldGoodIdProviderSpec(CuttableYieldGoodIdProviderSpec original)
			: base(original)
		{
		}

		public CuttableYieldGoodIdProviderSpec()
		{
		}
	}
}
