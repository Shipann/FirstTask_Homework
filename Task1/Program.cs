// Task 1
/*
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.Write("a + b = ");
Console.WriteLine( a + b);
Console.Write("a - b = ");
Console.WriteLine( a - b);
Console.Write("a * b = ");
Console.WriteLine( a * b);
Console.Write("a / b = ");
Console.WriteLine( a / b);
// Task 2
Console.WriteLine("How are you?");
string feel = Console.ReadLine();
Console.WriteLine( "You are " + feel);

// Task 3 
char q = char.Parse(Console.ReadLine());
char e = char.Parse(Console.ReadLine());
char w = char.Parse(Console.ReadLine());
Console.WriteLine("You enter " + q + "," + w + "," + e);

// Task 4 
Console.WriteLine("Enter 2 integer numbers. It must be > 0");
int z = int.Parse(Console.ReadLine());
int x = int.Parse(Console.ReadLine());
if (z > 0)
{
    Console.WriteLine("z correct");
}
else
{
    Console.WriteLine("z is lower");
}
if (x > 0)
{
    Console.WriteLine("x correct");
}
else
{
    Console.WriteLine("x is lower");
}
*/
// Homework task 1
Console.Write("Side of the square is ");
int a = int.Parse(Console.ReadLine());
Console.Write("Area is ");
Console.WriteLine(a * a);
Console.Write("Perimeter is ");
Console.WriteLine(a * 4);
// Homework task 2
Console.WriteLine("What is your name?") ;
string name = Console.ReadLine();
Console.WriteLine("How old are you, " + name + "?");
int age = int.Parse(Console.ReadLine());
Console.WriteLine( $"Hi {name} , {age}");
// Homework task 3
Console.WriteLine("Enter radius: ");
double r = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * r * r;
double lenght = 2 * Math.PI * r;
double volume = 4 / 3 * Math.PI * r * r * r;
Console.WriteLine("Area of circle: " + area);
Console.WriteLine("Lenght of circle: " + lenght);
Console.WriteLine("Volume of circle: " + volume);