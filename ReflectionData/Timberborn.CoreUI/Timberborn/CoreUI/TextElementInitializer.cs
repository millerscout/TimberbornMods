using Timberborn.InputSystem;
using UnityEngine.UIElements;

namespace Timberborn.CoreUI
{
	internal class TextElementInitializer : IVisualElementInitializer
	{
		private readonly InputBlocker _inputBlocker;

		public TextElementInitializer(InputBlocker inputBlocker)
		{
			_inputBlocker = inputBlocker;
		}

		public void InitializeVisualElement(VisualElement visualElement)
		{
			TextField textField = visualElement as TextField;
			if (textField != null)
			{
				if (!textField.isReadOnly)
				{
					goto IL_003a;
				}
			}
			else
			{
				IntegerField integerField = visualElement as IntegerField;
				if (integerField != null)
				{
					if (!integerField.isReadOnly)
					{
						goto IL_003a;
					}
				}
				else
				{
					FloatField floatField = visualElement as FloatField;
					if (floatField != null && !floatField.isReadOnly)
					{
						goto IL_003a;
					}
				}
			}
			bool flag = false;
			goto IL_0040;
			IL_003a:
			flag = true;
			goto IL_0040;
			IL_0040:
			if (flag)
			{
				TextElement textElement = visualElement.Q<TextElement>();
				textElement.RegisterCallback<FocusInEvent>(OnFocusIn);
				textElement.RegisterCallback<FocusOutEvent>(OnFocusOut);
			}
		}

		private void OnFocusIn(FocusInEvent evt)
		{
			_inputBlocker.Block();
		}

		private void OnFocusOut(FocusOutEvent evt)
		{
			_inputBlocker.Unblock();
		}
	}
}
