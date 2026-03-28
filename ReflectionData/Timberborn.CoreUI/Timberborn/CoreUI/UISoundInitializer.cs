using Timberborn.UISound;
using UnityEngine.UIElements;

namespace Timberborn.CoreUI
{
	public class UISoundInitializer : IVisualElementInitializer
	{
		private static readonly CustomStyleProperty<string> ClickSoundProperty = new CustomStyleProperty<string>("--click-sound");

		private static readonly string NoSoundValue = "none";

		private readonly UISoundController _uiSoundController;

		public UISoundInitializer(UISoundController uiSoundController)
		{
			_uiSoundController = uiSoundController;
		}

		public void InitializeVisualElement(VisualElement visualElement)
		{
			visualElement.RegisterCallback<ClickEvent>(PlayUISound);
		}

		private void PlayUISound(EventBase clickEvent)
		{
			VisualElement visualElement = clickEvent.currentTarget as VisualElement;
			if (visualElement != null && visualElement.enabledSelf)
			{
				VisualElement visualElement2 = clickEvent.target as VisualElement;
				if (visualElement2 != null && visualElement2.enabledSelf && visualElement == visualElement2 && visualElement.customStyle.TryGetValue(ClickSoundProperty, out var value) && value != NoSoundValue)
				{
					_uiSoundController.PlaySound(value);
				}
			}
		}
	}
}
