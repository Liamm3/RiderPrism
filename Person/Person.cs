namespace Person {
    public class Person {
        public Person(int id, string name, string lastname, int age) {
            Id = id;
            Name = name;
            Lastname = lastname;
            Age = age;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Lastname { get; set; }

        public int Age { get; set; }

        public override string ToString() => $"ID: {Id}; Name: {Name} {Lastname}; age: {Age}";
    }
}
