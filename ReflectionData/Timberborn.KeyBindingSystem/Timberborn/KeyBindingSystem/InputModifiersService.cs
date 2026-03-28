using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Timberborn.KeyBindingSystem
{
	public class InputModifiersService
	{
		public bool IsModifier(InputControl inputControl)
		{
			KeyControl keyControl = inputControl as KeyControl;
			if (keyControl != null)
			{
				Key keyCode = keyControl.keyCode;
				if ((uint)(keyCode - 51) <= 7u)
				{
					return true;
				}
			}
			return false;
		}

		public InputModifiers PressedModifiers()
		{
			InputModifiers inputModifiers = InputModifiers.None;
			Keyboard current = Keyboard.current;
			if (current.ctrlKey.isPressed)
			{
				inputModifiers |= InputModifiers.Ctrl;
			}
			if (current.altKey.isPressed)
			{
				inputModifiers |= InputModifiers.Alt;
			}
			if (current.shiftKey.isPressed)
			{
				inputModifiers |= InputModifiers.Shift;
			}
			if (current.leftCommandKey.isPressed || current.rightCommandKey.isPressed)
			{
				inputModifiers |= InputModifiers.Cmd;
			}
			return inputModifiers;
		}
	}
}
