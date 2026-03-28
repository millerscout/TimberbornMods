using Bindito.Core;

namespace ReChooChoo.MovementSystem
{
    [Context("Game")]
    public class TrainMovementSystemConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<TrackFollowerFactory>().AsSingleton();
        }
    }
}
