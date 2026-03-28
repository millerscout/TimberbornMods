using Bindito.Core;

namespace ReChooChoo.Debugging
{
    [Context("Game")]
    public class DebuggingConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<DebuggingMarkers>().AsSingleton();
            containerDefinition.Bind<PathFollowerDebugger>().AsSingleton();
        }
    }
}
