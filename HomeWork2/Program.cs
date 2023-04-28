
// Task 1 (почему получается ввести число только с запятой, а с точкой відает ошибку?)
//Console.WriteLine("Enter radius: ");
//double a = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"In range : {a >= -5 && a <= 5}");
//Console.WriteLine($"Out of range : {a < -5 || a > 5}");
//Task 2 
Console.WriteLine("Enter 3 numbers ");
int[] arr = new int[3];
for( int i = 0; i < arr.Length; i++ )
{
    arr[i] = int.Parse( Console.ReadLine() );
}

Console.WriteLine("Minimum number is " + arr.Min());
Console.WriteLine("Maximum number is " + arr.Max());
//Task 3 