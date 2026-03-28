using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Timberborn.AutomationBuildings;
using Timberborn.BaseComponentSystem;
using Timberborn.CoreUI;
using Timberborn.EntityNaming;
using Timberborn.EntitySystem;
using Timberborn.Illumination;
using Timberborn.SelectionSystem;
using Timberborn.SingletonSystem;
using Timberborn.UILayoutSystem;
using UnityEngine.UIElements;

namespace Timberborn.AutomationBuildingsUI
{
	public class PinnedIndicatorsPanel : IPostLoadableSingleton
	{
		private record IndicatorItem(VisualElement Root, Image StateIcon)
		{
			[CompilerGenerated]
			protected virtual Type EqualityContract
			{
				[CompilerGenerated]
				get
				{
					return typeof(IndicatorItem);
				}
			}

			public IndicatorItem(VisualElement Root, Image StateIcon)
			{
				this.Root = ;
				this.StateIcon = StateIcon;
				base._002Ector();
			}

			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("IndicatorItem");
				stringBuilder.Append(" { ");
				if (PrintMembers(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			[CompilerGenerated]
			protected virtual bool PrintMembers(StringBuilder builder)
			{
				RuntimeHelpers.EnsureSufficientExecutionStack();
				builder.Append("Root = ");
				builder.Append(Root);
				builder.Append(", StateIcon = ");
				builder.Append(StateIcon);
				return true;
			}

			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (EqualityComparer<Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<VisualElement>.Default.GetHashCode(Root)) * -1521134295 + EqualityComparer<Image>.Default.GetHashCode(StateIcon);
			}

			[CompilerGenerated]
			public virtual bool Equals(IndicatorItem? other)
			{
				if ((object)this != other)
				{
					if ((object)other != null && EqualityContract == other!.EqualityContract && EqualityComparer<VisualElement>.Default.Equals(Root, other!.Root))
					{
						return EqualityComparer<Image>.Default.Equals(StateIcon, other!.StateIcon);
					}
					return false;
				}
				return true;
			}

			[CompilerGenerated]
			protected IndicatorItem(IndicatorItem original)
			{
				Root = original.Root;
				StateIcon = original.StateIcon;
			}
		}

		private static readonly string StateIconOnClass = "automation-state-icon--on";

		private static readonly string StateIconUnfinishedClass = "automation-state-icon--unfinished";

		private readonly VisualElementLoader _visualElementLoader;

		private readonly UILayout _uiLayout;

		private readonly EntityComponentRegistry _entityComponentRegistry;

		private readonly EntitySelectionService _entitySelectionService;

		private readonly EventBus _eventBus;

		private VisualElement _root;

		private VisualElement _indicatorsContainer;

		private readonly Dictionary<Indicator, IndicatorItem> _indicatorItems = new Dictionary<Indicator, IndicatorItem>();

		public PinnedIndicatorsPanel(VisualElementLoader visualElementLoader, UILayout uiLayout, EntityComponentRegistry entityComponentRegistry, EntitySelectionService entitySelectionService, EventBus eventBus)
		{
			_visualElementLoader = visualElementLoader;
			_uiLayout = uiLayout;
			_entityComponentRegistry = entityComponentRegistry;
			_entitySelectionService = entitySelectionService;
			_eventBus = eventBus;
		}

		public void PostLoad()
		{
			_root = _visualElementLoader.LoadVisualElement("Game/AutomationPins/PinnedIndicatorsPanel");
			_indicatorsContainer = _root.Q<VisualElement>("Indicators");
			Recreate();
			_eventBus.Register(this);
		}

		[OnEvent]
		public void OnShowPrimaryUI(ShowPrimaryUIEvent showPrimaryUIEvent)
		{
			_uiLayout.AddTopLeft(_root, 40);
		}

		[OnEvent]
		public void OnIndicatorPinnedModeChanged(IndicatorPinnedModeChangedEvent indicatorPinnedModeChangedEvent)
		{
			Recreate();
		}

		[OnEvent]
		public void OnEntityInitialized(EntityInitializedEvent entityInitializedEvent)
		{
			RecreateIfIndicator(entityInitializedEvent.Entity);
		}

		[OnEvent]
		public void OnEntityDeleted(EntityDeletedEvent entityDeletedEvent)
		{
			Indicator component = entityDeletedEvent.Entity.GetComponent<Indicator>();
			if (component != null)
			{
				UnsubscribeFromModification(component);
				Recreate();
			}
		}

		[OnEvent]
		public void OnEntityNameChangedEvent(EntityNameChangedEvent entityNameChangedEvent)
		{
			RecreateIfIndicator(entityNameChangedEvent.Entity);
		}

		private void RecreateIfIndicator(BaseComponent entity)
		{
			if (entity.HasComponent<Indicator>())
			{
				Recreate();
			}
		}

		private void Recreate()
		{
			_indicatorsContainer.Clear();
			_indicatorItems.Clear();
			foreach (Indicator item in from indicator in _entityComponentRegistry.GetAll<Indicator>()
				where indicator.PinnedMode != IndicatorPinnedMode.Never
				orderby indicator.GetComponent<NamedEntity>().SortingKey
				select indicator)
			{
				CreateIndicatorItem(item);
			}
			_root.ToggleDisplayStyle(_indicatorsContainer.childCount > 0);
		}

		private void CreateIndicatorItem(Indicator indicator)
		{
			VisualElement visualElement = _visualElementLoader.LoadVisualElement("Game/AutomationPins/PinnedIndicator");
			visualElement.Q<Label>("Name").text = indicator.IndicatorName;
			Image stateIcon = visualElement.Q<Image>("StateIcon");
			visualElement.RegisterCallback<ClickEvent>(delegate
			{
				OnIndicatorClicked(indicator);
			});
			IndicatorItem indicatorItem = new IndicatorItem(visualElement, stateIcon);
			UpdateIndicatorItem(indicator, indicatorItem);
			_indicatorItems.Add(indicator, indicatorItem);
			_indicatorsContainer.Add(visualElement);
			SubscribeToModification(indicator);
		}

		private static void UpdateIndicatorItem(Indicator indicator, IndicatorItem indicatorItem)
		{
			indicatorItem.Root.ToggleDisplayStyle(indicator.State || indicator.PinnedMode == IndicatorPinnedMode.Always);
			indicatorItem.StateIcon.style.unityBackgroundImageTintColor = indicator.GetComponent<CustomizableIlluminator>().IconColor;
			indicatorItem.StateIcon.EnableInClassList(StateIconOnClass, indicator.State);
			indicatorItem.StateIcon.EnableInClassList(StateIconUnfinishedClass, !indicator.Enabled);
		}

		private void OnIndicatorClicked(Indicator indicator)
		{
			_entitySelectionService.SelectAndFocusOn(indicator);
		}

		private void SubscribeToModification(Indicator indicator)
		{
			UnsubscribeFromModification(indicator);
			indicator.PinnedIndicatorModified += OnPinnedIndicatorModified;
		}

		private void UnsubscribeFromModification(Indicator indicator)
		{
			indicator.PinnedIndicatorModified -= OnPinnedIndicatorModified;
		}

		private void OnPinnedIndicatorModified(object sender, EventArgs e)
		{
			Indicator indicator = (Indicator)sender;
			if (_indicatorItems.TryGetValue(indicator, out var value))
			{
				UpdateIndicatorItem(indicator, value);
			}
		}
	}
}
