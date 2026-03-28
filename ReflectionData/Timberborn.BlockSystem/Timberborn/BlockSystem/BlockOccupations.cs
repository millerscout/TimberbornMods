using System;

namespace Timberborn.BlockSystem
{
	[Flags]
	public enum BlockOccupations
	{
		None = 0x0,
		All = -1,
		Floor = 0x1,
		Bottom = 0x2,
		Top = 0x4,
		Corners = 0x8,
		Path = 0x10,
		Middle = 0x20
	}
}
