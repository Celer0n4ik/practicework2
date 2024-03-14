using System;

class Calculation
{
    private string calculationLine;

    public string CalculationLine
    {
        get { return calculationLine; }
    }

    public void SetCalculationLine(string line)
    {

        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (string.IsNullOrEmpty(calculationLine))
        {
            throw new InvalidOperationException("Calculation line is empty");
        }

        return calculationLine[calculationLine.Length - 1];
    }

    public void DeleteLastSymbol()
    {
        if (string.IsNullOrEmpty(calculationLine))
        {
            throw new InvalidOperationException("Calculation line is empty");
        }

        calculationLine = calculationLine.Substring(0, calculationLine.Length - 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculation calculation = new Calculation();

        Console.WriteLine("Enter calculation line:");
        string line = Console.ReadLine();
        calculation.SetCalculationLine(line);

        Console.WriteLine("Enter symbol to add:");
        char symbol = Console.ReadKey().KeyChar;
        calculation.SetLastSymbolCalculationLine(symbol);
        Console.WriteLine();

        Console.WriteLine("Calculation Line: " + calculation.GetCalculationLine());
        Console.WriteLine("Last Symbol: " + calculation.GetLastSymbol());

        calculation.DeleteLastSymbol();
        Console.WriteLine("Calculation Line after deleting last symbol: " + calculation.GetCalculationLine());

        Console.ReadKey();
    }
}