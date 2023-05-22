using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static int ReadNumber(int start, int end)
    {
        while (true)
        {
            Console.WriteLine($"Введите число от {start} до {end}:");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if (number <= start || number >= end)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Не то ввел. Попробуйте еще раз.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Число должно от {start} до {end}.");
            }
        }
    }

    static void Main()
    {
        const int start = 1;
        const int end = 100;
        int[] numbers = new int[10];

        try
        {
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = ReadNumber(start, end);
            }

            Console.WriteLine("Введенные числа:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eror {ex.Message}");
        }
    }
}

