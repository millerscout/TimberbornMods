using Bindito.Core;
using Timberborn.SingletonSystem;

namespace TimberbornProfiler
{
    /// <summary>Registers ProfilerSettings in both MainMenu and Game contexts so ModSettings UI works everywhere.</summary>
    [Context("MainMenu")]
    [Context("Game")]
    internal class ProfilerSettingsConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<ProfilerSettings>().AsSingleton();
            containerDefinition.MultiBind<IUnloadableSingleton>().To<ProfilerSettings>().AsTransient();
        }
    }
}
