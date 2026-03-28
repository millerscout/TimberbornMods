using Timberborn.BuildingAvailability;
using Timberborn.EntitySystem;
using Timberborn.GameFactionSystem;
using Timberborn.SingletonSystem;
using Timberborn.TemplateSystem;

namespace Timberborn.Achievements
{
	internal class BuildEveryStructureFolktailsAchievement : BuildEveryStructureAchievement
	{
		public BuildEveryStructureFolktailsAchievement(EventBus eventBus, FactionService factionService, TemplateService templateService, EntityComponentRegistry entityComponentRegistry, BuildingAvailabilityValidator buildingAvailabilityValidator)
			: base(eventBus, factionService, templateService, entityComponentRegistry, buildingAvailabilityValidator, AchievementHelper.Folktails)
		{
		}
	}
}
