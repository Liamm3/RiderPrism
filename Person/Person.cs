namespace Person {
    public class Person {
        private int _id;
        private string _name;
        private string _lastname;
        private int _age;

        public Person(int id, string name, string lastname, int age) {
            _id = id;
            _name = name;
            _lastname = lastname;
            _age = age;
        }

        public int Id {
            get => _id;
            set => _id = value;
        }

        public string Name {
            get => _name;
            set => _name = value;
        }

        public string Lastname {
            get => _lastname;
            set => _lastname = value;
        }

        public int Age {
            get => _age;
            set => _age = value;
        }

        public override string ToString() => $"ID: {Id}; Name: {Name} {Lastname}; age: {Age}";
    }
}
