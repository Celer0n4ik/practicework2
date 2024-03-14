using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите элементы массива candidates: ");
        int[] candidates = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.Write("Введите цель: ");
        int target = int.Parse(Console.ReadLine());

        List<List<int>> result = CombinationSum(candidates, target);

        Console.WriteLine("Уникальные комбинации чисел с суммой " + target + ":");
        foreach (List<int> combination in result)
        {
            foreach (int num in combination)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> combination = new List<int>();

        Array.Sort(candidates);
        FindCombinations(candidates, target, 0, combination, result);

        return result;
    }

    static void FindCombinations(int[] candidates, int target, int startIndex, List<int> combination, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = startIndex; i < candidates.Length; i++)
        {
            if (candidates[i] > target)
            {
                break;
            }

            if (i > startIndex && candidates[i] == candidates[i - 1])
            {
                continue;
            }

            combination.Add(candidates[i]);
            FindCombinations(candidates, target - candidates[i], i + 1, combination, result);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}