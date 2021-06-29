using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using RiderPrism.Views;
using ModuleA;

namespace RiderPrism {
   public partial class App : PrismApplication {
      protected override void RegisterTypes(IContainerRegistry containerRegistry) {
      }

      protected override Window CreateShell() => Container.Resolve<ShellWindow>();

      protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
         moduleCatalog.AddModule<ModuleAModule>();
      }
   }
}
