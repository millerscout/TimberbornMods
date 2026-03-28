using System;

namespace Timberborn.KeyBindingSystem
{
	[Flags]
	public enum InputModifiers
	{
		None = 0x0,
		Ctrl = 0x1,
		Alt = 0x2,
		Shift = 0x4,
		Cmd = 0x8
	}
}
