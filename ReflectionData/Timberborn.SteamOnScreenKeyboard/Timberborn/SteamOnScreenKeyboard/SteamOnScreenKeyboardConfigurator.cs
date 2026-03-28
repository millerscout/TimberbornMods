using Bindito.Core;
using Timberborn.CoreUI;

namespace Timberborn.SteamOnScreenKeyboard
{
	[Context("Game")]
	[Context("MapEditor")]
	[Context("MainMenu")]
	internal class SteamOnScreenKeyboardConfigurator : Configurator
	{
		protected override void Configure()
		{
			MultiBind<IVisualElementInitializer>().To<SteamOnScreenKeyboardController>().AsSingleton();
		}
	}
}
