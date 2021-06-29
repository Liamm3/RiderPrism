using System.Collections.ObjectModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace Person.ViewModels {
    public class PersonListViewModel : BindableBase {
        private readonly IRegionManager _regionManager;
        private ObservableCollection<Person> _people = new ObservableCollection<Person>() {
            {
                new Person(0, "Liam", "Wohlfart", 21)
            }, {
                new Person(1, "Marlena", "Flüh", 24)
            }, {
                new Person(2, "Robin", "Jurman", 25)
            }
        };

        public ObservableCollection<Person> People {
            get => _people;
            set => SetProperty(ref _people, value);
        }

        public DelegateCommand<Person> PersonSelectedCommand { get; private set; }

        public PersonListViewModel(IRegionManager regionManager) {
            _regionManager = regionManager;
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
        }

        private void PersonSelected(Person person) {
            if (person == null) {
                return;
            }
            var parameters = new NavigationParameters {{"person", person}};
            _regionManager.RequestNavigate("PersonDetailsRegion", "PersonDetailView", parameters);
        }
    }
}
