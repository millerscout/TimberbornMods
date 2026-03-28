using Bindito.Core;
using Timberborn.ToolSystem;

namespace ReChooChoo.UnlockingSystem
{
    [Context("Game")]
    public class UnlockingSystemConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.MultiBind<IToolLocker>().To<TrackPieceBlockObjectToolLocker>().AsSingleton();
        }
    }
}
