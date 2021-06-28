using System.Windows;
using Prism.DryIoc;
using Prism.Ioc;
using RiderPrism.Views;

namespace RiderPrism {
   public partial class App : PrismApplication {
      protected override void RegisterTypes(IContainerRegistry containerRegistry) {
      }

      protected override Window CreateShell() => Container.Resolve<ShellWindow>();
   }
}
