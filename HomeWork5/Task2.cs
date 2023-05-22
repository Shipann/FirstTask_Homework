using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> persons = new Dictionary<uint, string>();  

            
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter ID: ");
                uint id = uint.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                persons.Add(id, name);
            }

            Console.Write("Enter ID to search: ");
            uint searchId = uint.Parse(Console.ReadLine());

            
            if (persons.TryGetValue(searchId, out string result))
            {
                Console.WriteLine($"Name: {result}");
            }
            else
            {
                Console.WriteLine("ID not found in the dictionary.");
            }
        }
    }
}
