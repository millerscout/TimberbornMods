using System;

namespace Timberborn.Common
{
	[Flags]
	public enum Compatibility
	{
		Save = 0x0,
		Map = 0x1,
		Mod = 0x2
	}
}
