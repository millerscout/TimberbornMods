using Timberborn.BuildingAvailability;
using Timberborn.EntitySystem;
using Timberborn.GameFactionSystem;
using Timberborn.SingletonSystem;
using Timberborn.TemplateSystem;

namespace Timberborn.Achievements
{
	internal class BuildEveryStructureIronTeethAchievement : BuildEveryStructureAchievement
	{
		public BuildEveryStructureIronTeethAchievement(EventBus eventBus, FactionService factionService, TemplateService templateService, EntityComponentRegistry entityComponentRegistry, BuildingAvailabilityValidator buildingAvailabilityValidator)
			: base(eventBus, factionService, templateService, entityComponentRegistry, buildingAvailabilityValidator, AchievementHelper.IronTeeth)
		{
		}
	}
}
