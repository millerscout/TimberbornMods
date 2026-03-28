using Bindito.Core;
using Bindito.Unity;
using ReChooChoo.DistributionSystem;
using ReChooChoo.MovementSystem;
using ReChooChoo.WaitingSystem;
using Timberborn.BaseComponentSystem;
using Timberborn.BehaviorSystem;

namespace ReChooChoo.Trains
{
    internal class TrainBehaviorInitializer : BaseComponent
    {
        private IInstantiator _instantiator;

        [Inject]
        public void InjectDependencies(IInstantiator instantiator)
        {
            _instantiator = instantiator;
        }

        public void Awake()
        {
            InitializeExecutors();
            InitializeBehaviors();
        }

        private void InitializeExecutors()
        {
            AddExecutor<MoveToStationExecutor>();
            AddExecutor<WaitExecutor>();
        }

        private void AddExecutor<T>() where T : BaseComponent, IExecutor
        {
            _instantiator.AddComponent<T>(GameObjectFast);
        }

        private void InitializeBehaviors()
        {
            var component = GetComponentFast<BehaviorManager>();
            component.AddRootBehavior<TrainCarryRootBehavior>();
            // component.AddRootBehavior<MovePassengersBehavior>();
            component.AddRootBehavior<BringDistributableGoodTrainBehavior>();
            component.AddRootBehavior<WaitingBehavior>();
        }
    }
}
