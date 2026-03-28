using Bindito.Core;
using ReChooChoo.TrackSystem;
using ReChooChoo.Wagons;
using TobbyTools.BuildingRegistrySystem;

namespace ReChooChoo.NavigationSystem
{
    [Context("Game")]
    public class TrainNavigationSystemConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<BuildingRegistry<TrackPiece>>().AsSingleton();
            containerDefinition.Bind<BuildingRegistry<TrainDestination>>().AsSingleton();
            containerDefinition.Bind<TrainDestinationConnectedRepository>().AsSingleton();
            containerDefinition.Bind<TrackRouteWeightsCalculator>().AsSingleton();
            containerDefinition.Bind<TrainDestinationService>().AsSingleton();
            containerDefinition.Bind<WagonsObjectSerializer>().AsSingleton();

            containerDefinition.Bind<RandomTrainDestinationPicker>().AsSingleton();
            containerDefinition.Bind<TrainDestinationObjectSerializer>().AsSingleton();
            containerDefinition.Bind<TrainNavigationService>().AsSingleton();
            containerDefinition.Bind<TrainPositionDestinationFactory>().AsSingleton();
        }
    }
}
