using System;
class Program
{
    static void Main(string[] args)
    {
        string Jewels = Console.ReadLine();
        string Stones = Console.ReadLine();

        int count = 0;
        foreach (char jewel in Jewels)
        {
            foreach (char stone in Stones)
            {
                if (stone == jewel)
                {
                    count++;
                }
            }
        }

        Console.WriteLine("Количество символов из S, которые являются драгоценностями: " + count);
        Console.ReadKey();
    }
}