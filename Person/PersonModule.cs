using Person.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Person {
    public class PersonModule : IModule {
        public PersonModule(IRegionManager regionManager) {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterForNavigation<PersonDetailView>();
        }

        public void OnInitialized(IContainerProvider containerProvider) {
        }
    }
}
