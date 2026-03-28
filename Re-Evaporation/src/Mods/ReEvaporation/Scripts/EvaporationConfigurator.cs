using Bindito.Core;
using Timberborn.SingletonSystem;
using Timberborn.TickSystem;

namespace Mods.ReEvaporation.Scripts
{
    [Context("Game")]
    public class EvaporationConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<EvaporationManager>().AsSingleton();
            containerDefinition.MultiBind<ILoadableSingleton>().To<EvaporationManager>().AsTransient();
            containerDefinition.MultiBind<ITickableSingleton>().To<EvaporationManager>().AsTransient();
        }
    }
}
