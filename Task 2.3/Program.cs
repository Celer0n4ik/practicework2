using System;

class Numbers
{
    public int Number1 { get; set; }
    public int Number2 { get; set; }

    public void PrintNumbers()
    {
        Console.WriteLine("Number 1: " + Number1);
        Console.WriteLine("Number 2: " + Number2);
    }

    public void ChangeNumbers(int newNumber1, int newNumber2)
    {
        Number1 = newNumber1;
        Number2 = newNumber2;
    }

    public int SumNumbers()
    {
        return Number1 + Number2;
    }

    public int FindMaxNumber()
    {
        return Math.Max(Number1, Number2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Numbers numbers = new Numbers();

        Console.WriteLine("Enter Number 1:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Number 2:");
        int number2 = int.Parse(Console.ReadLine());

        numbers.ChangeNumbers(number1, number2);

        Console.WriteLine("Numbers:");
        numbers.PrintNumbers();

        int sum = numbers.SumNumbers();
        Console.WriteLine("Sum of Numbers: " + sum);

        int max = numbers.FindMaxNumber();
        Console.WriteLine("Max Number: " + max);

        Console.ReadKey();
    }
}