using System;
using Timberborn.Population;
using Timberborn.UIFormatters;
using UnityEngine.UIElements;

namespace Timberborn.PopulationUI
{
	public class HousingDataRow : IPopulationRow
	{
		private readonly Label _occupiedBedCount;

		private readonly Label _freeBedCount;

		private readonly Label _homelessCount;

		private readonly Func<PopulationData> _populationDataGetter;

		public HousingDataRow(Label occupiedBedCount, Label freeBedCount, Label homelessCount, Func<PopulationData> populationDataGetter)
		{
			_occupiedBedCount = occupiedBedCount;
			_freeBedCount = freeBedCount;
			_homelessCount = homelessCount;
			_populationDataGetter = populationDataGetter;
		}

		public void UpdateData()
		{
			BedData bedData = _populationDataGetter().BedData;
			_occupiedBedCount.text = NumberFormatter.Format(bedData.OccupiedBeds) ?? "";
			_freeBedCount.text = NumberFormatter.Format(bedData.FreeBeds) ?? "";
			_homelessCount.text = NumberFormatter.Format(bedData.Homeless) ?? "";
		}
	}
}
