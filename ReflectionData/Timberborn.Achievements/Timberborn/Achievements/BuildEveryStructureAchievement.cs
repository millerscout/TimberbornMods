using System.Collections.Generic;
using System.Linq;
using Timberborn.AchievementSystem;
using Timberborn.BlockSystem;
using Timberborn.BuildingAvailability;
using Timberborn.Buildings;
using Timberborn.EntitySystem;
using Timberborn.GameFactionSystem;
using Timberborn.SingletonSystem;
using Timberborn.TemplateSystem;

namespace Timberborn.Achievements
{
	internal abstract class BuildEveryStructureAchievement : Achievement, IPostLoadableSingleton
	{
		private static readonly HashSet<string> BlacklistedPrefixes = new HashSet<string> { "Dynamite.", "DoubleDynamite.", "TripleDynamite.", "Tunnel.", "TerrainBlock." };

		private readonly EventBus _eventBus;

		private readonly FactionService _factionService;

		private readonly TemplateService _templateService;

		private readonly EntityComponentRegistry _entityComponentRegistry;

		private readonly BuildingAvailabilityValidator _buildingAvailabilityValidator;

		private readonly string _faction;

		private HashSet<string> _structuresToBuild;

		public override string Id => "BUILD_EVERY_STRUCTURE_" + _faction.ToUpperInvariant();

		protected BuildEveryStructureAchievement(EventBus eventBus, FactionService factionService, TemplateService templateService, EntityComponentRegistry entityComponentRegistry, BuildingAvailabilityValidator buildingAvailabilityValidator, string faction)
		{
			_eventBus = eventBus;
			_factionService = factionService;
			_templateService = templateService;
			_entityComponentRegistry = entityComponentRegistry;
			_buildingAvailabilityValidator = buildingAvailabilityValidator;
			_faction = faction;
		}

		public void PostLoad()
		{
			_structuresToBuild = (from spec in _templateService.GetAll<BuildingSpec>().Where(IsValidStructure)
				select spec.GetSpec<TemplateSpec>().TemplateName).ToHashSet();
		}

		[OnEvent]
		public void OnEnteredFinishedState(EnteredFinishedStateEvent enteredFinishedStateEvent)
		{
			TemplateSpec templateSpec = enteredFinishedStateEvent.BlockObject.GetComponent<BuildingSpec>()?.GetSpec<TemplateSpec>();
			if ((object)templateSpec != null)
			{
				TryUnlock(templateSpec);
			}
		}

		protected override void EnableInternal()
		{
			if (_factionService.Current.Id == _faction)
			{
				_eventBus.Register(this);
				TryUnlockFromExisting();
			}
		}

		protected override void DisableInternal()
		{
			_eventBus.Unregister(this);
		}

		private bool IsValidStructure(BuildingSpec buildingSpec)
		{
			TemplateSpec spec = buildingSpec.GetSpec<TemplateSpec>();
			if (spec.UsableWithCurrentFeatureToggles)
			{
				foreach (string blacklistedPrefix in BlacklistedPrefixes)
				{
					if (spec.TemplateName.StartsWith(blacklistedPrefix))
					{
						return false;
					}
				}
				if (_buildingAvailabilityValidator.IsAvailableForPlacement(buildingSpec))
				{
					return !buildingSpec.GetSpec<PlaceableBlockObjectSpec>().DevModeTool;
				}
				return false;
			}
			return false;
		}

		private void TryUnlock(TemplateSpec template)
		{
			_structuresToBuild.Remove(template.TemplateName);
			if (_structuresToBuild.Count == 0)
			{
				Unlock();
			}
		}

		private void TryUnlockFromExisting()
		{
			foreach (Building item in _entityComponentRegistry.GetEnabled<Building>())
			{
				BlockObject component = item.GetComponent<BlockObject>();
				if (component != null && component.IsFinished)
				{
					TryUnlock(item.GetComponent<TemplateSpec>());
				}
			}
		}
	}
}
