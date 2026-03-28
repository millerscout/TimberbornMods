using System;
using Timberborn.Population;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.PopulationUI
{
	public class WorkplaceDataRow : IPopulationRow
	{
		private readonly Label _occupiedWorkslotCount;

		private readonly Label _freeWorkslotCount;

		private readonly Label _unemployedCount;

		private readonly Func<WorkplaceData> _workplaceDataGetter;

		public WorkplaceDataRow(Label occupiedWorkslotCount, Label freeWorkslotCount, Label unemployedCount, Func<WorkplaceData> workplaceDataGetter)
		{
			_occupiedWorkslotCount = occupiedWorkslotCount;
			_freeWorkslotCount = freeWorkslotCount;
			_unemployedCount = unemployedCount;
			_workplaceDataGetter = workplaceDataGetter;
		}

		public void UpdateData()
		{
			WorkplaceData workplaceData = _workplaceDataGetter();
			_occupiedWorkslotCount.text = NumberFormatter.Format(workplaceData.OccupiedWorkslots) ?? "";
			_freeWorkslotCount.text = NumberFormatter.Format(workplaceData.FreeWorkslots) ?? "";
			_unemployedCount.text = NumberFormatter.Format(workplaceData.Unemployed) ?? "";
		}
	}
}
