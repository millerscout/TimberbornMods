using Bindito.Core;
using ReChooChoo.NavigationSystem;
using Timberborn.TemplateSystem;
using Timberborn.WalkingSystem;

namespace ReChooChoo.PassengerSystem
{
  [Context("Game")]
  public class PassengerSystemConfigurator : IConfigurator
  {
    public void Configure(IContainerDefinition containerDefinition)
    {
      containerDefinition.Bind<PassengerStationLinkRepository>().AsSingleton();
      containerDefinition.MultiBind<TemplateModule>().ToProvider<TemplateModuleProvider>().AsSingleton();
    }

    private class TemplateModuleProvider : IProvider<TemplateModule>
    {
      public TemplateModule Get()
      {
        var builder = new TemplateModule.Builder();
        builder.AddDecorator<Walker, Passenger>();
        builder.AddDecorator<PassengerStation, TrainDestination>();
        return builder.Build();
      }
    }
  }
}

