using System.Collections.Immutable;
using Timberborn.ToolButtonSystem;
using Timberborn.TutorialSystem;
using UnityEngine.UIElements;

namespace Timberborn.TutorialSystemUI
{
	internal class TutorialStepView
	{
		private static readonly string FinishedClassKey = "tutorial-step-view--finished";

		private static readonly string TutorialToolClassKey = "tutorial-tool--highlighted";

		private readonly TutorialStep _tutorialStep;

		private readonly TutorialPanel _parent;

		private readonly Label _description;

		public bool IsAchieved { get; private set; }

		public VisualElement Root { get; }

		public TutorialStepView(TutorialStep tutorialStep, TutorialPanel parent, VisualElement root, Label description)
		{
			_tutorialStep = tutorialStep;
			_parent = parent;
			Root = root;
			_description = description;
			UpdateDescription();
		}

		public void Update()
		{
			IsAchieved = _tutorialStep.Step.Achieved();
			UpdateStyle();
			UpdateDescription();
			HighlightAssociatedTools();
		}

		public void UnhighlightAssociatedTools()
		{
			HighlightAssociatedTools(forceHide: true);
		}

		private void UpdateStyle()
		{
			Root.EnableInClassList(FinishedClassKey, IsAchieved);
		}

		private void UpdateDescription()
		{
			_description.text = _tutorialStep.Step.Description();
		}

		private void HighlightAssociatedTools(bool forceHide = false)
		{
			bool flag = _parent.IsVisible && !forceHide && !IsAchieved && ((_tutorialStep.Step as ITutorialStepWithTool)?.KeepBlinking ?? true) && HighlightTimer.IsTimeForPulsingHighlight();
			ImmutableArray<ToolButton>.Enumerator enumerator = _tutorialStep.ToolButtons.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ToggleHighlight(enumerator.Current.Root, flag);
			}
			ToolGroupButton toolGroupButton = _tutorialStep.ToolGroupButton;
			if (toolGroupButton != null)
			{
				ToggleHighlight(toolGroupButton.Root, flag);
			}
			_tutorialStep.Highlight?.Invoke(flag);
		}

		private static void ToggleHighlight(VisualElement root, bool state)
		{
			root.EnableInClassList(TutorialToolClassKey, state);
		}
	}
}
