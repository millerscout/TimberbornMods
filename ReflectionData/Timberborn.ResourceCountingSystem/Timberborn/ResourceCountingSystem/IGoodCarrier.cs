using Timberborn.Goods;

namespace Timberborn.ResourceCountingSystem
{
	public interface IGoodCarrier
	{
		bool CountGoodsAsAvailable { get; }

		bool IsCarrying { get; }

		GoodAmount CarriedGoods { get; }
	}
}
