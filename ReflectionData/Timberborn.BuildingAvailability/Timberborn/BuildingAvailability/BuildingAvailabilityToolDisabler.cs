using Timberborn.BlockObjectTools;
using Timberborn.ToolSystem;

namespace Timberborn.BuildingAvailability
{
	internal class BuildingAvailabilityToolDisabler : IToolDisabler
	{
		private readonly BuildingAvailabilityValidator _buildingAvailabilityValidator;

		public BuildingAvailabilityToolDisabler(BuildingAvailabilityValidator buildingAvailabilityValidator)
		{
			_buildingAvailabilityValidator = buildingAvailabilityValidator;
		}

		public bool IsEnabled(ITool tool)
		{
			BlockObjectTool blockObjectTool = tool as BlockObjectTool;
			if (blockObjectTool != null)
			{
				return _buildingAvailabilityValidator.IsAvailableForPlacement(blockObjectTool.Template);
			}
			return true;
		}
	}
}
