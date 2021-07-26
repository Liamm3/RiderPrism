using Prism.Mvvm;
using Prism.Regions;

namespace ModuleA.ViewModels {
    public class ViewAViewModel : BindableBase, INavigationAware {
        private int _pageViews;
        private string _text = "ViewA";

        public int PageViews {
            get => _pageViews;
            set => SetProperty(ref _pageViews, value);
        }

        public string Text {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        public void OnNavigatedTo(NavigationContext navigationContext) {
            PageViews++;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public void OnNavigatedFrom(NavigationContext navigationContext) {
        }
    }
}
