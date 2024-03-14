using System;

class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;

    public string GetName()
    {
        return name;
    }

    public void SetName(string value)
    {
        name = value;
    }

    public string GetSurname()
    {
        return surname;
    }

    public void SetSurname(string value)
    {
        surname = value;
    }

    public double GetRate()
    {
        return rate;
    }

    public void SetRate(double value)
    {
        rate = value;
    }

    public int GetDays()
    {
        return days;
    }

    public void SetDays(int value)
    {
        days = value;
    }

    public double GetSalary()
    {
        return rate * days;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker();

        Console.WriteLine("Enter worker's name:");
        worker.SetName(Console.ReadLine());

        Console.WriteLine("Enter worker's surname:");
        worker.SetSurname(Console.ReadLine());

        Console.WriteLine("Enter worker's rate per day:");
        worker.SetRate(double.Parse(Console.ReadLine()));

        Console.WriteLine("Enter number of days worked:");
        worker.SetDays(int.Parse(Console.ReadLine()));

        double salary = worker.GetSalary();
        Console.WriteLine("Worker's salary: $" + salary);

        Console.ReadKey();
    }
}