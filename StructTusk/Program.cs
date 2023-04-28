struct Dog
{
    public string name;
    public string mark;
    public int age;

    public Dog(string name, string mark, int age)
    {
        this.name = name;
        this.mark = mark;
        this.age = age;
    }

    public override string ToString()
    {
        return $"Name: {name}, Mark: {mark}, Age: {age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog("Bolt", "Huskey", 4);

        Console.WriteLine(myDog.ToString());
        
    }
}