using Timberborn.PlatformUtilities;

namespace Timberborn.KeyBindingSystem
{
	public class CtrlKeyOverwriter
	{
		private static readonly string LeftCtrlKey = "leftCtrl";

		private static readonly string RightCtrlKey = "rightCtrl";

		private static readonly string LeftCmdKey = "leftMeta";

		private static readonly string RightCmdKey = "rightMeta";

		public InputBindingSpec OverwriteIfOnMacOS(InputBindingSpec inputBindingSpec)
		{
			if (!ApplicationPlatform.IsMacOS())
			{
				return inputBindingSpec;
			}
			return OverwriteCtrl(inputBindingSpec);
		}

		private static InputBindingSpec OverwriteCtrl(InputBindingSpec inputBindingSpec)
		{
			InputBindingSpec obj = (InputBindingSpec)inputBindingSpec._003CClone_003E_0024();
			obj.Path = OverwritePath(inputBindingSpec.Path);
			obj.InputModifiers = OverwriteModifiers(inputBindingSpec.InputModifiers);
			return obj;
		}

		private static string OverwritePath(string path)
		{
			return path.Replace(LeftCtrlKey, LeftCmdKey).Replace(RightCtrlKey, RightCmdKey);
		}

		private static InputModifiers OverwriteModifiers(InputModifiers modifiers)
		{
			if (modifiers.HasFlag(InputModifiers.Ctrl))
			{
				modifiers &= ~InputModifiers.Ctrl;
				modifiers |= InputModifiers.Cmd;
			}
			return modifiers;
		}
	}
}
