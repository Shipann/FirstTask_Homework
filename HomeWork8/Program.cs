using System;
using System.Collections.Generic;
using System.Linq;

abstract class Shape : IComparable<Shape>
{
    protected string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Shape(string name)
    {
        this.name = name;
    }

    public abstract double Area();
    public abstract double Perimeter();

    public int CompareTo(Shape other)
    {
        if (other == null)
            return -1;

        return this.Area().CompareTo(other.Area());
    }
}

class Circle : Shape
{
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * radius * radius;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Square : Shape
{
    private double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    public Square(string name, double side) : base(name)
    {
        this.side = side;
    }

    public override double Area()
    {
        return side * side;
    }

    public override double Perimeter()
    {
        return 4 * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter the details of shape {0}:", i + 1);
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Select the type of shape:\n1. Circle\n2. Square");
            Console.Write("Choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Please enter 1 for Circle or 2 for Square.");
                Console.Write("Choice: ");
            }

            if (choice == 1)
            {
                double radius;
                Console.Write("Radius: ");
                while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
                {
                    Console.WriteLine("Invalid radius. Please enter a positive number.");
                    Console.Write("Radius: ");
                }

                shapes.Add(new Circle(name, radius));
            }
            else if (choice == 2)
            {
                double side;
                Console.Write("Side: ");
                while (!double.TryParse(Console.ReadLine(), out side) || side <= 0)
                {
                    Console.WriteLine("Invalid side length. Please enter a positive number.");
                    Console.Write("Side: ");
                }

                shapes.Add(new Square(name, side));
            }

            Console.WriteLine();
        }

        Console.WriteLine("Shape Details:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Name: {0}", shape.Name);
            Console.WriteLine("Area: {0}", shape.Area());
            Console.WriteLine("Perimeter: {0}", shape.Perimeter());
            Console.WriteLine();
        }

        Shape shapeWithLargestPerimeter = shapes.OrderByDescending(shape => shape.Perimeter()).First();
        Console.WriteLine("Shape with the largest perimeter: {0}", shapeWithLargestPerimeter.Name);

        shapes.Sort();

        Console.WriteLine("Sorted shapes by area:");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("Name: {0}", shape.Name);
            Console.WriteLine("Area: {0}", shape.Area());
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
