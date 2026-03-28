using Steamworks;
using Timberborn.CoreUI;
using Timberborn.InputSystem;
using Timberborn.SteamStoreSystem;
using UnityEngine;
using UnityEngine.UIElements;

namespace Timberborn.SteamOnScreenKeyboard
{
	internal class SteamOnScreenKeyboardController : IVisualElementInitializer
	{
		private readonly InputSettings _inputSettings;

		private readonly SteamManager _steamManager;

		private TextElement _lastFocusedElement;

		public SteamOnScreenKeyboardController(InputSettings inputSettings, SteamManager steamManager)
		{
			_inputSettings = inputSettings;
			_steamManager = steamManager;
		}

		public void InitializeVisualElement(VisualElement visualElement)
		{
			if (!Application.isEditor && _steamManager.Initialized && (visualElement is TextField || visualElement is IntegerField || visualElement is FloatField))
			{
				TextElement textElement = visualElement.Q<TextElement>();
				textElement.RegisterCallback<FocusInEvent>(OnFocusIn);
				textElement.RegisterCallback<FocusOutEvent>(OnFocusOut);
				textElement.RegisterCallback<AttachToPanelEvent>(OnTextfieldGeometryChange);
				textElement.RegisterCallback<GeometryChangedEvent>(OnTextfieldGeometryChange);
			}
		}

		private void OnFocusIn(FocusInEvent focusInEvent)
		{
			TextElement textElement = focusInEvent.currentTarget as TextElement;
			if (textElement != null)
			{
				_lastFocusedElement = textElement;
				if (ElementHasValidGeometry(textElement))
				{
					TryOpenOnScreenKeyboard(textElement);
				}
			}
		}

		private void OnFocusOut(FocusOutEvent focusOutEvent)
		{
			TextElement textElement = focusOutEvent.currentTarget as TextElement;
			if (textElement != null && textElement == _lastFocusedElement)
			{
				HideKeyboard();
			}
		}

		private void OnTextfieldGeometryChange(EventBase eventBase)
		{
			TextElement textElement = eventBase.currentTarget as TextElement;
			if (textElement != null && textElement == _lastFocusedElement && ElementHasValidGeometry(textElement))
			{
				TryOpenOnScreenKeyboard(textElement);
			}
		}

		private void TryOpenOnScreenKeyboard(TextElement textElement)
		{
			if (ShouldOpenKeyboard())
			{
				Rect worldBound = textElement.worldBound;
				SteamUtils.ShowFloatingGamepadTextInput(EFloatingGamepadTextInputMode.k_EFloatingGamepadTextInputModeModeSingleLine, (int)worldBound.min.x, (int)worldBound.min.y, (int)worldBound.width, (int)worldBound.height);
			}
		}

		private static void HideKeyboard()
		{
			SteamUtils.DismissFloatingGamepadTextInput();
		}

		private bool ShouldOpenKeyboard()
		{
			if (!SteamDeckCheck())
			{
				return SteamBigPictureCheck();
			}
			return true;
		}

		private static bool ElementHasValidGeometry(VisualElement element)
		{
			Rect worldBound = element.worldBound;
			return worldBound.x != 0f || worldBound.y != 0f || !float.IsNaN(worldBound.width) || !float.IsNaN(worldBound.height);
		}

		private bool SteamDeckCheck()
		{
			if (_steamManager.Initialized)
			{
				string onScreenKeyboard = _inputSettings.OnScreenKeyboard;
				if (onScreenKeyboard == "Auto" || onScreenKeyboard == "Enabled")
				{
					return SteamUtils.IsSteamRunningOnSteamDeck();
				}
			}
			return false;
		}

		private bool SteamBigPictureCheck()
		{
			if (_steamManager.Initialized && _inputSettings.OnScreenKeyboard == "Enabled")
			{
				return SteamUtils.IsSteamInBigPictureMode();
			}
			return false;
		}
	}
}
