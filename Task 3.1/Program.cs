using System;

class Worker
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Rate { get; set; }
    public int Days { get; set; }

    public double GetSalary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Worker worker = new Worker();

        Console.WriteLine("Enter worker's name:");
        worker.Name = Console.ReadLine();

        Console.WriteLine("Enter worker's surname:");
        worker.Surname = Console.ReadLine();

        Console.WriteLine("Enter worker's rate per day:");
        worker.Rate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of days worked:");
        worker.Days = int.Parse(Console.ReadLine());

        double salary = worker.GetSalary();
        Console.WriteLine("Worker's salary: $" + salary);

        Console.ReadKey();
    }
}