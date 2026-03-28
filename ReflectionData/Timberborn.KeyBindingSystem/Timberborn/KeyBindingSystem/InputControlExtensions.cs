using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;

namespace Timberborn.KeyBindingSystem
{
	internal static class InputControlExtensions
	{
		public static bool WasPressedInEvent(this InputControl inputControl, InputEventPtr inputEvent)
		{
			InputControl<float> inputControl2 = inputControl as InputControl<float>;
			if (inputControl2 != null)
			{
				float num = inputControl2.ReadValueFromEvent(inputEvent);
				return (inputControl as ButtonControl)?.IsValueConsideredPressed(num) ?? (num != 0f);
			}
			return false;
		}
	}
}
