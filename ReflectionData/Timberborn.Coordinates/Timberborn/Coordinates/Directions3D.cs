using System;

namespace Timberborn.Coordinates
{
	[Flags]
	public enum Directions3D
	{
		None = 0x0,
		All = -1,
		Down = 0x1,
		Left = 0x2,
		Up = 0x4,
		Right = 0x8,
		Bottom = 0x10,
		Top = 0x20
	}
}
