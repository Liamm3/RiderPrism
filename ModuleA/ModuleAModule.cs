using Prism.Ioc;
using Prism.Modularity;
using ModuleA.Views;

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
