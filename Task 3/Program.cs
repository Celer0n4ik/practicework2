using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите элементы массива: ");
        int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        bool containsDuplicate = ContainsDuplicate(nums);

        Console.WriteLine(containsDuplicate);
        Console.ReadKey();
    }

    static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> uniqueNums = new HashSet<int>();

        foreach (int num in nums)
        {
            if (uniqueNums.Contains(num))
            {
                return true;
            }

            uniqueNums.Add(num);
        }

        return false;
    }
}