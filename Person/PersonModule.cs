using Person.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Person {
    public class PersonModule : IModule {
        public void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.RegisterForNavigation<PersonDetailView>();
        }

        public void OnInitialized(IContainerProvider containerProvider) {
        }
    }
}
