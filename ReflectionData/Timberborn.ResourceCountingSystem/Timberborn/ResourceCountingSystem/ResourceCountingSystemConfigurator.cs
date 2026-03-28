using Bindito.Core;
using Timberborn.GameDistricts;
using Timberborn.TemplateInstantiation;

namespace Timberborn.ResourceCountingSystem
{
	[Context("Game")]
	internal class ResourceCountingSystemConfigurator : Configurator
	{
		protected override void Configure()
		{
			Bind<DistrictResourceCounter>().AsTransient();
			Bind<GoodProcessorRegistrar>().AsTransient();
			Bind<ResourceCountingService>().AsSingleton();
			MultiBind<TemplateModule>().ToProvider(ProvideTemplateModule).AsSingleton();
		}

		private static TemplateModule ProvideTemplateModule()
		{
			TemplateModule.Builder builder = new TemplateModule.Builder();
			builder.AddDecorator<DistrictCenter, DistrictResourceCounter>();
			builder.AddDecorator<IGoodProcessor, GoodProcessorRegistrar>();
			return builder.Build();
		}
	}
}
