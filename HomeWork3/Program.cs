namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "loremipsum lalwdj9aoikwdjlaskdhjwajksdniala";

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
        }
    }
}