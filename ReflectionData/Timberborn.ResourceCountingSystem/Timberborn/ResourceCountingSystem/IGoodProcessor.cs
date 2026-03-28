using Timberborn.Goods;
using Timberborn.InventorySystem;

namespace Timberborn.ResourceCountingSystem
{
	public interface IGoodProcessor
	{
		Inventory Inventory { get; }

		GoodRegistry GetProcessingGoods();
	}
}
