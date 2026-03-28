// using Bindito.Core;
// using ReChooChoo.Trains;
// using Timberborn.TemplateSystem;
//
// namespace ReChooChoo.WaitingSystemUI
// {
//     [Context("Game")]
//     public class TrainWaitingSystemUIConfigurator : IConfigurator
//     {
//         public void Configure(IContainerDefinition containerDefinition)
//         {
//             containerDefinition.MultiBind<TemplateModule>().ToProvider(ProvideTemplateModule).AsSingleton();
//         }
//
//         private static TemplateModule ProvideTemplateModule()
//         {
//             var builder = new TemplateModule.Builder();
//             builder.AddDecorator<Train, NoWaitingStationStatus>();
//             return builder.Build();
//         }
//     }
// }
