using DialogSample.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DialogSample {
    public class DialogSampleModule : IModule {
        private readonly IRegionManager _regionManager;

        public DialogSampleModule(IRegionManager regionManager) {
            _regionManager = regionManager;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            _regionManager.RegisterViewWithRegion<DialogSampleView>("ContentRegion");
        }
    }
}
