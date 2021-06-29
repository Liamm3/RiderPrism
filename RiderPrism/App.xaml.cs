using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using RiderPrism.Views;
using Person;

namespace RiderPrism {
   public partial class App : PrismApplication {
      protected override void RegisterTypes(IContainerRegistry containerRegistry) {
      }

      protected override Window CreateShell() => Container.Resolve<ShellWindowView>();

      protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
         moduleCatalog.AddModule<PersonModule>();
      }
   }
}
