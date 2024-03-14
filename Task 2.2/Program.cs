using System;

class Train
{
    public string Destination { get; set; }
    public int TrainNumber { get; set; }
    public DateTime DepartureTime { get; set; }

    public Train(string destination, int trainNumber, DateTime departureTime)
    {
        Destination = destination;
        TrainNumber = trainNumber;
        DepartureTime = departureTime;
    }

    public void PrintTrainInfo()
    {
        Console.WriteLine("Train Information:");
        Console.WriteLine("Destination: " + Destination);
        Console.WriteLine("Train Number: " + TrainNumber);
        Console.WriteLine("Departure Time: " + DepartureTime.ToString("HH:mm"));
        Console.ReadKey();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Train[] trains = new Train[3];

        trains[0] = new Train("Moscow", 123, new DateTime(2022, 1, 1, 10, 0, 0));
        trains[1] = new Train("St. Petersburg", 456, new DateTime(2022, 1, 1, 12, 0, 0));
        trains[2] = new Train("Kazan", 789, new DateTime(2022, 1, 1, 14, 0, 0));

        Console.WriteLine("Enter the Train Number:");
        int trainNumber = int.Parse(Console.ReadLine());

        bool foundTrain = false;
        foreach (Train train in trains)
        {
            if (train.TrainNumber == trainNumber)
            {
                train.PrintTrainInfo();
                foundTrain = true;
                break;
            }
        }

        if (!foundTrain)
        {
            Console.WriteLine("Train not found!");
            Console.ReadKey();
        }
    }
}