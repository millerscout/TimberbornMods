using Bindito.Core;

namespace Mods.ReEvaporation.Scripts
{
    [Context("MainMenu")]
    [Context("Game")]
    internal class EvaporationSettingsConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<EvaporationSettingsOwner>().AsSingleton();
        }
    }
}
