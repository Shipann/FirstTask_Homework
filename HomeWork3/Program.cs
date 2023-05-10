namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Task 1
            /*string str = "loremipsum lalwdj9aoikwdjlaskdhjwajksdniala";

            int a = 0;
            int o = 0;
            int i = 0;
            int e = 0;

            foreach (char c in str)
            {
                if (c == 'a')
                    a++;
                else if (c == 'o')
                    o++;
                else if (c == 'i')
                    i++;
                else if (c == 'e')
                    e++;
            }

            Console.WriteLine("A = " + a);
            Console.WriteLine("O = " + o);
            Console.WriteLine("I = " + i);
            Console.WriteLine("E = " + e);

            //Task 2
            Console.WriteLine("Enter the number of the month 1-12: ");
            int monthNumber = int.Parse(Console.ReadLine());

            int daysInMonth;

            switch (monthNumber)
            {
                case 2:
                    daysInMonth = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                default:
                    daysInMonth = 31;
                    break;
            }

            Console.WriteLine("Number of days in the month: " + daysInMonth);
            */
            // Task 3
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < 5 && numbers[i] > 0)
                {
                    sum += numbers[i];
                }
                else if (i >= 5)
                {
                    product *= numbers[i];
                }
            }

            if (sum > 0)
            {
                Console.WriteLine("Sum  " + sum);
            }
            else
            {
                Console.WriteLine("Product " + product);
            }
        }
    }
}
