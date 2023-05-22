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
                return -1;  
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
                return 1;  
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> developers = new List<IDeveloper>();  

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

            developers.Sort();  

            Console.WriteLine("\nSorted list of developers:");

            foreach (var developer in developers)
            {
                Console.WriteLine(developer);
            }
        }
    }
}
