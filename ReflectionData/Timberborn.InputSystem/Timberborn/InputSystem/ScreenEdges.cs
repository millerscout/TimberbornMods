using System;

namespace Timberborn.InputSystem
{
	[Flags]
	public enum ScreenEdges
	{
		None = 0x0,
		Down = 0x1,
		Left = 0x2,
		Up = 0x4,
		Right = 0x8
	}
}
