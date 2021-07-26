using System.Windows;
using DialogSample;
using Person;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using RiderPrism.Dialogs;
using RiderPrism.Views;

namespace RiderPrism {
    public partial class App : PrismApplication {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterDialog<MessageDialog, MessageDialogViewModel>();
        }

        protected override Window CreateShell() => Container.Resolve<ShellWindowView>();

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
            moduleCatalog.AddModule<PersonModule>();
            moduleCatalog.AddModule<DialogSampleModule>();
        }
    }
}
