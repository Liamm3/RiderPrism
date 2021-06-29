using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace RiderPrism.ViewModels {
    public class ShellWindowViewModel : BindableBase {
       private readonly IRegionManager _regionManager;
       public DelegateCommand<string> NavigateCommand { get; set; }

       public ShellWindowViewModel(IRegionManager regionManager) {
           _regionManager = regionManager;
           NavigateCommand = new DelegateCommand<string>(Navigate);
       }

       private void Navigate(string uri) {
           _regionManager.RequestNavigate("ContentRegion", uri);
       }
    }
}
