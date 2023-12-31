﻿using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();

        int index = FindSubArraysWithEqualSums(numbers);

        if (index != -1)
            Console.WriteLine(index);
        else
            Console.WriteLine("no");
    }
    static int FindSubArraysWithEqualSums(int[] arrayOfNumbers)
    {
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            int leftSum = arrayOfNumbers.Take(i).Sum();
            int rightSum = arrayOfNumbers.Skip(i + 1).Sum();

            if (leftSum == rightSum)
                return i;
        }

        return -1;
    }
}





