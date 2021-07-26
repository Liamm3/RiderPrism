using ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModuleA {
    public class ModuleAModule : IModule {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
        }

        public void OnInitialized(IContainerProvider containerProvider) {
        }
    }
}
