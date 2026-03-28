using System.Collections.Generic;
using System.Collections.Immutable;
using Timberborn.CoreUI;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.TopBarSystem
{
	internal class ExtendableTopBarCounter : ITopBarCounter
	{
		private readonly ImmutableArray<TopBarCounterRow> _counterRows;

		private readonly Label _emptyCounterPlaceholder;

		private readonly Label _value;

		private int _previousSum = -1;

		public ExtendableTopBarCounter(IEnumerable<TopBarCounterRow> counterRows, Label emptyCounterPlaceholder, Label value)
		{
			_emptyCounterPlaceholder = emptyCounterPlaceholder;
			_value = value;
			_counterRows = counterRows.ToImmutableArray();
		}

		public void UpdateValues()
		{
			int stockSum = GetStockSum();
			if (_previousSum != stockSum)
			{
				_value.text = NumberFormatter.Format(stockSum);
				_emptyCounterPlaceholder.ToggleDisplayStyle(stockSum == 0);
				_previousSum = stockSum;
			}
		}

		private int GetStockSum()
		{
			int num = 0;
			ImmutableArray<TopBarCounterRow>.Enumerator enumerator = _counterRows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				TopBarCounterRow current = enumerator.Current;
				num += current.UpdateAndGetStock();
			}
			return num;
		}
	}
}
