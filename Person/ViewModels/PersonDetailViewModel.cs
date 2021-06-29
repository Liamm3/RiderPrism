using Prism.Mvvm;
using Prism.Regions;

namespace Person.ViewModels {
    public class PersonDetailViewModel : BindableBase, INavigationAware {
        private Person _person;

        public Person Person {
            get => _person;
            set => SetProperty(ref _person, value);
        }

        public void OnNavigatedTo(NavigationContext navigationContext) {
            if (navigationContext.Parameters.ContainsKey("person")) {
                Person = navigationContext.Parameters.GetValue<Person>("person");
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext) {
            var person = navigationContext.Parameters.GetValue<Person>("person");
            return person.Id == Person.Id;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext) {
        }
    }
}
