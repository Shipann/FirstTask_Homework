namespace HM4
{
    using System;

    class Person
    {
        private string name;
        private DateTime birthYear;

        public Person()
        {
            name = "";
            birthYear = new DateTime();
        }

        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public string Name { get { return name; } }
        public DateTime BirthYear { get { return birthYear; } }

        public int Age()
        {
            int age = DateTime.Now.Year - birthYear.Year;
            if (DateTime.Now.DayOfYear < birthYear.DayOfYear)
                age--;
            return age;
        }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter birth year (yyyy): ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year < 1900 || year > DateTime.Now.Year)
            {
                Console.Write("Invalid year. Enter again: ");
            }
            birthYear = new DateTime(year, 1, 1);
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return $"Name: {name}, Birth Year: {birthYear.Year}";
        }

        public void Output()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.name == p2.name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }

    class Program
    {
        static void Main()
        {
            Person[] people = new Person[6];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }

            foreach (Person person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age()}");
            }

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            foreach (Person person in people)
            {
                person.Output();
            }

            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"People {i} and {j} have the same name: {people[i].Name}");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}