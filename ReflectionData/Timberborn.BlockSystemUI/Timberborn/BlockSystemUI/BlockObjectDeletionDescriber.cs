using System.Collections.Generic;
using System.Text;
using Timberborn.BaseComponentSystem;
using Timberborn.BlockSystem;
using Timberborn.Localization;

namespace Timberborn.BlockSystemUI
{
	public class BlockObjectDeletionDescriber : BaseComponent, IAwakableComponent
	{
		private static readonly string PrefixLocKey = "DeletionBlocker.Prefix";

		private static readonly string DemolishTooltipLocKey = "Demolish.Mark";

		private readonly ILoc _loc;

		private readonly List<IBlockObjectDeletionBlocker> _deletionBlockers = new List<IBlockObjectDeletionBlocker>();

		private readonly StringBuilder _descriptionBuilder = new StringBuilder();

		public BlockObjectDeletionDescriber(ILoc loc)
		{
			_loc = loc;
		}

		public void Awake()
		{
			GetComponents(_deletionBlockers);
		}

		public string GetDescription()
		{
			_descriptionBuilder.Clear();
			foreach (IBlockObjectDeletionBlocker deletionBlocker in _deletionBlockers)
			{
				if (deletionBlocker.IsDeletionBlocked)
				{
					_descriptionBuilder.Append(" " + _loc.T(deletionBlocker.ReasonLocKey));
				}
			}
			if (_descriptionBuilder.Length <= 0)
			{
				return _loc.T(DemolishTooltipLocKey);
			}
			return $"{_loc.T(PrefixLocKey)}{_descriptionBuilder}";
		}
	}
}
