using Bindito.Core;

namespace ReChooChoo.UIPresets
{
    [Context("Game")]
    public class UIPresetsConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<PanelFragment>().AsTransient();
        }
    }
}
