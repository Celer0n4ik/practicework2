using System;

class MyClass
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public MyClass(int number1, int number2)
    {
        Number1 = number1;
        Number2 = number2;
    }

    public MyClass()
    {
        Number1 = 0;
        Number2 = 0;
    }

    ~MyClass()
    {
        Console.WriteLine("Object destructed");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject1 = new MyClass(10, 20);
        Console.WriteLine("Number 1: " + myObject1.Number1);
        Console.WriteLine("Number 2: " + myObject1.Number2);

        MyClass myObject2 = new MyClass();
        Console.WriteLine("Number 1: " + myObject2.Number1);
        Console.WriteLine("Number 2: " + myObject2.Number2);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}