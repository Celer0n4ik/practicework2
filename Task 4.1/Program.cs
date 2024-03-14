using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Roman Numeral:");
        string romanNumeral = Console.ReadLine();

        int result = RomanToInt(romanNumeral);
        Console.WriteLine("Roman Numeral: " + romanNumeral);
        Console.WriteLine("Integer Value: " + result);

        Console.ReadKey();
    }

    static int RomanToInt(string romanNumeral)
    {
        Dictionary<char, int> romanDict = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        for (int i = 0; i < romanNumeral.Length; i++)
        {
            int currentDigit = romanDict[romanNumeral[i]];
            if (i < romanNumeral.Length - 1 && currentDigit < romanDict[romanNumeral[i + 1]])
            {
                result -= currentDigit;
            }
            else
            {
                result += currentDigit;
            }
        }

        return result;
    }
}