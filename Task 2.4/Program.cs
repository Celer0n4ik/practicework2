using System;

class Counter
{
    private int count;

    public int Count
    {
        get { return count; }
    }

    public Counter()
    {
        count = 0;
    }

    public Counter(int initialValue)
    {
        count = initialValue;
    }

    public void Increment()
    {
        count++;
    }

    public void Decrement()
    {
        count--;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter1 = new Counter();

        counter1.Increment();
        Console.WriteLine("Counter 1 Value: " + counter1.Count);

        Counter counter2 = new Counter(10);

        counter2.Decrement();
        Console.WriteLine("Counter 2 Value: " + counter2.Count);

        Console.ReadKey();
    }
}