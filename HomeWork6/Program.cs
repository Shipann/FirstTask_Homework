//namespace HomeWork6
//{
//    using System;

//    class Program
//    {
//        static void Main()
//        {
//            try
//            {
//                Console.WriteLine("Введите первое число:");
//                double number1 = double.Parse(Console.ReadLine());

//                Console.WriteLine("Введите второе число:");
//                double number2 = double.Parse(Console.ReadLine());

//                double result = Div(number1, number2);
//                Console.WriteLine($"Результат: {result}");
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Не то ввел");
//            }
//            catch (DivideByZeroException)
//            {
//                Console.WriteLine("Мы на ноль не делим");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Eror {ex.Message}");
//            }
//        }

//        static double Div(double dividend, double divisor)
//        {
//            if (divisor == 0)
//            {
//                throw new DivideByZeroException();
//            }

//            return dividend / divisor;
//        }
//    }

//}