using System;
using System.Collections.Generic;

namespace DeveloperApp
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }

    class Programmer : IDeveloper
    {
        public string Tool { get; set; }
        public string Language { get; set; }

        public void Create()
        {
            Console.WriteLine($"Programmer ({Language}) is creating...");
        }

        public void Destroy()
        {
            Console.WriteLine($"Programmer ({Language}) is destroying...");
        }

        public int CompareTo(IDeveloper other)
        {
            if (other is Programmer otherProgrammer)
            {
                return String.Compare(Language, otherProgrammer.Language);
            }
            else
            {
                return -1;  // This programmer is considered "less than" the other developer
            }
        }
    }

    class Builder : IDeveloper
    {
        public string Tool { get; set; }
        public string Specialty { get; set; }

        public void Create()
        {
            Console.WriteLine($"Builder ({Specialty}) is creating...");
        }

        public void Destroy()
        {
            Console.WriteLine($"Builder ({Specialty}) is destroying...");
        }

        public int CompareTo(IDeveloper other)
        {
            if (other is Builder otherBuilder)
            {
                return String.Compare(Specialty, otherBuilder.Specialty);
            }
            else
            {
                return 1;  // This builder is considered "greater than" the other developer
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();  // Create a list of IDeveloper

            Programmer programmer1 = new Programmer { Tool = "IDE", Language = "C#" };
            Programmer programmer2 = new Programmer { Tool = "Text Editor", Language = "Python" };
            Builder builder1 = new Builder { Tool = "Hammer", Specialty = "Carpentry" };
            Builder builder2 = new Builder { Tool = "Wrench", Specialty = "Plumbing" };

            developers.Add(programmer1);
            developers.Add(programmer2);
            developers.Add(builder1);
            developers.Add(builder2);

            foreach (var developer in developers)
            {
                developer.Create();
                developer.Destroy();
            }

            developers.Sort();  // Sort the developers based on the implemented comparison logic

            Console.WriteLine("\nSorted list of developers:");

            foreach (var developer in developers)
            {
                Console.WriteLine(developer);
            }
        }
    }
}
