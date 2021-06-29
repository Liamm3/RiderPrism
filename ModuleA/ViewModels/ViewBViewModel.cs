using Prism.Mvvm;

namespace ModuleA.ViewModels {
    public class ViewBViewModel : BindableBase {
        private int _pageViews = 0;
        private string _text = "ViewB";

        public int PageViews {
            get => _pageViews;
            set => SetProperty(ref _pageViews, value);
        }

        public string Text {
            get => _text;
            set => SetProperty(ref _text, value);
        }
    }
}
