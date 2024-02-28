using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

public class GenerateChangeNumbersFourTimes
{
    public static Tuple<int, BigInteger> GenerateNumber()
    {
        List<BigInteger> numbers = new List<BigInteger>();
        int position = GenerateNumbersHelper(new StringBuilder(), 4, numbers);
        return Tuple.Create(position, numbers[numbers.Count - 1]);
    }

    private static int GenerateNumbersHelper(StringBuilder currentNumber, int requiredChanges, List<BigInteger> numbers)
    {
        int position = -1;

        if (currentNumber.Length > 0)
        {
            int changes = CountChanges(currentNumber.ToString());
            if (changes == requiredChanges)
            {
                numbers.Add(BigInteger.Parse(currentNumber.ToString()));
                position = numbers.Count;
            }
        }

        if (currentNumber.Length < 20) // Adjust the length limit as needed
        {
            currentNumber.Append("4");
            int newPosition = GenerateNumbersHelper(currentNumber, requiredChanges, numbers);
            if (newPosition != -1)
                position = newPosition;
            currentNumber.Length--; // Backtrack

            currentNumber.Append("7");
            newPosition = GenerateNumbersHelper(currentNumber, requiredChanges, numbers);
            if (newPosition != -1)
                position = newPosition;
            currentNumber.Length--; // Backtrack
        }

        return position;
    }

    private static int CountChanges(string number)
    {
        int changes = 0;
        for (int i = 1; i < number.Length; i++)
        {
            if (number[i] != number[i - 1])
            {
                changes++;
            }
        }
        return changes;
    }
}
